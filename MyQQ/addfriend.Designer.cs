namespace MyQQ
{
    partial class addfriend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addfriend));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ckzaixian = new System.Windows.Forms.CheckBox();
            this.textkey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guanbi = new System.Windows.Forms.Button();
            this.tianjia = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加好友ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.详细信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.屏蔽ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ckzaixian);
            this.panel1.Controls.Add(this.textkey);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 190);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(781, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 108);
            this.button1.TabIndex = 9;
            this.button1.Text = "查找";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(584, 86);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 26);
            this.comboBox3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(515, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "星座：";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(357, 86);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(113, 26);
            this.comboBox2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "年龄：";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comboBox1.Location = new System.Drawing.Point(127, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "性别：";
            // 
            // ckzaixian
            // 
            this.ckzaixian.AutoSize = true;
            this.ckzaixian.Location = new System.Drawing.Point(508, 25);
            this.ckzaixian.Name = "ckzaixian";
            this.ckzaixian.Size = new System.Drawing.Size(70, 22);
            this.ckzaixian.TabIndex = 2;
            this.ckzaixian.Text = "在线";
            this.ckzaixian.UseVisualStyleBackColor = true;
            // 
            // textkey
            // 
            this.textkey.Location = new System.Drawing.Point(151, 19);
            this.textkey.Name = "textkey";
            this.textkey.Size = new System.Drawing.Size(336, 28);
            this.textkey.TabIndex = 1;
            this.textkey.Text = "QQ号/昵称/姓名";
            this.textkey.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textkey_MouseClick);
            this.textkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtkey_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "搜索条件：";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Khaki;
            this.panel2.Controls.Add(this.guanbi);
            this.panel2.Controls.Add(this.tianjia);
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 190);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 434);
            this.panel2.TabIndex = 1;
            // 
            // guanbi
            // 
            this.guanbi.Location = new System.Drawing.Point(717, 344);
            this.guanbi.Name = "guanbi";
            this.guanbi.Size = new System.Drawing.Size(201, 61);
            this.guanbi.TabIndex = 3;
            this.guanbi.Text = "关闭";
            this.guanbi.UseVisualStyleBackColor = true;
            this.guanbi.Click += new System.EventHandler(this.guanbi_Click);
            // 
            // tianjia
            // 
            this.tianjia.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tianjia.Location = new System.Drawing.Point(94, 344);
            this.tianjia.Name = "tianjia";
            this.tianjia.Size = new System.Drawing.Size(240, 62);
            this.tianjia.TabIndex = 1;
            this.tianjia.Text = "添加";
            this.tianjia.UseVisualStyleBackColor = true;
            this.tianjia.Click += new System.EventHandler(this.tianjia_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(984, 329);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "QQ账号";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "昵称";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "年龄";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "性别";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "星座";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 100;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加好友ToolStripMenuItem,
            this.详细信息ToolStripMenuItem,
            this.屏蔽ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 94);
            // 
            // 添加好友ToolStripMenuItem
            // 
            this.添加好友ToolStripMenuItem.Name = "添加好友ToolStripMenuItem";
            this.添加好友ToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.添加好友ToolStripMenuItem.Text = "添加好友";
            this.添加好友ToolStripMenuItem.Click += new System.EventHandler(this.添加好友ToolStripMenuItem_Click);
            // 
            // 详细信息ToolStripMenuItem
            // 
            this.详细信息ToolStripMenuItem.Name = "详细信息ToolStripMenuItem";
            this.详细信息ToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.详细信息ToolStripMenuItem.Text = "详细信息";
            this.详细信息ToolStripMenuItem.Click += new System.EventHandler(this.详细信息ToolStripMenuItem_Click);
            // 
            // 屏蔽ToolStripMenuItem
            // 
            this.屏蔽ToolStripMenuItem.Name = "屏蔽ToolStripMenuItem";
            this.屏蔽ToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.屏蔽ToolStripMenuItem.Text = "屏蔽";
            this.屏蔽ToolStripMenuItem.Click += new System.EventHandler(this.屏蔽ToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "qq.ico");
            this.imageList1.Images.SetKeyName(1, "发送消息.png");
            this.imageList1.Images.SetKeyName(2, "加好友2.jpg");
            this.imageList1.Images.SetKeyName(3, "空间 (1).png");
            this.imageList1.Images.SetKeyName(4, "空间.png");
            this.imageList1.Images.SetKeyName(5, "设置.png");
            this.imageList1.Images.SetKeyName(6, "添加好友 (1).png");
            this.imageList1.Images.SetKeyName(7, "添加好友 (2).png");
            this.imageList1.Images.SetKeyName(8, "添加好友 (3).png");
            this.imageList1.Images.SetKeyName(9, "添加好友.png");
            this.imageList1.Images.SetKeyName(10, "头像1.jpg");
            this.imageList1.Images.SetKeyName(11, "头像2.jpg");
            this.imageList1.Images.SetKeyName(12, "邮箱.png");
            this.imageList1.Images.SetKeyName(13, "游戏.png");
            // 
            // addfriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 624);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addfriend";
            this.Text = "添加好友";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckzaixian;
        private System.Windows.Forms.TextBox textkey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button tianjia;
        private System.Windows.Forms.Button guanbi;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 添加好友ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 详细信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 屏蔽ToolStripMenuItem;
    }
}