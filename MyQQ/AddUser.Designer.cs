namespace MyQQ
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn注册 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbx星座 = new System.Windows.Forms.ComboBox();
            this.cbx区 = new System.Windows.Forms.ComboBox();
            this.cbx市 = new System.Windows.Forms.ComboBox();
            this.cbx省 = new System.Windows.Forms.ComboBox();
            this.rd女 = new System.Windows.Forms.RadioButton();
            this.rd男 = new System.Windows.Forms.RadioButton();
            this.dt生日 = new System.Windows.Forms.DateTimePicker();
            this.txt详细地址 = new System.Windows.Forms.TextBox();
            this.txt手机号 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt姓名 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt密码2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt密码1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt昵称 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.qQsqlDataSet2 = new MyQQ.QQsqlDataSet2();
            this.省BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.省TableAdapter = new MyQQ.QQsqlDataSet2TableAdapters.省TableAdapter();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qQsqlDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.省BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 826);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Coral;
            this.panel2.Controls.Add(this.btn注册);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(151, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 826);
            this.panel2.TabIndex = 1;
            // 
            // btn注册
            // 
            this.btn注册.Location = new System.Drawing.Point(62, 728);
            this.btn注册.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn注册.Name = "btn注册";
            this.btn注册.Size = new System.Drawing.Size(284, 46);
            this.btn注册.TabIndex = 2;
            this.btn注册.Text = "提交注册";
            this.btn注册.UseVisualStyleBackColor = true;
            this.btn注册.Click += new System.EventHandler(this.btn注册_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbx星座);
            this.groupBox2.Controls.Add(this.cbx区);
            this.groupBox2.Controls.Add(this.cbx市);
            this.groupBox2.Controls.Add(this.cbx省);
            this.groupBox2.Controls.Add(this.rd女);
            this.groupBox2.Controls.Add(this.rd男);
            this.groupBox2.Controls.Add(this.dt生日);
            this.groupBox2.Controls.Add(this.txt详细地址);
            this.groupBox2.Controls.Add(this.txt手机号);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt姓名);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(26, 209);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(366, 493);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "基本信息";
            // 
            // cbx星座
            // 
            this.cbx星座.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx星座.FormattingEnabled = true;
            this.cbx星座.Items.AddRange(new object[] {
            "双鱼座",
            "金牛座",
            "处女座",
            "天蝎座",
            "射手座",
            "天秤座"});
            this.cbx星座.Location = new System.Drawing.Point(102, 349);
            this.cbx星座.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbx星座.Name = "cbx星座";
            this.cbx星座.Size = new System.Drawing.Size(217, 26);
            this.cbx星座.TabIndex = 4;
            // 
            // cbx区
            // 
            this.cbx区.DisplayMember = "区名称";
            this.cbx区.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx区.FormattingEnabled = true;
            this.cbx区.Location = new System.Drawing.Point(102, 304);
            this.cbx区.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbx区.Name = "cbx区";
            this.cbx区.Size = new System.Drawing.Size(217, 26);
            this.cbx区.TabIndex = 4;
            this.cbx区.ValueMember = "区_编号";
            // 
            // cbx市
            // 
            this.cbx市.DisplayMember = "市名称";
            this.cbx市.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx市.FormattingEnabled = true;
            this.cbx市.Location = new System.Drawing.Point(102, 257);
            this.cbx市.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbx市.Name = "cbx市";
            this.cbx市.Size = new System.Drawing.Size(217, 26);
            this.cbx市.TabIndex = 4;
            this.cbx市.ValueMember = "市_编号";
            this.cbx市.SelectedIndexChanged += new System.EventHandler(this.cbx市_SelectedIndexChanged);
            // 
            // cbx省
            // 
            this.cbx省.DataSource = this.省BindingSource;
            this.cbx省.DisplayMember = "省名称";
            this.cbx省.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx省.FormattingEnabled = true;
            this.cbx省.Location = new System.Drawing.Point(102, 214);
            this.cbx省.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbx省.Name = "cbx省";
            this.cbx省.Size = new System.Drawing.Size(217, 26);
            this.cbx省.TabIndex = 4;
            this.cbx省.ValueMember = "省_编号";
            this.cbx省.SelectedIndexChanged += new System.EventHandler(this.cbx省_SelectedIndexChanged);
            // 
            // rd女
            // 
            this.rd女.AutoSize = true;
            this.rd女.Location = new System.Drawing.Point(232, 70);
            this.rd女.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rd女.Name = "rd女";
            this.rd女.Size = new System.Drawing.Size(51, 22);
            this.rd女.TabIndex = 3;
            this.rd女.Text = "女";
            this.rd女.UseVisualStyleBackColor = true;
            // 
            // rd男
            // 
            this.rd男.AutoSize = true;
            this.rd男.Checked = true;
            this.rd男.Location = new System.Drawing.Point(130, 72);
            this.rd男.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rd男.Name = "rd男";
            this.rd男.Size = new System.Drawing.Size(51, 22);
            this.rd男.TabIndex = 3;
            this.rd男.TabStop = true;
            this.rd男.Text = "男";
            this.rd男.UseVisualStyleBackColor = true;
            // 
            // dt生日
            // 
            this.dt生日.Location = new System.Drawing.Point(99, 107);
            this.dt生日.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dt生日.Name = "dt生日";
            this.dt生日.Size = new System.Drawing.Size(220, 28);
            this.dt生日.TabIndex = 2;
            // 
            // txt详细地址
            // 
            this.txt详细地址.Location = new System.Drawing.Point(102, 391);
            this.txt详细地址.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt详细地址.Multiline = true;
            this.txt详细地址.Name = "txt详细地址";
            this.txt详细地址.Size = new System.Drawing.Size(217, 81);
            this.txt详细地址.TabIndex = 1;
            // 
            // txt手机号
            // 
            this.txt手机号.Location = new System.Drawing.Point(102, 164);
            this.txt手机号.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt手机号.Name = "txt手机号";
            this.txt手机号.Size = new System.Drawing.Size(217, 28);
            this.txt手机号.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 395);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "地址：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 349);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "星座：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 304);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "区：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "市：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "省：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "手机号：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "生日：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "性别：";
            // 
            // txt姓名
            // 
            this.txt姓名.Location = new System.Drawing.Point(102, 29);
            this.txt姓名.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt姓名.Name = "txt姓名";
            this.txt姓名.Size = new System.Drawing.Size(217, 28);
            this.txt姓名.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "姓名：";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Coral;
            this.groupBox1.Controls.Add(this.txt密码2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt密码1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt昵称);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(26, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(366, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "账号信息";
            // 
            // txt密码2
            // 
            this.txt密码2.Location = new System.Drawing.Point(102, 126);
            this.txt密码2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt密码2.Name = "txt密码2";
            this.txt密码2.Size = new System.Drawing.Size(217, 28);
            this.txt密码2.TabIndex = 1;
            this.txt密码2.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "确认密码：";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // txt密码1
            // 
            this.txt密码1.Location = new System.Drawing.Point(102, 78);
            this.txt密码1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt密码1.Name = "txt密码1";
            this.txt密码1.Size = new System.Drawing.Size(217, 28);
            this.txt密码1.TabIndex = 1;
            this.txt密码1.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "密码：";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // txt昵称
            // 
            this.txt昵称.Location = new System.Drawing.Point(102, 30);
            this.txt昵称.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt昵称.Name = "txt昵称";
            this.txt昵称.Size = new System.Drawing.Size(217, 28);
            this.txt昵称.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "昵称：";
            // 
            // qQsqlDataSet2
            // 
            this.qQsqlDataSet2.DataSetName = "QQsqlDataSet2";
            this.qQsqlDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 省BindingSource
            // 
            this.省BindingSource.DataMember = "省";
            this.省BindingSource.DataSource = this.qQsqlDataSet2;
            // 
            // 省TableAdapter
            // 
            this.省TableAdapter.ClearBeforeFill = true;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 826);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.Load += new System.EventHandler(this.AddUser_Load_1);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qQsqlDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.省BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn注册;
        private System.Windows.Forms.ComboBox cbx星座;
        private System.Windows.Forms.ComboBox cbx区;
        private System.Windows.Forms.ComboBox cbx市;
        private System.Windows.Forms.ComboBox cbx省;
        private System.Windows.Forms.RadioButton rd女;
        private System.Windows.Forms.RadioButton rd男;
        private System.Windows.Forms.DateTimePicker dt生日;
        private System.Windows.Forms.TextBox txt详细地址;
        private System.Windows.Forms.TextBox txt手机号;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt姓名;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt密码2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt密码1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt昵称;
        private QQsqlDataSet2 qQsqlDataSet2;
        private System.Windows.Forms.BindingSource 省BindingSource;
        private QQsqlDataSet2TableAdapters.省TableAdapter 省TableAdapter;
    }
}