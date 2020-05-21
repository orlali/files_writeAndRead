using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace files_writeAndRead
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWriteData_Click(object sender, EventArgs e)
        {
            string textData = txtDataToAdd.Text;
            //System.IO.File.WriteAllText(@"C:\13CSC\files_writeAndRead\textData.txt", textData);
            
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\13CSC\files_writeAndRead\textData.txt", true))
            {
                file.WriteLine(textData);
            }
            
        }

        private void btnReadData_Click(object sender, EventArgs e)
        {
            //string text = System.IO.File.ReadAllText(@"C:\13CSC\files_writeAndRead\textData.txt");
            //lblDisplayData.Text = text;
            
            string[] lines = System.IO.File.ReadAllLines("testDebugFolderText.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                lblDisplayData.Text += "\n" + lines[i];
            }


        }
    }
}
