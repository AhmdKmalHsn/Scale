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
using System.Threading;
using System.Net.NetworkInformation;
using System.Net;

namespace scale
{
    public partial class Form2 : Form
    {  
        //string sql1 = "delete from ["+Properties.Settings.Default.serverTable+"]";
        string sql2 = @"select user_id,
car_no,
driver_name,
client_name,
item_type,
gov,
move_type,
f_w,
s_w,
pure,
 f_time ,
 s_time,
car_no2,
perm_no,
Id 
from[Table] ";
        SqlConnection sqlcon1 = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + Path.GetFullPath(@"Database.mdf") + ";Integrated Security=True;User Instance=True");       
        SqlConnection sqlcon = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + Path.GetFullPath("Database.mdf") + ";Integrated Security=True;User Instance=True");
        SqlConnection sqlconS = new SqlConnection(@"Data Source=dc\sqlexpress2014;Initial Catalog=Database;Persist Security Info=True;User ID=mizan;Password=mizan@2020");
        //SqlConnection sqlconS1 = new SqlConnection(@"Data Source=dc\sqlexpress2014;Initial Catalog=Database;Persist Security Info=True;User ID=mizan;Password=mizan@2020");
        bool error = false;
        public static int _W = 0;
        public static string _CAR_NO = "";
        public static string _TABLE = "";
        bool c=false;
       
        public Form2()
        {
            InitializeComponent();
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {

            if (Form1.users != "admin"&&Form1.users != "Admin") { button5.Visible = false; }
            LUser.Text = Form1.users;
            textBox1.Focus();
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.RunWorkerAsync();
        }

        /* void load_data()
        //upload data to server 
         {
             SqlCommand Dcmd = new SqlCommand(sql1, sqlconS);
             //delete old
             try 
             {
               if (sqlconS.State == ConnectionState.Closed) { sqlconS.Open(); }//open connection
                  Dcmd.ExecuteNonQuery();
               if (sqlconS.State == ConnectionState.Open) { sqlconS.Close(); }//close connection
             }
             catch (Exception) { error = true; }
             try
             {
                 SqlCommand cmd = new SqlCommand(sql2, sqlcon);//  
                 if (sqlcon.State == ConnectionState.Closed) { sqlcon.Open(); }//open connection
                 SqlDataReader reader;
                 reader = cmd.ExecuteReader();
                 while (reader.Read())
                 {      
                         if (sqlconS.State == ConnectionState.Closed) { sqlconS.Open(); }
                         SqlCommand Ins = new SqlCommand(
                         "insert into [" + Properties.Settings.Default.serverTable + "] (Id,user_id,car_no,driver_name,client_name,item_type,gov,move_type, f_w,s_w,pure,f_time,s_time,car_no2,perm_no) "
                         + "VALUES(N'"
                                + reader[14].ToString() +
                         "',N'" + reader[0].ToString() +
                         "',N'" + reader[1].ToString() +
                         "',N'" + reader[2].ToString() +
                         "',N'" + reader[3].ToString() +
                         "',N'" + reader[4].ToString() +
                         "',N'" + reader[5].ToString() +
                         "',N'" + reader[6].ToString() +
                         "',N'" + reader[7].ToString() +
                         "',N'" + reader[8].ToString().TrimEnd() +
                         "',N'" + reader[9].ToString().TrimEnd() +//sw
                         "',N'" + reader[10].ToString() +//pure
                         "',N'" + reader[11].ToString().TrimEnd() +//
                         "',N'" + reader[12].ToString() +//s_time
                         "',N'" + reader[13].ToString() +
                         "')", sqlconS);
                         Ins.ExecuteNonQuery();
                         if (sqlconS.State == ConnectionState.Open) { sqlconS.Close(); }
                 }
                 reader.Close();
                 if (sqlcon.State == ConnectionState.Open) { sqlcon.Close(); }
             }
             catch (Exception) { sqlconS.Close(); sqlcon.Close(); error = true; }
         }
         */

        void insertUpdated()
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql2, sqlcon);//  
                if (sqlcon.State == ConnectionState.Closed) { sqlcon.Open(); }//open connection
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //begin reader
                    SqlCommand sql = new SqlCommand();
                    sql.CommandText =
                        "if(SELECT count (*) FROM " + Properties.Settings.Default.serverTable + " WHERE Id=@V)=0 "+
                         
