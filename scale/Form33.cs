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
    public partial class Form33 : Form
    {   
        SqlConnection sqlconS=new SqlConnection(@"Data Source=dc\sqlexpress2014;Initial Catalog=Database;Persist Security Info=True;User ID=mizan;Password=mizan@2020");
        SqlConnection sqlcon = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + Path.GetFullPath(@"Database.mdf") + ";Integrated Security=True;User Instance=True");
        bool c = false;
        Bitmap MemoryImage;

        public Form33()
        { 
            InitializeComponent();
            LScreen.Text = "";
        }
       
        void load_time()
        {
            try//SELECT TOP 1 * FROM Table ORDER BY ID DESC
            {

                SqlCommand cmd1 = new SqlCommand("select TOP (1) s_time , f_time  from[" + Form2._TABLE + "] where Id = " + LId + " ORDER BY ID DESC", sqlconS);//  
               
                if (sqlconS.State == ConnectionState.Closed) { sqlconS.Open(); }//open connection
                
                SqlDataReader reader;
                
                reader = cmd1.ExecuteReader();
                
                while (reader.Read())
                {
                    
                    LSWT.Text = reader[0].ToString();
                    LFWT.Text = reader[1].ToString();
                    
                }
                if (sqlconS.State == ConnectionState.Open) { sqlconS.Close(); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        
        void load_data()
        {
            try
            {
                SqlCommand cmd2 = new SqlCommand("select Id,car_no,driver_name,client_name,item_type,gov,move_type, f_w, s_time , f_time ,car_no2,perm_no from["+Form2._TABLE+"] where car_no = " + Form2._CAR_NO + "and s_w =0", sqlconS);//  

                if (sqlconS.State == ConnectionState.Closed) { sqlconS.Open(); }//open connection
                SqlDataReader reader;
                reader = cmd2.ExecuteReader();
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
                if (sqlconS.State == ConnectionState.Open) { sqlconS.Close(); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            user.Text = Form1.users;
            LWer.Text = Form1.users;
            load_data();
            try
            {
                //Open Port
                if (!serialPort1.IsOpen) serialPort1.Open();
            }
            catch (Exception ) { LScreen.Text = "";}    
        }
       
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(MemoryImage, 20, 25, 800, 450);
        }

        private void dataRecieve(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (Properties.Settings.Default.stopString == "1")
            {
                try
                {
                    string data = serialPort1.ReadTo("L");
                    data = Regex.Match(data, @"\d+").Value;
                    LScreen.Text = "" + int.Parse(data);
                }
                catch (Exception) { LScreen.Text = ""; }
            }
            else
            {
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
            panel1.BackColor = Color.DarkRed;
        }

        private void LFW_Click(object sender, EventArgs e)
        {
            
        }

        private void LSW_Click(object sender, EventArgs e)
        {
                LSW.Text = LScreen.Text;
                LPure.Text = "" + Math.Abs(int.Parse(LSW.Text) - int.Parse(LFW.Text));
                   
            try
                {
                    SqlCommand insertUpdate = new SqlCommand(
                    "insert into [Table] (user_id,car_no,driver_name,client_name,item_type,gov,move_type, f_w,s_w,pure,f_time,s_time,car_no2,perm_no) "
                        + "VALUES(N'"
                               + LWer +
                        "',N'" + LCarNo.Text +
                        "',N'" + LDriver.Text +
                        "',N'" + LClient.Text +
                        "',N'" + LItem.Text +
                        "',N'" + LGov.Text +
                        "',N'" + LMoveType.Text +
                        "',N'" + LFW.Text +
                        "',N'" + LSW.Text +
                        "',N'" + LPure.Text +
                        "',N'" + LFWT.Text +
                        "',CURRENT_TIMESTAMP" + 
                        ",N'" + LCarNo2.Text +
                        "',N'" + LPermNo.Text +
                        "')", sqlcon);//  
                    if (sqlcon.State == ConnectionState.Closed)sqlcon.Open();//open connection
                        insertUpdate.ExecuteNonQuery();
                    if (sqlcon.State == ConnectionState.Open)sqlcon.Close();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
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

                    delete.ExecuteNonQuery();///////count user 

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
                    new Form2().Show();
                    this.Close();
                }
                catch (Exception) { };
            }
        }

        private void button3_Click(object sender, EventArgs e)//back
        {
            if (LFW.Text != "")
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
                //catch (ArgumentException) { LScreen.Text = ""; }
                c = true;
                new Form2().Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("من فضلك اكمل البيانات");
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
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

        private void text_change(object sender, EventArgs e)
        {
            //update_data();
        }

        private void leave(object sender, EventArgs e)
        {
            //update_data();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        
    }
}
