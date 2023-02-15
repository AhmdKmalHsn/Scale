using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace scale
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        bool c = false;
        private void Form6_Load(object sender, EventArgs e)
        {            
            // TODO: This line of code loads data into the 'databaseDataSet1.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.FillBy(this.databaseDataSet1.Users);
            comboBox1.Text = Properties.Settings.Default.serverTable;
            comboBox2.Text = Properties.Settings.Default.PortName;
            comboBox3.Text = Properties.Settings.Default.baudRate;
            comboBox4.Text = Properties.Settings.Default.stopBits;
            comboBox5.Text = Properties.Settings.Default.dataBits;
            comboBox6.Text = Properties.Settings.Default.stopString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.usersTableAdapter.Update(this.databaseDataSet1.Users);
            Properties.Settings.Default.serverTable=comboBox1.Text;
            Properties.Settings.Default.PortName = comboBox2.Text;
            Properties.Settings.Default.baudRate = comboBox3.Text;
            Properties.Settings.Default.stopBits = comboBox4.Text;
            Properties.Settings.Default.dataBits = comboBox5.Text;
            Properties.Settings.Default.stopString = comboBox6.Text;
            Properties.Settings.Default.Save();
            
            SqlDataAdapter da = new SqlDataAdapter();
            MessageBox.Show("تم الحفظ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c = true;
            this.Close();
            new Form2().Show();
            //this.usersTableAdapter.Fill(textbox1.Text);
        }

        private void close(object sender, FormClosedEventArgs e)
        {
            if (!c) Application.Exit();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.usersTableAdapter.FillBy(this.databaseDataSet1.Users);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void textbox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
