using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Employee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnfolder_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\DotNetTraining-oct";
                if (Directory.Exists(path))
                {
                    MessageBox.Show("Folder is exists");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("Created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnfile_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\DotNetTraining-oct\TestFile.txt";
                if (File.Exists(path))
                {
                    MessageBox.Show("File is exists");
                }
                else
                {
                    File.Create(path);
                    MessageBox.Show("Created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                // BinaryWriter
                string path = @"C:\DotNetTraining-oct\emp.dat"; // .dat - data file
                FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Convert.ToInt32(textEmpId.Text));
                bw.Write(textEmpName.Text);
                bw.Write(Convert.ToDouble(textEmpSal.Text));
                bw.Close();
                fs.Close();// fs always open a file in buffer, once we close fs, file will be stored back to secondary storage
                MessageBox.Show("Data added to file");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\DotNetTraining-oct\emp.dat"; // .dat - data file
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                textEmpId.Text = br.ReadInt32().ToString(); // Id
                textEmpName.Text = br.ReadString(); // Name
                textEmpSal.Text = br.ReadDouble().ToString();// Salary
                br.Close();
                fs.Close();

            }
            catch (Exception ex)
            {

            }

        }
    }
}
