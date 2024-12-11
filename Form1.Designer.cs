namespace YoloFormsApp
{
    partial class Yolo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            testToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            splitContainer3 = new SplitContainer();
            groupBox3 = new GroupBox();
            button2 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            dataGridViewFiles = new DataGridView();
            btn_model_select = new Button();
            tb_model_path = new TextBox();
            label2 = new Label();
            splitContainer4 = new SplitContainer();
            button1 = new Button();
            groupBoxResult = new GroupBox();
            dataGridViewResult = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            splitContainer2 = new SplitContainer();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            pictureBox2 = new PictureBox();
            Column1 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFiles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { testToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1078, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // testToolStripMenuItem
            // 
            testToolStripMenuItem.Name = "testToolStripMenuItem";
            testToolStripMenuItem.Size = new Size(42, 20);
            testToolStripMenuItem.Text = "Test";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(39, 20);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 24);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1078, 626);
            splitContainer1.SplitterDistance = 530;
            splitContainer1.TabIndex = 3;
            // 
            // splitContainer3
            // 
            splitContainer3.BorderStyle = BorderStyle.Fixed3D;
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(groupBox3);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(splitContainer4);
            splitContainer3.Size = new Size(530, 626);
            splitContainer3.SplitterDistance = 282;
            splitContainer3.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(dataGridViewFiles);
            groupBox3.Controls.Add(btn_model_select);
            groupBox3.Controls.Add(tb_model_path);
            groupBox3.Controls.Add(label2);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(526, 278);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "ImageSetting";
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button2.Location = new Point(353, 53);
            button2.Margin = new Padding(2, 3, 2, 3);
            button2.Name = "button2";
            button2.Size = new Size(88, 26);
            button2.TabIndex = 15;
            button2.Text = "Select";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 12F);
            textBox1.Location = new Point(84, 53);
            textBox1.Margin = new Padding(2, 3, 2, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(254, 26);
            textBox1.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 59);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 16;
            label1.Text = "Image Path:";
            // 
            // dataGridViewFiles
            // 
            dataGridViewFiles.AllowUserToAddRows = false;
            dataGridViewFiles.AllowUserToDeleteRows = false;
            dataGridViewFiles.AllowUserToResizeRows = false;
            dataGridViewFiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFiles.BackgroundColor = SystemColors.AppWorkspace;
            dataGridViewFiles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFiles.Columns.AddRange(new DataGridViewColumn[] { Column1, Column7, Column8, Column9 });
            dataGridViewFiles.Location = new Point(9, 85);
            dataGridViewFiles.Name = "dataGridViewFiles";
            dataGridViewFiles.RowHeadersVisible = false;
            dataGridViewFiles.Size = new Size(511, 187);
            dataGridViewFiles.TabIndex = 14;
            dataGridViewFiles.SelectionChanged += dataGridViewFiles_SelectionChanged;
            dataGridViewFiles.KeyDown += dataGridViewFiles_KeyDown;
            // 
            // btn_model_select
            // 
            btn_model_select.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btn_model_select.Location = new Point(353, 18);
            btn_model_select.Margin = new Padding(2, 3, 2, 3);
            btn_model_select.Name = "btn_model_select";
            btn_model_select.Size = new Size(88, 26);
            btn_model_select.TabIndex = 11;
            btn_model_select.Text = "Select";
            btn_model_select.UseVisualStyleBackColor = true;
            btn_model_select.Click += btn_model_select_Click;
            // 
            // tb_model_path
            // 
            tb_model_path.Font = new Font("Times New Roman", 12F);
            tb_model_path.Location = new Point(84, 19);
            tb_model_path.Margin = new Padding(2, 3, 2, 3);
            tb_model_path.Name = "tb_model_path";
            tb_model_path.Size = new Size(254, 26);
            tb_model_path.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 25);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 12;
            label2.Text = "Model Path:";
            // 
            // splitContainer4
            // 
            splitContainer4.BorderStyle = BorderStyle.Fixed3D;
            splitContainer4.Dock = DockStyle.Fill;
            splitContainer4.Location = new Point(0, 0);
            splitContainer4.Name = "splitContainer4";
            splitContainer4.Orientation = Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            splitContainer4.Panel1.Controls.Add(button1);
            // 
            // splitContainer4.Panel2
            // 
            splitContainer4.Panel2.Controls.Add(groupBoxResult);
            splitContainer4.Size = new Size(530, 340);
            splitContainer4.SplitterDistance = 41;
            splitContainer4.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            button1.Location = new Point(9, 6);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(123, 26);
            button1.TabIndex = 5;
            button1.Text = "Process Image";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(dataGridViewResult);
            groupBoxResult.Dock = DockStyle.Fill;
            groupBoxResult.Location = new Point(0, 0);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(526, 291);
            groupBoxResult.TabIndex = 16;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = " Result ";
            // 
            // dataGridViewResult
            // 
            dataGridViewResult.AllowUserToAddRows = false;
            dataGridViewResult.AllowUserToDeleteRows = false;
            dataGridViewResult.AllowUserToResizeRows = false;
            dataGridViewResult.BackgroundColor = SystemColors.AppWorkspace;
            dataGridViewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewResult.Dock = DockStyle.Fill;
            dataGridViewResult.Location = new Point(3, 19);
            dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewResult.RowHeadersVisible = false;
            dataGridViewResult.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewResult.Size = new Size(520, 269);
            dataGridViewResult.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.DataPropertyName = "Type";
            dataGridViewTextBoxColumn1.HeaderText = "Type";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Confidence";
            Column2.HeaderText = "Confidence";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "X";
            Column3.HeaderText = "X";
            Column3.Name = "Column3";
            Column3.Width = 50;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Y";
            Column4.HeaderText = "Y";
            Column4.Name = "Column4";
            Column4.Width = 50;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "Width";
            Column5.HeaderText = "Width";
            Column5.Name = "Column5";
            Column5.Width = 50;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "Height";
            Column6.HeaderText = "Height";
            Column6.Name = "Column6";
            Column6.Width = 50;
            // 
            // splitContainer2
            // 
            splitContainer2.BorderStyle = BorderStyle.Fixed3D;
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(groupBox2);
            splitContainer2.Size = new Size(544, 626);
            splitContainer2.SplitterDistance = 313;
            splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(540, 309);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Preview";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(534, 287);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(540, 305);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Inference";
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Location = new Point(3, 19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(534, 283);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Name";
            Column1.FillWeight = 101.522865F;
            Column1.HeaderText = "Name";
            Column1.Name = "Column1";
            // 
            // Column7
            // 
            Column7.DataPropertyName = "Path";
            Column7.FillWeight = 155.534485F;
            Column7.HeaderText = "Path";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.DataPropertyName = "Width";
            Column8.FillWeight = 63.43573F;
            Column8.HeaderText = "Width";
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.DataPropertyName = "Height";
            Column9.FillWeight = 79.507F;
            Column9.HeaderText = "Height";
            Column9.Name = "Column9";
            // 
            // Yolo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 650);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "Yolo";
            Text = "Yolo";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFiles).EndInit();
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            groupBoxResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).EndInit();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem testToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private SplitContainer splitContainer4;
        private Button button1;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private PictureBox pictureBox2;
        private GroupBox groupBox3;
        private Button button2;
        private TextBox textBox1;
        private Label label1;
        private DataGridView dataGridViewFiles;
        private Button btn_model_select;
        private TextBox tb_model_path;
        private Label label2;
        private GroupBox groupBoxResult;
        private DataGridView dataGridViewResult;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
    }
}
