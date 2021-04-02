using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ExtractDBDataToExcel
{
    public partial class Form1 : Form
    {
        private string userScript = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void browseScript_button_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                filepath_textBox.Text = file;
                try
                {
                    userScript = File.ReadAllText(file);
                    if(userScript.Length == 0)
                        MessageBox.Show("Empty File!");
                }
                catch (IOException ioex)
                {
                    MessageBox.Show(ioex.Message);
                }
            }
        }

        private void runScript_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(serverUrl_textBox.Text.Trim()))
            {
                MessageBox.Show("Please enter a Server URL");
                serverUrl_textBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(username_textBox.Text.Trim()))
            {
                MessageBox.Show("Please enter a User Name");
                username_textBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password_textBox.Text.Trim()))
            {
                MessageBox.Show("Please enter a Password");
                password_textBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(filepath_textBox.Text.Trim()))
            {
                MessageBox.Show("Please select a script file");
                password_textBox.Focus();
                return;
            }
            UserInputs userInputs = new UserInputs()
            {
                ServerUrl = serverUrl_textBox.Text,
                UserName = username_textBox.Text,
                Password = password_textBox.Text
            };
            if (remember_checkBox.Checked == true)
            {
                saveUserInputs(userInputs);
            }

            executeScript(userInputs);
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            serverUrl_textBox.ResetText();
            username_textBox.ResetText();
            password_textBox.ResetText();
            filepath_textBox.ResetText();
        }

        private void saveUserInputs(UserInputs userInputs)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(UserInputs));

            string serverDetailsFilename = string.Concat(Regex.Replace(serverUrl_textBox.Text, "[^a-zA-Z0-9_.]+", "", RegexOptions.Compiled) , ".xml");

            using (TextWriter textWriter = new StreamWriter(serverDetailsFilename))
            {
                serializer.Serialize(textWriter, userInputs);
            }
        }


        private void CreateFileOrFolder(string filename)
        {
            string folderName = @"ServerFileStructure";   
                
            string pathString = System.IO.Path.Combine(folderName, "UserInputs");
                
            System.IO.Directory.CreateDirectory(pathString);

            string fileName = filename;

            pathString = System.IO.Path.Combine(pathString, fileName);

            if (!System.IO.File.Exists(pathString))
            {
                System.IO.FileStream fs = System.IO.File.Create(pathString);
            }
            else
            {
                Console.WriteLine("File \"{0}\" already exists.", fileName);
                return;
            }
        }

        private void executeScript(UserInputs userInputs)
        {
            try
            {
                string str = string.Concat("server=" , userInputs.ServerUrl, ";UID=", userInputs.UserName + "; password=", userInputs.Password);

                string query = userScript;

                SqlConnection con = new SqlConnection(str);

                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();

                DataSet dataSet = new DataSet();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(dataSet);

                try
                {
                    Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();

                    Workbook xlWorkbook = ExcelApp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);

                    DataTableCollection collection = dataSet.Tables;

                    for (int i = collection.Count; i > 0; i--)
                    {
                        Sheets xlSheets = null;
                        Worksheet xlWorksheet = null;

                        //Create Excel Sheets
                        xlSheets = ExcelApp.Sheets;

                        xlWorksheet = (Worksheet)xlSheets.Add(xlSheets[1], Type.Missing, Type.Missing, Type.Missing);
                        
                        System.Data.DataTable table = collection[i - 1];

                        xlWorksheet.Name = table.TableName;

                        for (int j = 1; j < table.Columns.Count + 1; j++)
                        {
                            ExcelApp.Cells[1, j] = table.Columns[j - 1].ColumnName;
                        }
                        // Storing Each row and column value to excel sheet
                        for (int k = 0; k < table.Rows.Count; k++)
                        {
                            for (int l = 0; l < table.Columns.Count; l++)
                            {
                                ExcelApp.Cells[k + 2, l + 1] = table.Rows[k].ItemArray[l].ToString();
                            }
                        }
                        ExcelApp.Columns.AutoFit();
                    }

                    ((Worksheet)ExcelApp.ActiveWorkbook.Sheets[ExcelApp.ActiveWorkbook.Sheets.Count]).Delete();

                    ExcelApp.Visible = true;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
    }

    public class UserInputs
    {
        public string ServerUrl { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }
    }
}
