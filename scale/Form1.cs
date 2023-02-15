using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
//using Microsoft.Office.Interop.Excel;
namespace scale
{
    public partial class Form1 : Form
    {
        public static string users = "";
        
        public Form1()
        {
            InitializeComponent();
            
        }
        
        SqlConnection sqlcon = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + Path.GetFullPath(@"Database.mdf") + ";Integrated Security=True;User Instance=True");
         
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            if (Properties.Settings.Default.remember) connect(Properties.Settings.Default.user, Properties.Settings.Default.pass);
        }
        int result = 0;
        
        void connect(string user,string pass) {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT count (*) FROM [Users] where user_id = N'" + user + "' and password = N'" + pass + "'", sqlcon);//  

                if (sqlcon.State == ConnectionState.Closed) { sqlcon.Open(); }

                result = Convert.ToInt32(cmd.ExecuteScalar());///////count user 

                if (sqlcon.State == ConnectionState.Open) { sqlcon.Close(); }
                if (result > 0)
            {
                users = user;
                Form2 f2 = new Form2();
                this.Hide();
                f2.Show();     
            }
            else MessageBox.Show("من فضلك تأكد من اسم المستخدم والرقم السري");
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            
        }

        void create()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO [Users] (user_id,password) VALUES(N'" + textBox1.Text + "',N'" + textBox2.Text + "')", sqlcon);//  

                if (sqlcon.State == ConnectionState.Closed) { sqlcon.Open(); }

                cmd.ExecuteNonQuery();///////count user 
                MessageBox.Show("تم انشاء المستخدم بنجاح");

                if (sqlcon.State == ConnectionState.Open) { sqlcon.Close(); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.user = textBox1.Text;
            Properties.Settings.Default.pass = textBox2.Text;
            Properties.Settings.Default.remember = checkBox1.Checked;
            Properties.Settings.Default.Save();
            connect(textBox1.Text,textBox2.Text);
        }

        private void keypress1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBox2.Focus();
            }
        }

        private void keypress2(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                connect(textBox1.Text, textBox2.Text);
            }
        }

        private void close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            create();
        }
    }
}
