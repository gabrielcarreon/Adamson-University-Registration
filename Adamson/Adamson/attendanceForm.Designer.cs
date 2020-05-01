namespace Adamson
{
    partial class attendanceForm
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
            this.backBtn = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.studentAttendace = new System.Windows.Forms.DataGridView();
            this.checkDate = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.eventlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentAttendace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(16, 15);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(100, 28);
            this.backBtn.TabIndex = 15;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // searchBox
            // 
            this.searchBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchBox.Location = new System.Drawing.Point(155, 198);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(500, 22);
            this.searchBox.TabIndex = 14;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 202);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Search:";
            // 
            // searchComboBox
            // 
            this.searchComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Items.AddRange(new object[] {
            "StudentID",
            "StudentName",
            "Course",
            "Block",
            "Attendance",
            "TimeIn"});
            this.searchComboBox.Location = new System.Drawing.Point(664, 197);
            this.searchComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(160, 24);
            this.searchComboBox.TabIndex = 17;
            // 
            // studentAttendace
            // 
            this.studentAttendace.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.studentAttendace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentAttendace.GridColor = System.Drawing.Color.Navy;
            this.studentAttendace.Location = new System.Drawing.Point(16, 230);
            this.studentAttendace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.studentAttendace.Name = "studentAttendace";
            this.studentAttendace.ReadOnly = true;
            this.studentAttendace.Size = new System.Drawing.Size(856, 628);
            this.studentAttendace.TabIndex = 13;
            // 
            // checkDate
            // 
            this.checkDate.Location = new System.Drawing.Point(139, 18);
            this.checkDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkDate.Name = "checkDate";
            this.checkDate.Size = new System.Drawing.Size(265, 22);
            this.checkDate.TabIndex = 19;
            this.checkDate.ValueChanged += new System.EventHandler(this.checkDate_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Adamson.Properties.Resources.AdU_Name;
            this.pictureBox1.Location = new System.Drawing.Point(124, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(661, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // eventlabel
            // 
            this.eventlabel.AutoSize = true;
            this.eventlabel.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventlabel.Location = new System.Drawing.Point(704, 13);
            this.eventlabel.Name = "eventlabel";
            this.eventlabel.Size = new System.Drawing.Size(0, 28);
            this.eventlabel.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(555, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "Event name:";
            // 
            // attendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 873);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eventlabel);
            this.Controls.Add(this.checkDate);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchComboBox);
            this.Controls.Add(this.studentAttendace);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "attendanceForm";
            this.Text = " Attendance Data";
            this.Load += new System.EventHandler(this.attendanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentAttendace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox searchComboBox;
        private System.Windows.Forms.DataGridView studentAttendace;
        private System.Windows.Forms.DateTimePicker checkDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label eventlabel;
        private System.Windows.Forms.Label label1;
    }
}