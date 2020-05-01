namespace Adamson
{
    partial class settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings));
            this.lightModePic = new System.Windows.Forms.PictureBox();
            this.darkModePic = new System.Windows.Forms.PictureBox();
            this.toggleSwitchBtn = new System.Windows.Forms.PictureBox();
            this.saveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lightModePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkModePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // lightModePic
            // 
            this.lightModePic.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lightModePic.BackColor = System.Drawing.Color.Transparent;
            this.lightModePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lightModePic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lightModePic.Image = global::Adamson.Properties.Resources.lightmodelogo;
            this.lightModePic.Location = new System.Drawing.Point(132, 22);
            this.lightModePic.Name = "lightModePic";
            this.lightModePic.Size = new System.Drawing.Size(48, 42);
            this.lightModePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lightModePic.TabIndex = 2;
            this.lightModePic.TabStop = false;
            this.lightModePic.Click += new System.EventHandler(this.lightModePic_Click);
            // 
            // darkModePic
            // 
            this.darkModePic.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.darkModePic.BackColor = System.Drawing.Color.Transparent;
            this.darkModePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.darkModePic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.darkModePic.Image = ((System.Drawing.Image)(resources.GetObject("darkModePic.Image")));
            this.darkModePic.Location = new System.Drawing.Point(46, 22);
            this.darkModePic.Name = "darkModePic";
            this.darkModePic.Size = new System.Drawing.Size(44, 42);
            this.darkModePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.darkModePic.TabIndex = 0;
            this.darkModePic.TabStop = false;
            this.darkModePic.Click += new System.EventHandler(this.darkModePic_Click);
            // 
            // toggleSwitchBtn
            // 
            this.toggleSwitchBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.toggleSwitchBtn.BackColor = System.Drawing.Color.Transparent;
            this.toggleSwitchBtn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.toggleSwitchBtn.Image = global::Adamson.Properties.Resources.toggleswitchlight;
            this.toggleSwitchBtn.Location = new System.Drawing.Point(78, 22);
            this.toggleSwitchBtn.Name = "toggleSwitchBtn";
            this.toggleSwitchBtn.Size = new System.Drawing.Size(66, 42);
            this.toggleSwitchBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.toggleSwitchBtn.TabIndex = 1;
            this.toggleSwitchBtn.TabStop = false;
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(78, 300);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(71, 27);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(239, 339);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.lightModePic);
            this.Controls.Add(this.darkModePic);
            this.Controls.Add(this.toggleSwitchBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "settings";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.lightModePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkModePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitchBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox darkModePic;
        private System.Windows.Forms.PictureBox toggleSwitchBtn;
        private System.Windows.Forms.PictureBox lightModePic;
        private System.Windows.Forms.Button saveBtn;
    }
}