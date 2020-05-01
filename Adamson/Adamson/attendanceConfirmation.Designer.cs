namespace Adamson
{
    partial class attendanceConfirmation
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
            this.timeIn = new System.Windows.Forms.Label();
            this.studentPic = new System.Windows.Forms.PictureBox();
            this.confirmTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentPic)).BeginInit();
            this.SuspendLayout();
            // 
            // timeIn
            // 
            this.timeIn.AutoSize = true;
            this.timeIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeIn.Location = new System.Drawing.Point(217, 546);
            this.timeIn.Name = "timeIn";
            this.timeIn.Size = new System.Drawing.Size(202, 42);
            this.timeIn.TabIndex = 1;
            this.timeIn.Text = "registration";
            // 
            // studentPic
            // 
            this.studentPic.Location = new System.Drawing.Point(52, 104);
            this.studentPic.Name = "studentPic";
            this.studentPic.Size = new System.Drawing.Size(523, 426);
            this.studentPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.studentPic.TabIndex = 0;
            this.studentPic.TabStop = false;
            // 
            // confirmTimer
            // 
            this.confirmTimer.Interval = 1000;
            this.confirmTimer.Tick += new System.EventHandler(this.confirmTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registration Successful";
            // 
            // attendanceConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(625, 607);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeIn);
            this.Controls.Add(this.studentPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "attendanceConfirmation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adamson University";
            this.Load += new System.EventHandler(this.attendanceConfirmation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox studentPic;
        private System.Windows.Forms.Label timeIn;
        private System.Windows.Forms.Timer confirmTimer;
        private System.Windows.Forms.Label label1;
    }
}