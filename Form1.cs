using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Training_C_Sharp;

namespace WorkForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void testButton_Click(object sender, EventArgs e)
        {
            var testWork = new Work();
            testWork.Name = txtBoxWorkName.Text;
            txtWorkOutputLabel.Text = txtBoxWorkName.Text;
            testWork.Address = txtBoxWorkAddr.Text;
            testWork.PhoneNumber = txtBoxWorkPhone.Text;
            try
            {
                testWork.TwitterAddress = txtBoxWorkTwitter.Text;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBoxWorkPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWorkName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtWorkOutputLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
