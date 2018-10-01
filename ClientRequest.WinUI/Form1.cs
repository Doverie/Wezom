using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientRequestLogic;

namespace ClientRequest.WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //string path = (Environment.CurrentDirectory.ToString() + "..\\..\\..\\..\\Wezom.xlsx");
            FolderLabel.Text = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Wezom.xlsx");
        }
        private void ButtonFolder_Click(object sender, EventArgs e)
        {
            string name = "\\Wezom.xlsx";
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.RootFolder = Environment.SpecialFolder.Desktop;
            folder.Description = "Choose the path to save the file ";
            folder.ShowNewFolderButton = true;

            if (folder.ShowDialog() == DialogResult.OK)
            {
                FolderLabel.Text = (folder.SelectedPath+name).ToString();
            }
        }
             
        private void OpenCreateButton_Click(object sender, EventArgs e)
        {
            
            ExelEditor logic = new ExelEditor();
            if (int.TryParse(CountOfCustomersTextBox.Text, out int countOfCustomers))

            {
                bool isSuccess = logic.SaveToFile(countOfCustomers, FolderLabel.Text);
                ErrorMessageLabel.Text = isSuccess ? "File is created/opened" : "Something is wrong.Please try again.";
                
            }
            else
            {
                ErrorMessageLabel.Text = "You entered incorrect information in 'CountOfCustomers'";
            }
        }

        private void FolderLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
