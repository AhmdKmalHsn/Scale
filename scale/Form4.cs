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
    public partial class Form4 : Form
    {
        bool c = false;
        public static string _id = "";
        SqlConnection sqlcon = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + Path.GetFullPath(@"Database.mdf") + ";Integrated Security=True;User Instance=True");
        SqlConnection server = new SqlConnection(@"Data Source=dc\sqlexpress2014;Initial Catalog=Database;Persist Security Info=True;User ID=mizan;Password=mizan@2020");
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet4.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter1.Fill(this.databaseDataSet4.Table);
            // TODO: This line of code loads data into the 'databaseDataSet3.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.databaseDataSet3.Table);
            // TODO: This line of code loads data into the 'databaseDataSet2.Table' table. You can move, or remove it, as needed.
          //  this.tableTableAdapter.Fill(this.databaseDataSet2.Table);
            /*DataTable dtPosts = new DataTable();
            DataTable dtPosts2 = new DataTable();
            using (SqlConnection conn = new SqlConnection(scale.Properties.Settings.Default.DatabaseConnectionString))
            {
                conn.Open();
                using (SqlDataAdapter adapt = new SqlDataAdapter(@"select DISTINCT RTRIM(LTRIM(client_name))client_name from[Table]", conn))
                {
                    adapt.SelectCommand.CommandTimeout = 120;
                    adapt.Fill(dtPosts);
                }
                using (SqlDataAdapter adapt2 = new SqlDataAdapter(@"select DISTINCT RTRIM(LTRIM(item_type))item_type from[Table]", conn))
                {
                    adapt2.SelectCommand.CommandTimeout = 120;
                    adapt2.Fill(dtPosts2);
                }
            }

            //use LINQ method syntax to pull the Title field from a DT into a string array...
            string[] postSource = dtPosts
                                .AsEnumerable()
                                .Select<System.Data.DataRow, String>(x => x.Field<String>("client_name"))
                                .ToArray();
            string[] postSource2 = dtPosts2
                                .AsEnumerable()
                                .Select<System.Data.DataRow, String>(x => x.Field<String>("item_type"))
                                .ToArray();
            var source = new AutoCompleteStringCollection();
            source.AddRange(postSource);
            textBox1.AutoCompleteCustomSource = source;
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            var source2 = new AutoCompleteStringCollection();
            source2.AddRange(postSource2);
            textBox2.AutoCompleteCustomSource = source2;
            textBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox2.AutoCompleteSource = AutoCompleteSource.CustomSource;*/
        }

        string setString(string table,bool where) {
            string w="";
            if (where == true) w = " where cast(F_time as date) >= @from and cast(F_time as date)<= @To ";//" where cast(s_time as date) >= @From and cast(s_time as date) <= @To";
            string q11 = " and client_name lIKE N'%" + textBox1.Text + "%'";
            string q12 = " and car_no=N'" + textBox1.Text + "'";
            string q21 = " and item_type=N'" + textBox2.Text + "'";
            string q31 = " and move_type=N'صادر'";
            string q32 = " and move_type=N'وارد'";
            string q33 = " and move_type=N'مرتجع'";

            if (query1.Checked) { }
            if (query2.Checked) { w += q11; }
            if (query3.Checked) { w += q12; }
            if (item1.Checked) { }
            if (item2.Checked) { w += q21; }
            if (type1.Checked) { }
            if (type2.Checked) { w += q31; }
            if (type3.Checked) { w += q32; }
            if (type4.Checked) { w += q33; }

            
            string q01 = "select " +
                 "ltrim(RTRIM(Id)) as 'المسلسل'" +
                 ",LTRIM(RTRIM(car_no)) as 'رقم السيارة'" +
                 //",LTRIM(RTRIM(car_no2) as 'رقم المقطورة'" +
                 ",LTRIM(RTRIM(driver_name)) as 'اسم السائق'" +
                 ",LTRIM(RTRIM(client_name)) as 'اسم العميل'" +
                 //",LTRIM(RTRIM(gov) as 'المحافظة'" +
                 ",LTRIM(RTRIM(item_type)) as 'نوع البضاعة'" +
                 ",LTRIM(RTRIM(move_type)) as 'نوع الحركة'" +
                 ",LTRIM(RTRIM(F_W)) as 'الوزنة الاولي'" +
                 ",LTRIM(RTRIM(S_W)) as 'الوزنة الثانية'" +
                 ",LTRIM(RTRIM(ABS(S_W-F_W))) as 'الصافي'" +
                 //",LTRIM(RTRIM(f_time) as 'وقت الوزنة الاولي'" +CAST(NULLIF(@Var,'') as DATE)
                 //",isnull(s_time,0) as mm"+
                 ",cast(F_time as date) as 'وقت الوزن'" +
                 ",LTRIM(RTRIM(perm_no)) as 'رقم الاذن'" +
                //",LTRIM(RTRIM(user_id) as 'المستخدم'" +
                " from [" + table + "] "+ w +/*; */
                "Union select '','','','','الاجمالي','','','',sum(ABS(S_W-F_W))pure,'','' from[" + table + "]" + w;
           
            return q01;
        }
        private void button1_Click(object sender, EventArgs e)
        {
          
            SqlDataAdapter adp;
            if (Rlocal.Checked)
            {
                adp = new SqlDataAdapter(setString("table",true), sqlcon);
                adp.SelectCommand.Parameters.AddWithValue("@From", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                adp.SelectCommand.Parameters.AddWithValue("@To", SqlDbType.Date).Value = dateTimePicker2.Value.Date;
                DataTable dt = new DataTable();
                try
                {
                    adp.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception) { }
            }
            else if (Rserver1.Checked)
            {
                //table = "Table1";
                adp = new SqlDataAdapter(setString("Table1",true), server);
                adp.SelectCommand.Parameters.AddWithValue("@From", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                adp.SelectCommand.Parameters.AddWithValue("@To", SqlDbType.Date).Value = dateTimePicker2.Value.Date;
                DataTable dt = new DataTable();
                try
                {
                    adp.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }
            else if (Rserver2.Checked)
            {
                //table = "Table2";
                adp = new SqlDataAdapter(setString("Table2",true), server);
                adp.SelectCommand.Parameters.AddWithValue("@From", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                adp.SelectCommand.Parameters.AddWithValue("@To", SqlDbType.Date).Value = dateTimePicker2.Value.Date;
                DataTable dt = new DataTable();
                try
                {
                    adp.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }
            else if (Rserver3.Checked)
            {
                //table = "Table3";
                adp = new SqlDataAdapter(setString("Table3",true), server);
                adp.SelectCommand.Parameters.AddWithValue("@From", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                adp.SelectCommand.Parameters.AddWithValue("@To", SqlDbType.Date).Value = dateTimePicker2.Value.Date;
                DataTable dt = new DataTable();
                try
                {
                    adp.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }

            
   
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            c = true;
            (new Form5()).Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c = true;
            (new Form2()).Show();
            this.Close();
        }


        private void closed(object sender, FormClosedEventArgs e)
        {
            if (!c) Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DGVPrinter p = new DGVPrinter();
            p.Title = "تقرير العملاء";
            p.PageNumbers = true;
            p.PageNumberInHeader = false;
            p.ColumnWidth = DGVPrinter.ColumnWidthSetting.Porportional;
            p.HeaderCellAlignment = StringAlignment.Near;
            //p.TableAlignment = Center;
            p.PageSettings.Margins = new System.Drawing.Printing.Margins(5, 5, 5, 5);
            p.PageSettings.Landscape = true;
            //p.PrintSettings.
            p.PorportionalColumns=false ;
            p.PrintPreviewDataGridView(dataGridView1);
           
        }
        Bitmap MemoryImage;

        public void GetPrintArea(DataGridView pnl)
        {
            MemoryImage = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(MemoryImage, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }
        private void PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(MemoryImage, 0, 0, 1160, 820);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].Visible = toolStripMenuItem1.Checked;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[1].Visible = toolStripMenuItem2.Checked;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[2].Visible = toolStripMenuItem3.Checked;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[3].Visible = toolStripMenuItem4.Checked;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[4].Visible = toolStripMenuItem5.Checked;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[5].Visible = toolStripMenuItem6.Checked;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[6].Visible = toolStripMenuItem7.Checked;
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[7].Visible = toolStripMenuItem8.Checked;
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[8].Visible = toolStripMenuItem9.Checked;
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[9].Visible = toolStripMenuItem10.Checked;
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[10].Visible = toolStripMenuItem11.Checked;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.tableTableAdapter.FillBy(this.databaseDataSet3.Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