"Insert into [" + Properties.Settings.Default.serverTable + "]("+
@"Id,
user_id,
car_no,
driver_name,
client_name,
item_type,
gov,
move_type,
f_w,
s_w,
pure,
f_time,
s_time,
car_no2,
perm_no
)
VALUES(
@V,
@V1,
@V2,
@V3,
@V4,
@V5,
@V6,
@V7,
@V8,
@V9,
@V10,
@V11,
@V12,
@V13,
@V14
)
ELSE UPDATE [" + Properties.Settings.Default.serverTable + @"] set
Id=@V,
user_id=@V1,
car_no=@V2,
driver_name=@V3,
client_name=@V4,
item_type=@V5,
gov=@V6,
move_type=@V7,
f_w=@V8,
s_w=@V9,
pure=@V10,
f_time=@V11,
s_time=@V12,
car_no2=@V13,
perm_no=@V14 WHERE  pure=0";

                    sql.Parameters.AddWithValue("@V", reader[14].ToString());
                    sql.Parameters.AddWithValue("@V1", reader[0].ToString());
                    sql.Parameters.AddWithValue("@V2", reader[1].ToString());
                    sql.Parameters.AddWithValue("@V3", reader[2].ToString());
                    sql.Parameters.AddWithValue("@V4", reader[3].ToString());
                    sql.Parameters.AddWithValue("@V5", reader[4].ToString());
                    sql.Parameters.AddWithValue("@V6", reader[5].ToString());
                    sql.Parameters.AddWithValue("@V7", reader[6].ToString());
                    sql.Parameters.AddWithValue("@V8", reader[7].ToString());
                    sql.Parameters.AddWithValue("@V9", reader[8].ToString());
                    sql.Parameters.AddWithValue("@V10", reader[9].ToString());
                    sql.Parameters.AddWithValue("@V11", reader[10].ToString());
                    sql.Parameters.AddWithValue("@V12", reader[11].ToString());
                    sql.Parameters.AddWithValue("@V13", reader[12].ToString());
                    sql.Parameters.AddWithValue("@V14", reader[13].ToString());

                    using (SqlConnection con = new SqlConnection(@"Data Source=dc\sqlexpress2014;Initial Catalog=Database;Persist Security Info=True;User ID=mizan;Password=mizan@2020"))
                    {
                        sql.Connection = con;
                        con.Open();

                        try
                        {
                            sql.ExecuteNonQuery();
                            //MessageBox.Show("success!");
                            Console.WriteLine("success!");
                        }
                        catch (Exception ex)
                        {

                            //MessageBox.Show(ex.Message);
                            Console.WriteLine(ex.Message);
                        }
                    }
                    //end of reader
                }
                reader.Close();
                if (sqlcon.State == ConnectionState.Open) { sqlcon.Close(); }
            }
            catch (Exception) { sqlconS.Close(); sqlcon.Close(); error = true; }
        }


        public bool isConnected(string IP) 
        {
            Ping p = new Ping();
            PingReply pr = p.Send(IP,1000);
            if (pr.Status == IPStatus.Success) return true;
            else return false;
        }
        
        void Car()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select count(car_no) from[Table] where car_no = " + textBox1.Text + "and f_w is not NULL and s_w is NULL; ", sqlcon1);//  
                if (sqlcon1.State == ConnectionState.Closed) { sqlcon1.Open(); }//open connection
                int result = Convert.ToInt32(cmd.ExecuteScalar());///////count user 
                if (sqlcon1.State == ConnectionState.Open) { sqlcon1.Close(); }
                _CAR_NO = textBox1.Text;
                _W = result;
                if (_W == 0)
                {
                    SqlCommand cmdC = new SqlCommand("insert into [Table](user_id) values('" + Form1.users + "')", sqlcon1);//  
                    if (sqlcon1.State == ConnectionState.Closed) { sqlcon1.Open(); }//open connection
                        cmd.ExecuteScalar();//
                    if (sqlcon1.State == ConnectionState.Open) { sqlcon1.Close(); }
                }
                c = true;
                new Form3().Show();
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        
        void CarN(int no)
        {
             
            switch (no) {
                case 1: _TABLE = "Table1"; break;
                case 2: _TABLE = "Table2"; break;
                case 3: _TABLE = "Table3"; break;
            }
            Console.WriteLine("_TABLE=" + _TABLE);
            try
            {
                SqlCommand cmd = new SqlCommand("select count(*) from ["+_TABLE+"] where car_no = " + textBox2.Text + "and s_w=0", sqlconS);//  
                if (sqlconS.State == ConnectionState.Closed) { sqlconS.Open(); }//open connection
                int result = Convert.ToInt32(cmd.ExecuteScalar());///////count user 
                if (sqlconS.State == ConnectionState.Open) { sqlconS.Close(); }
                _CAR_NO = textBox2.Text;
                _W = result;
                if (_W == 0)
                {
                    MessageBox.Show("لم توجد وزنة لهذه السيارة");
                }
                else
                {
                    c = true;
                    new Form33().Show();
                    this.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            Console.WriteLine("_CAR_NO=" + _CAR_NO);
            Console.WriteLine("_W=" + _W);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c = true;
            new Form4().Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            c = true;
            new Form5().Show();
            this.Close();
        }

        private void keypress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                Car();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.remember = false;
            Properties.Settings.Default.Save();
            c = true;
            new Form1().Show();
            this.Close();
        }

        private void close(object sender, FormClosedEventArgs e)
        {
            if(!c)Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //load_data();
            insertUpdated();
        }

        private void done(object sender, RunWorkerCompletedEventArgs e)
        {
            if(error){
                toolStripStatusLabel1.Text = "Error";
            }else{
                toolStripStatusLabel1.Text = "Updated";
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            c = true;
            this.Close();
            (new Form6()).Show();
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
        /* while(true){
          try
            {
                if (isConnected("192.168.1.199"))
                {
                    //conBtn.ForeColor = Color.Green;
                    conBtn.BackColor = Color.Green;
                    conBtn.Text = "Connected";
                }
                else
                {
                    //conBtn.ForeColor = Color.Red;
                    conBtn.BackColor = Color.Red;
                    conBtn.Text = "Disconnected";
                }
            }catch(Exception){}
         }*/
       }

        private void button6_Click(object sender, EventArgs e)
        {
            comboBox1.DroppedDown = true;
        }

        private void keyNet(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0: CarN(1); break;
                case 1: CarN(2); break;
                case 2: CarN(3); break;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
