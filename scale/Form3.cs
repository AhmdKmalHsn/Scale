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
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Threading;

namespace scale
{
    public partial class Form3 : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + Path.GetFullPath(@"Database.mdf") + ";Integrated Security=True;User Instance=True");
        Bitmap MemoryImage;
        bool c = false;
        
        public Form3()
        {
            InitializeComponent();
            LScreen.Text = "";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            user.Text = Form1.users;
            LWer.Text = Form1.users;
            combo_set();
            load_data();
            try
            {
                if (!serialPort1.IsOpen) serialPort1.Open();
            }
            catch (Exception) { LScreen.Text = ""; }
            
            if (Form2._W == 0)
            {
                label10.Visible = false;
                label9.Visible = false;
                LSWT.Visible = false;
                LSW.Visible = false;
                LPure.Visible = false;
            } //اخفاء الوزنة الثانية والصافي
        }
         
        void load_time()
        {
            try
            {
                
                SqlCommand cmd1 = new SqlCommand("select  s_time , f_time  from[Table] where id = " +LId.Text  , sqlcon);//  
               
                if (sqlcon.State == ConnectionState.Closed) { sqlcon.Open(); }//open connection
                
                SqlDataReader reader;
                
                reader = cmd1.ExecuteReader();
                
                while (reader.Read())
                {
                    
                    LSWT.Text = reader[0].ToString();
                    LFWT.Text = reader[1].ToString();
                    
                }
                if (sqlcon.State == ConnectionState.Open) { sqlcon.Close(); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        
        void load_data()
        {
            try
            {
                SqlCommand cmd0 = new SqlCommand("insert into [Table] (car_no,user_id) VALUES(" + Form2._CAR_NO + ",'" + Form1.users + "')", sqlcon);// 
                SqlCommand cmd1 = new SqlCommand("select Id,car_no,driver_name,client_name,item_type,gov,move_type, f_w, s_time , f_time ,car_no2,perm_no from[Table] where car_no = " + Form2._CAR_NO + "and f_w is NULL and s_w is NULL ", sqlcon);//  
                SqlCommand cmd2 = new SqlCommand("select Id,car_no,driver_name,client_name,item_type,gov,move_type, f_w, s_time , f_time AS Expr1,car_no2,perm_no from[Table] where car_no = " + Form2._CAR_NO + "and f_w is not NULL and s_w is NULL ", sqlcon);//  

                if (sqlcon.State == ConnectionState.Closed) { sqlcon.Open(); }//open connection
                SqlDataReader reader;
                if (Form2._W == 0)
                {
                    cmd0.ExecuteNonQuery();
                    reader = cmd1.ExecuteReader();
                }
                else
                {
                    reader = cmd2.ExecuteReader();
                }
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
                    //LSWT.Text = reader[8].ToString();
                    LFWT.Text = reader[9].ToString();
                    LCarNo2.Text = reader[10].ToString();
                    LPermNo.Text = reader[11].ToString();
                }
                if (sqlcon.State == ConnectionState.Open) { sqlcon.Close(); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
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
            LGov.DataSource = dt1;
            LDriver.DataSource = dt2;
            LClient.DataSource = dt3;
            LItem.DataSource = dt4;
        }
        
        void update_data() {
            try
            {
                SqlCommand cmdUpdate = new SqlCommand(
               "update [Table] set perm_no='" + LPermNo.Text +
               "',gov=N'" + LGov.Text +
               "',car_no2='" + LCarNo2.Text +
               "',driver_name=N'" + LDriver.Text +
               "',client_name=N'" + LClient.Text +
               "',move_type=N'" + LMoveType.Text +
               "',item_type=N'" + LItem.Text +
               "' where Id =" + LId.Text, sqlcon);//  
                if (sqlcon.State == ConnectionState.Closed)sqlcon.Open(); 
                     cmdUpdate.ExecuteNonQuery();
                if (sqlcon.State == ConnectionState.Open)sqlcon.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void GetPrintArea(Panel pnl)
        {
            // pnl.BackColor = Color.White;
            MemoryImage = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(MemoryImage, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        public void Print(Panel pnl)
        {
            GetPrintArea(pnl);
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(MemoryImage, 20, 25, 800, 450);
        }

        private void dataRecieve(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
          if(Properties.Settings.Default.stopString=="1")
            {
                try
                {
                    string data = serialPort1.ReadTo("L");
                    data = Regex.Match(data, @"\d+").Value;
                    LScreen.Text = "" + int.Parse(data);
                }
                catch (Exception) { LScreen.Text = ""; }
            }else{
                try
                {
                    string data = serialPort1.ReadTo("000000");
                    if (data.Length > 6)
                    {
                        data = data.Split(' ')[1];
                    }
                    else
                    {
                        //data = s;
                    }
                    data = data.PadRight(6, '0');
                    data = Regex.Match(data, @"\d+").Value;
                    LScreen.Text = "" + int.Parse(data);
                }
                catch (Exception) { LScreen.Text = ""; }

        }
    }

        private void button1_Click(object sender, EventArgs e)//printing btn
        {
            
            panel1.BackColor = Color.White;
            Print(panel1);
            panel1.BackColor = Color.FromArgb(105, 13, 26); 
        }

        private void LFW_Click(object sender, EventArgs e)
        {
            //الوزنة الاولي
            if (Form2._W == 0)
            {
                LFW.Text = LScreen.Text;
                try
                {
            SqlCommand cmdUpdate = new SqlCommand(
           "update [Table] set f_w='" + LScreen.Text +
           "',f_time=CURRENT_TIMESTAMP where Id =" + LId.Text, sqlcon);//  
                    if (sqlcon.State == ConnectionState.Closed) sqlcon.Open();//open connection
                    cmdUpdate.ExecuteNonQuery();
                    if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                //@Update f_w ,time stamp
            }
            //load_data();
            load_time();
        }

        private void LSW_Click(object sender, EventArgs e)
        {
            //الوزنة الثانية 
            if (Form2._W == 1)
            {
                LSW.Text = LScreen.Text;
                LPure.Text = "" + Math.Abs(int.Parse(LSW.Text) - int.Parse(LFW.Text));
                try
                {
                    SqlCommand cmdUpdate = new SqlCommand(
                    "update [Table] set " +
                    "s_w='" + LScreen.Text +
                    "',pure='" + LPure.Text +
                    "',s_time=CURRENT_TIMESTAMP where Id =" + LId.Text, sqlcon);//  
                    if (sqlcon.State == ConnectionState.Closed)sqlcon.Open();//open connection
                    cmdUpdate.ExecuteNonQuery();
                    if (sqlcon.State == ConnectionState.Open)sqlcon.Close();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

                //@Update f_w ,time stamp
            }
            load_time();
        }

        private void button2_Click(object sender, EventArgs e)//delete
        {

            if (MessageBox.Show("هل تريد حذف السجل?",
                        "حذف",
                         MessageBoxButtons.YesNoCancel,
                         MessageBoxIcon.Information) == DialogResult.Yes)
            {
                SqlCommand delete = new SqlCommand("delete from [Table] where id=" + LId.Text , sqlcon);// 
                try
                {
                    if (sqlcon.State == ConnectionState.Closed) { sqlcon.Open(); }

                    delete.ExecuteNonQuery();
                    //MessageBox.Show("لقد تم الحذف");
                    if (sqlcon.State == ConnectionState.Open) { sqlcon.Close(); }
                    this.serialPort1.DataReceived -= new System.IO.Ports.SerialDataReceivedEventHandler(this.dataRecieve);
                    Thread.Sleep(200);
                    if (serialPort1.IsOpen)
                    {
                        serialPort1.DiscardInBuffer();
                        serialPort1.DiscardOutBuffer();
                        serialPort1.Close();
                    }
                    c = true;
                    new Form2().Show();
                    this.Close();
                }
                catch (Exception) { };
            }
        }

        private void button3_Click(object sender, EventArgs e)//back
        {
            {
                try
                {
                    this.serialPort1.DataReceived -= new System.IO.Ports.SerialDataReceivedEventHandler(this.dataRecieve);
                    Thread.Sleep(200);
                    if (serialPort1.IsOpen) {
                        serialPort1.DiscardInBuffer();
                        serialPort1.DiscardOutBuffer();
                        serialPort1.Close();
                    }   
                }
                catch (UnauthorizedAccessException) { LScreen.Text = ""; }
                catch (System.IO.IOException) { LScreen.Text = ""; }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                c = true;
                new Form2().Show();
                this.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)//undo
        {
            try
            {
                SqlCommand UNDO = new SqlCommand(
                "update [Table] set s_w=NULL,pure=NULL,s_time=NULL where Id =" + LId.Text , sqlcon);//  
                if (sqlcon.State == ConnectionState.Closed) { sqlcon.Open(); }//open connection
                UNDO.ExecuteNonQuery();
                LSW.Text = "";
                //LSWD.Text = "";
                LSWT.Text = "";
                LPure.Text = "";
                if (sqlcon.State == ConnectionState.Open) { sqlcon.Close(); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void closing(object sender, FormClosedEventArgs e)
        {
            if (LFW.Text == "")
            {
                SqlCommand delete = new SqlCommand("delete from [Table] where id='" + LId.Text+"' and f_w is NULL", sqlcon);
                try
                {
                    if (sqlcon.State == ConnectionState.Closed)sqlcon.Open(); 
                    delete.ExecuteNonQuery();
                    if (sqlcon.State == ConnectionState.Open)sqlcon.Close(); 
                }
                catch (Exception) { };
            }
            try
            {
                this.serialPort1.DataReceived -= new System.IO.Ports.SerialDataReceivedEventHandler(this.dataRecieve);
                Thread.Sleep(200);
                if (serialPort1.IsOpen)
                {
                    serialPort1.DiscardInBuffer();
                    serialPort1.DiscardOutBuffer();
                    serialPort1.Close();
                }
            }
            catch (UnauthorizedAccessException) { LScreen.Text = ""; }
            catch (System.IO.IOException) { LScreen.Text = ""; }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            if(!c)Application.Exit();
        }

        private void leave(object sender, EventArgs e)
        {
            update_data();
        }
    
    }
}
