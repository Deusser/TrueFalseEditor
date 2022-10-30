namespace TrueFalseEditor
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.BottonNew = new System.Windows.Forms.ToolStripMenuItem();
            this.BottonSave = new System.Windows.Forms.ToolStripMenuItem();
            this.BottonLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BottonExit = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            this.cbTrue = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imSaveAs_Click = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(546, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BottonNew,
            this.imSaveAs_Click,
            this.BottonSave,
            this.BottonLoad,
            this.toolStripSeparator1,
            this.BottonExit,
            this.about});
            this.toolStripDropDownButton1.ForeColor = System.Drawing.Color.Green;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // BottonNew
            // 
            this.BottonNew.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BottonNew.ForeColor = System.Drawing.Color.ForestGreen;
            this.BottonNew.Name = "BottonNew";
            this.BottonNew.Size = new System.Drawing.Size(180, 22);
            this.BottonNew.Text = "New";
            this.BottonNew.Click += new System.EventHandler(this.BottonNew_Click);
            // 
            // BottonSave
            // 
            this.BottonSave.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BottonSave.ForeColor = System.Drawing.Color.ForestGreen;
            this.BottonSave.Name = "BottonSave";
            this.BottonSave.Size = new System.Drawing.Size(180, 22);
            this.BottonSave.Text = "Save";
            this.BottonSave.Click += new System.EventHandler(this.BottonSave_Click);
            // 
            // BottonLoad
            // 
            this.BottonLoad.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BottonLoad.ForeColor = System.Drawing.Color.ForestGreen;
            this.BottonLoad.Name = "BottonLoad";
            this.BottonLoad.Size = new System.Drawing.Size(180, 22);
            this.BottonLoad.Text = "Open";
            this.BottonLoad.Click += new System.EventHandler(this.BottonLoad_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.ForestGreen;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // BottonExit
            // 
            this.BottonExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BottonExit.ForeColor = System.Drawing.Color.ForestGreen;
            this.BottonExit.Name = "BottonExit";
            this.BottonExit.Size = new System.Drawing.Size(180, 22);
            this.BottonExit.Text = "Exit";
            this.BottonExit.Click += new System.EventHandler(this.BottonExit_Click);
            // 
            // about
            // 
            this.about.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.about.ForeColor = System.Drawing.Color.ForestGreen;
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(180, 22);
            this.about.Text = "О программе";
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // tbQuestion
            // 
            this.tbQuestion.BackColor = System.Drawing.SystemColors.WindowText;
            this.tbQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbQuestion.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbQuestion.ForeColor = System.Drawing.Color.DarkGreen;
            this.tbQuestion.Location = new System.Drawing.Point(0, 306);
            this.tbQuestion.Multiline = true;
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Size = new System.Drawing.Size(465, 63);
            this.tbQuestion.TabIndex = 2;
            // 
            // nudNumber
            // 
            this.nudNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nudNumber.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nudNumber.ForeColor = System.Drawing.Color.DarkGreen;
            this.nudNumber.Location = new System.Drawing.Point(486, 277);
            this.nudNumber.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(48, 23);
            this.nudNumber.TabIndex = 0;
            this.nudNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumber.ValueChanged += new System.EventHandler(this.nudNumber_ValueChanged);
            // 
            // cbTrue
            // 
            this.cbTrue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTrue.AutoSize = true;
            this.cbTrue.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbTrue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTrue.ForeColor = System.Drawing.Color.DarkGreen;
            this.cbTrue.Location = new System.Drawing.Point(489, 252);
            this.cbTrue.Name = "cbTrue";
            this.cbTrue.Size = new System.Drawing.Size(45, 19);
            this.cbTrue.TabIndex = 1;
            this.cbTrue.Text = "True";
            this.cbTrue.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAdd.Location = new System.Drawing.Point(471, 306);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnDelete.Location = new System.Drawing.Point(471, 346);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSave.Location = new System.Drawing.Point(471, 325);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(546, 369);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // imSaveAs_Click
            // 
            this.imSaveAs_Click.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.imSaveAs_Click.ForeColor = System.Drawing.Color.ForestGreen;
            this.imSaveAs_Click.Name = "imSaveAs_Click";
            this.imSaveAs_Click.Size = new System.Drawing.Size(180, 22);
            this.imSaveAs_Click.Text = "Save as";
            this.imSaveAs_Click.Click += new System.EventHandler(this.imSaveAs_Click_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(546, 369);
            this.Controls.Add(this.cbTrue);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.nudNumber);
            this.Controls.Add(this.tbQuestion);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrueFalseEditor";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem BottonNew;
        private ToolStripMenuItem BottonSave;
        private ToolStripMenuItem BottonLoad;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem BottonExit;
        private TextBox tbQuestion;
        private ToolStripMenuItem about;
        private NumericUpDown nudNumber;
        private CheckBox cbTrue;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnSave;
        private PictureBox pictureBox1;
        private ToolStripMenuItem imSaveAs_Click;
    }
}