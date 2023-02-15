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

namespace scale
{
    public partial class Form5 : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + Path.GetFullPath("Database.mdf") + ";Integrated Security=True;User Instance=True");
        bool c = false;
        public Form5()
        {
            InitializeComponent();
        }

        void load_data(string ID)
        {
            try
            {
                //MessageBox.Show(Form2._CAR_NO + ":"+Form2._W);
                //SqlCommand cmd0 = new SqlCommand("insert into [Table] (car_no,user_id) VALUES(" + Form2._CAR_NO + ",'" + Form1.users + "');", sqlcon);// 
                string q1 = "select Id,car_no,driver_name,client_name,item_type,gov,move_type, f_w, f_time ,car_no2,perm_no,s_w,s_time,pure,user_id from[Table] where Id = " + ID ;                                                                                                               /*1*/
                SqlCommand cmd1 = new SqlCommand(q1, sqlcon);                                                                                                                                                                                                                                                                     /*2*/
                //SqlCommand cmd2 = new SqlCommand("select Id,car_no,driver_name,client_name,item_type,gov,move_type, f_w, CAST(f_time as date),format(f_time,'hh:mm:ss tt'),car_no2,perm_no from[Table] where car_no = " + Form2._CAR_NO + "and f_w is not NULL and s_w is NULL; ", sqlcon);//  
                if (sqlcon.State == ConnectionState.Closed) { sqlcon.Open(); }//open connection
                SqlDataReader reader;

                reader = cmd1.ExecuteReader();

                while (reader.Read())
                {
                    LId.Text = reader[0].ToString();
                    LCarNo.Text = reader[1].ToString();
                    LDriver.Text = reader[2].ToString();
                    LClient.Text = reader[3].ToString();
                    LItem.Text = reader[4].ToString();
                    LGov.Text = reader[5].ToString();
                    LMoveType.Text = reader[6].ToString();
                    LFW.Text = reader[7].ToString();
                    //LFWD.Text = reader[8].ToString();
                    LFWT.Text = reader[8].ToString();
                    LCarNo2.Text = reader[9].ToString();
                    LPermNo.Text = reader[10].ToString();
                    LSW.Text = reader[11].ToString();
                    //LSWD.Text = reader[13].ToString();
                    LSWT.Text = reader[12].ToString();
                    LPure.Text = reader[13].ToString();
                    LWer.Text = reader[14].ToString();
                }
                if (sqlcon.State == ConnectionState.Open) { sqlcon.Close(); }
            }
            catch (Exception ) {  }

        }

        void combo_set()
        {
            string q1 = "select distinct gov from( select RTRIM(gov) as gov from [Table] where gov is not NULL and gov != '') A";
            string q2 = "select distinct driver_name from( select RTRIM(driver_name ) as driver_name from [Table] where driver_name is not NULL and driver_name != '') A";
            string q3 = "select distinct client_name from( select RTRIM(client_name) as client_name from [Table] where client_name is not NULL and client_name != '') A";
            string q4 = "select distinct item_type from( select RTRIM(item_type) as item_type from [Table] where item_type is not NULL and item_type != '') A";
            SqlDataAdapter adp1 = new SqlDataAdapter(q1, sqlcon);
            SqlDataAdapter adp2 = new SqlDataAdapter(q2, sqlcon);
            SqlDataAdapter adp3 = new SqlDataAdapter(q3, sqlcon);
            SqlDataAdapter adp4 = new SqlDataAdapter(q4, sqlcon);
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();
            DataTable dt4 = new DataTable();
            adp1.Fill(dt1);
            adp2.Fill(dt2);
            adp3.Fill(dt3);
            adp4.Fill(dt4);
            //LId.AutoCompleteCustomSource = dt1;
            LGov.DataSource = dt1;
            LDriver.DataSource = dt2;
            LClient.DataSource = dt3;
            LItem.DataSource = dt4;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            combo_set();
            LGov.Text="";
            LDriver.Text="";
            LClient.Text="";
            LItem.Text = "";
            if (Form4._id!="")
            load_data(Form4._id);
            
        }
        
        Bitmap MemoryImage;
        
        public void GetPrintArea(Panel pnl)
        {
            MemoryImage = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(MemoryImage, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }
    
        public void Print(Panel pnl)
        {
            GetPrintArea(pnl);
            printDocument1.Print();
        }

        private void PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(MemoryImage, 0, 0, 800, 550);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف السجل?",
                        "حذف",
                         MessageBoxButtons.YesNoCancel,
                         MessageBoxIcon.Information) == DialogResult.Yes)
            {
                SqlCommand delete = new SqlCommand("delete from [Table] where id=" + LId.Text + "; ", sqlcon);// 
                try
                {
                    if (sqlcon.State == ConnectionState.Closed) { sqlcon.Open(); }

                    delete.ExecuteNonQuery();///////count user 

                    if (sqlcon.State == ConnectionState.Open) { sqlcon.Close(); }

                }
                catch (Exception ex ) { MessageBox.Show(ex.Message); };
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            c = true;
            new Form2().Show();
            this.Close();
        }

        private void keypress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                load_data(LId.Text);
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            panel1.BackColor = Color.White;
            Print(this.panel1);
            panel1.BackColor = Color.FromArgb(105, 13, 26);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmdUpdate = new SqlCommand(
       "update [Table] set " +
       "perm_no='" + LPermNo.Text +
       "',gov=N'" + LGov.Text +
       "',car_no2='" + LCarNo2.Text +
       "',driver_name=N'" + LDriver.Text +
       "',client_name=N'" + LClient.Text +
       "',move_type=N'" + LMoveType.Text +
       "',item_type=N'" + LItem.Text +
       "' where Id =" + LId.Text, sqlcon);//  
                if (sqlcon.State == ConnectionState.Closed) { sqlcon.Open(); }//open connection
                cmdUpdate.ExecuteNonQuery();
                if (sqlcon.State == ConnectionState.Open) { sqlcon.Close(); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            c = true;
            new Form4().Show();
            this.Close();
        }

        private void text_change(object sender, EventArgs e)
        {
            
        }

        private void closed(object sender, FormClosedEventArgs e)
        {
           if(!c)Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

    }
}
