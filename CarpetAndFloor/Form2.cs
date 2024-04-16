using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarpetAndFloor
{
    public partial class Form2 : Form
    {
        //public static string jeff = String.Empty;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();           
            sb.Append("4501 Amnicola Highway");
            sb.Append(Environment.NewLine);
            sb.Append("Chattanooga, TN 37406-1018");
            sb.Append(Environment.NewLine);
            sb.Append("423-697-5564");
            sb.Append(Environment.NewLine);
            txtCompanyAddress.Text = sb.ToString();

            txtAddressOutput.Text = Form1.ValueForTxtAddressOutput;
            txtAddressOutput.Font = Form1.ValueForFont;            
            txtAddressOutput.ForeColor = Form1.ValueForColor;

            richTextBox1.Text = Form1.ValueForTxtQuotation;
            richTextBox1.Font = Form1.ValueForFont;
            richTextBox1.ForeColor = Form1.ValueForColor;

            string today = Form1.localDate.ToLongDateString();
            DateTime todaysDate = DateTime.Parse(today);
            DateTime expiryDate = todaysDate.AddDays(30);
            string output = expiryDate.ToLongDateString();
            
            label3.Text = "Quotation expires " + output;
            label4.Text = todaysDate.ToLongDateString();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDlg.AllowSomePages = true;
            printDlg.ShowHelp = true;
            printDlg.Document = printDoc;

            //Call ShowDialog
            if (printDlg.ShowDialog() == DialogResult.OK) printDoc.Print();
            

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
