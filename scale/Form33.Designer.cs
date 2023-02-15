namespace scale
{
    partial class Form33
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form33));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LItem = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LCarNo2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LGov = new System.Windows.Forms.ComboBox();
            this.LMoveType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LPermNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LCarNo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LId = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LWer = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LSWT = new System.Windows.Forms.Label();
            this.LDriver = new System.Windows.Forms.ComboBox();
            this.LFWT = new System.Windows.Forms.Label();
            this.LClient = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.LFW = new System.Windows.Forms.Label();
            this.LPure = new System.Windows.Forms.Label();
            this.LSW = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LScreen = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.databaseDataSet = new scale.DatabaseDataSet();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.LItem);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.LCarNo2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.LGov);
            this.panel1.Controls.Add(this.LMoveType);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.LPermNo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.LCarNo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.LId);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.LWer);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.LSWT);
            this.panel1.Controls.Add(this.LDriver);
            this.panel1.Controls.Add(this.LFWT);
            this.panel1.Controls.Add(this.LClient);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.LFW);
            this.panel1.Controls.Add(this.LPure);
            this.panel1.Controls.Add(this.LSW);
            this.panel1.Location = new System.Drawing.Point(11, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 479);
            this.panel1.TabIndex = 45;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // LItem
            // 
            this.LItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.LItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.LItem.BackColor = System.Drawing.Color.White;
            this.LItem.DisplayMember = "item_type";
            this.LItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LItem.FormattingEnabled = true;
            this.LItem.Location = new System.Drawing.Point(272, 298);
            this.LItem.Name = "LItem";
            this.LItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LItem.Size = new System.Drawing.Size(487, 37);
            this.LItem.TabIndex = 40;
            this.LItem.ValueMember = "item_type";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = global::scale.Properties.Resources.logo1;
            this.pictureBox2.Location = new System.Drawing.Point(27, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(165, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // LCarNo2
            // 
            this.LCarNo2.BackColor = System.Drawing.Color.White;
            this.LCarNo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LCarNo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCarNo2.Location = new System.Drawing.Point(85, 168);
            this.LCarNo2.Name = "LCarNo2";
            this.LCarNo2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LCarNo2.Size = new System.Drawing.Size(115, 35);
            this.LCarNo2.TabIndex = 27;
            this.LCarNo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LCarNo2.TextChanged += new System.EventHandler(this.text_change);
            this.LCarNo2.Leave += new System.EventHandler(this.leave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 3);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(554, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "الشركة العالمية لسحب الاسلاك";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(765, 210);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(188, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "اسم السائق";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(764, 167);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(189, 40);
            this.label4.TabIndex = 3;
            this.label4.Text = "رقم السيارة";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(293, 55);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(554, 46);
            this.label12.TabIndex = 37;
            this.label12.Text = "نصار جروب الخط الساخن 19237";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(765, 254);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(188, 40);
            this.label5.TabIndex = 4;
            this.label5.Text = "اسم العميل";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LGov
            // 
            this.LGov.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.LGov.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.LGov.BackColor = System.Drawing.Color.White;
            this.LGov.DisplayMember = "gov";
            this.LGov.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LGov.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LGov.FormattingEnabled = true;
            this.LGov.Location = new System.Drawing.Point(343, 167);
            this.LGov.Name = "LGov";
            this.LGov.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LGov.Size = new System.Drawing.Size(133, 37);
            this.LGov.TabIndex = 36;
            this.LGov.ValueMember = "gov";
            this.LGov.TextChanged += new System.EventHandler(this.text_change);
            this.LGov.Leave += new System.EventHandler(this.leave);
            // 
            // LMoveType
            // 
            this.LMoveType.BackColor = System.Drawing.Color.White;
            this.LMoveType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LMoveType.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMoveType.FormattingEnabled = true;
            this.LMoveType.Items.AddRange(new object[] {
            "صادر",
            "وارد",
            "مرتجع"});
            this.LMoveType.Location = new System.Drawing.Point(85, 298);
            this.LMoveType.Name = "LMoveType";
            this.LMoveType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LMoveType.Size = new System.Drawing.Size(181, 37);
            this.LMoveType.TabIndex = 5;
            this.LMoveType.TextChanged += new System.EventHandler(this.text_change);
            this.LMoveType.Leave += new System.EventHandler(this.leave);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(463, 125);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(131, 40);
            this.label2.TabIndex = 35;
            this.label2.Text = "رقم الاذن";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(765, 298);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(188, 40);
            this.label8.TabIndex = 7;
            this.label8.Text = "نوع البضاعة";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LPermNo
            // 
            this.LPermNo.BackColor = System.Drawing.Color.White;
            this.LPermNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LPermNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPermNo.Location = new System.Drawing.Point(278, 128);
            this.LPermNo.Name = "LPermNo";
            this.LPermNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LPermNo.Size = new System.Drawing.Size(179, 35);
            this.LPermNo.TabIndex = 34;
            this.LPermNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LPermNo.TextChanged += new System.EventHandler(this.text_change);
            this.LPermNo.Leave += new System.EventHandler(this.leave);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(763, 125);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(189, 40);
            this.label7.TabIndex = 8;
            this.label7.Text = "المسلسل";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LCarNo
            // 
            this.LCarNo.BackColor = System.Drawing.Color.White;
            this.LCarNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LCarNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCarNo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LCarNo.Location = new System.Drawing.Point(598, 167);
            this.LCarNo.Name = "LCarNo";
            this.LCarNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LCarNo.Size = new System.Drawing.Size(160, 40);
            this.LCarNo.TabIndex = 33;
            this.LCarNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(765, 342);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(188, 40);
            this.label6.TabIndex = 9;
            this.label6.Text = "الوزنة الاولى";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LId
            // 
            this.LId.BackColor = System.Drawing.Color.White;
            this.LId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LId.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LId.Location = new System.Drawing.Point(598, 125);
            this.LId.Name = "LId";
            this.LId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LId.Size = new System.Drawing.Size(160, 40);
            this.LId.TabIndex = 32;
            this.LId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(764, 385);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(188, 40);
            this.label10.TabIndex = 10;
            this.label10.Text = "الوزنة الثانية";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.White;
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(328, 429);
            this.label21.Name = "label21";
            this.label21.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label21.Size = new System.Drawing.Size(104, 40);
            this.label21.TabIndex = 31;
            this.label21.Text = "الوزان ";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(764, 429);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(188, 40);
            this.label9.TabIndex = 11;
            this.label9.Text = "الوزن الصافي";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LWer
            // 
            this.LWer.BackColor = System.Drawing.Color.White;
            this.LWer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LWer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LWer.Location = new System.Drawing.Point(85, 429);
            this.LWer.Name = "LWer";
            this.LWer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LWer.Size = new System.Drawing.Size(237, 40);
            this.LWer.TabIndex = 30;
            this.LWer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(206, 167);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(131, 40);
            this.label11.TabIndex = 12;
            this.label11.Text = "رقم المقطورة";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LSWT
            // 
            this.LSWT.BackColor = System.Drawing.Color.White;
            this.LSWT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LSWT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSWT.Location = new System.Drawing.Point(85, 385);
            this.LSWT.Name = "LSWT";
            this.LSWT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LSWT.Size = new System.Drawing.Size(507, 40);
            this.LSWT.TabIndex = 29;
            this.LSWT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LDriver
            // 
            this.LDriver.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.LDriver.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.LDriver.BackColor = System.Drawing.Color.White;
            this.LDriver.DisplayMember = "driver_name";
            this.LDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDriver.FormattingEnabled = true;
            this.LDriver.Location = new System.Drawing.Point(85, 210);
            this.LDriver.Name = "LDriver";
            this.LDriver.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LDriver.Size = new System.Drawing.Size(674, 37);
            this.LDriver.TabIndex = 16;
            this.LDriver.ValueMember = "driver_name";
            this.LDriver.TextChanged += new System.EventHandler(this.text_change);
            this.LDriver.Leave += new System.EventHandler(this.leave);
            // 
            // LFWT
            // 
            this.LFWT.BackColor = System.Drawing.Color.White;
            this.LFWT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LFWT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFWT.Location = new System.Drawing.Point(85, 342);
            this.LFWT.Name = "LFWT";
            this.LFWT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LFWT.Size = new System.Drawing.Size(506, 40);
            this.LFWT.TabIndex = 28;
            this.LFWT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LClient
            // 
            this.LClient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.LClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.LClient.BackColor = System.Drawing.Color.White;
            this.LClient.DisplayMember = "client_name";
            this.LClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LClient.FormattingEnabled = true;
            this.LClient.Location = new System.Drawing.Point(85, 254);
            this.LClient.Name = "LClient";
            this.LClient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LClient.Size = new System.Drawing.Size(674, 37);
            this.LClient.TabIndex = 17;
            this.LClient.ValueMember = "client_name";
            this.LClient.TextChanged += new System.EventHandler(this.text_change);
            this.LClient.Leave += new System.EventHandler(this.leave);
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(482, 167);
            this.label17.Name = "label17";
            this.label17.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label17.Size = new System.Drawing.Size(112, 40);
            this.label17.TabIndex = 26;
            this.label17.Text = "المحافظة";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LFW
            // 
            this.LFW.BackColor = System.Drawing.Color.White;
            this.LFW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LFW.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFW.Location = new System.Drawing.Point(598, 342);
            this.LFW.Name = "LFW";
            this.LFW.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LFW.Size = new System.Drawing.Size(160, 40);
            this.LFW.TabIndex = 21;
            this.LFW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LFW.Click += new System.EventHandler(this.LFW_Click);
            // 
            // LPure
            // 
            this.LPure.BackColor = System.Drawing.Color.White;
            this.LPure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LPure.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPure.Location = new System.Drawing.Point(598, 429);
            this.LPure.Name = "LPure";
            this.LPure.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LPure.Size = new System.Drawing.Size(160, 40);
            this.LPure.TabIndex = 25;
            this.LPure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LSW
            // 
            this.LSW.BackColor = System.Drawing.Color.White;
            this.LSW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LSW.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSW.Location = new System.Drawing.Point(598, 385);
            this.LSW.Name = "LSW";
            this.LSW.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LSW.Size = new System.Drawing.Size(161, 40);
            this.LSW.TabIndex = 23;
            this.LSW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LSW.Click += new System.EventHandler(this.LSW_Click);
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.Color.Transparent;
            this.user.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(841, -38);
            this.user.Name = "user";
            this.user.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.user.Size = new System.Drawing.Size(116, 29);
            this.user.TabIndex = 44;
            this.user.Text = "المسلسل";
            this.user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(855, -94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // LScreen
            // 
            this.LScreen.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 54.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LScreen.Location = new System.Drawing.Point(12, 9);
            this.LScreen.Name = "LScreen";
            this.LScreen.Size = new System.Drawing.Size(329, 113);
            this.LScreen.TabIndex = 42;
            this.LScreen.Text = "120000";
            this.LScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(112, 610);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 35);
            this.button3.TabIndex = 48;
            this.button3.Text = "خروج";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(741, 610);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 46;
            this.button1.Text = "طباعة";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 2400;
            this.serialPort1.ReadTimeout = 500;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.dataRecieve);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(474, 610);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 35);
            this.button4.TabIndex = 49;
            this.button4.Text = "تراجع";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form33
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 657);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.LScreen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.user);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form33";
            this.Text = "شاشة  الوزن";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.closing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox LCarNo2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox LGov;
        private System.Windows.Forms.ComboBox LMoveType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox LPermNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LCarNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LWer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LSWT;
        private System.Windows.Forms.ComboBox LDriver;
        private System.Windows.Forms.Label LFWT;
        private System.Windows.Forms.ComboBox LClient;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label LFW;
        private System.Windows.Forms.Label LPure;
        private System.Windows.Forms.Label LSW;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LScreen;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ComboBox LItem;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.Button button4;
    }
}