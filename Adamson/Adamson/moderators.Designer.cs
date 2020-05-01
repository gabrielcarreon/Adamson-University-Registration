namespace Adamson
{
    partial class moderators
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
            this.done = new System.Windows.Forms.Button();
            this.editors = new System.Windows.Forms.ComboBox();
            this.changePermission = new System.Windows.Forms.Button();
            this.removeMod = new System.Windows.Forms.Button();
            this.userIDTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.createAcc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.updateTick = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.permissionCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // done
            // 
            this.done.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.done.Location = new System.Drawing.Point(446, 397);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(106, 36);
            this.done.TabIndex = 0;
            this.done.Text = "Done";
            this.done.UseVisualStyleBackColor = true;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // editors
            // 
            this.editors.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editors.FormattingEnabled = true;
            this.editors.Location = new System.Drawing.Point(12, 11);
            this.editors.MaxDropDownItems = 2;
            this.editors.Name = "editors";
            this.editors.Size = new System.Drawing.Size(364, 31);
            this.editors.TabIndex = 1;
            this.editors.SelectedIndexChanged += new System.EventHandler(this.editors_SelectedIndexChanged);
            // 
            // changePermission
            // 
            this.changePermission.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePermission.Location = new System.Drawing.Point(382, 11);
            this.changePermission.Name = "changePermission";
            this.changePermission.Size = new System.Drawing.Size(232, 31);
            this.changePermission.TabIndex = 2;
            this.changePermission.Text = "Change to";
            this.changePermission.UseVisualStyleBackColor = true;
            this.changePermission.Click += new System.EventHandler(this.changePermission_Click);
            // 
            // removeMod
            // 
            this.removeMod.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeMod.Location = new System.Drawing.Point(382, 67);
            this.removeMod.Name = "removeMod";
            this.removeMod.Size = new System.Drawing.Size(232, 31);
            this.removeMod.TabIndex = 3;
            this.removeMod.Text = "Remove";
            this.removeMod.UseVisualStyleBackColor = true;
            this.removeMod.Click += new System.EventHandler(this.removeMod_Click);
            // 
            // userIDTxt
            // 
            this.userIDTxt.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIDTxt.Location = new System.Drawing.Point(108, 282);
            this.userIDTxt.Name = "userIDTxt";
            this.userIDTxt.Size = new System.Drawing.Size(270, 30);
            this.userIDTxt.TabIndex = 4;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(108, 318);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(270, 30);
            this.passwordTxt.TabIndex = 5;
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.Location = new System.Drawing.Point(108, 354);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(270, 30);
            this.nameTxt.TabIndex = 6;
            // 
            // createAcc
            // 
            this.createAcc.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAcc.Location = new System.Drawing.Point(152, 400);
            this.createAcc.Name = "createAcc";
            this.createAcc.Size = new System.Drawing.Size(164, 31);
            this.createAcc.TabIndex = 7;
            this.createAcc.Text = "Create Account";
            this.createAcc.UseVisualStyleBackColor = true;
            this.createAcc.Click += new System.EventHandler(this.createAcc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "User ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Name:";
            // 
            // updateTick
            // 
            this.updateTick.Tick += new System.EventHandler(this.updateTick_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Adamson.Properties.Resources.gearsGIF;
            this.pictureBox1.Location = new System.Drawing.Point(12, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // permissionCombo
            // 
            this.permissionCombo.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.permissionCombo.FormattingEnabled = true;
            this.permissionCombo.Items.AddRange(new object[] {
            "Admin",
            "Moderator"});
            this.permissionCombo.Location = new System.Drawing.Point(418, 318);
            this.permissionCombo.Name = "permissionCombo";
            this.permissionCombo.Size = new System.Drawing.Size(177, 31);
            this.permissionCombo.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(433, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Permission Type";
            // 
            // moderators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 443);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.permissionCombo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createAcc);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.userIDTxt);
            this.Controls.Add(this.removeMod);
            this.Controls.Add(this.changePermission);
            this.Controls.Add(this.editors);
            this.Controls.Add(this.done);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "moderators";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adamson University";
            this.Load += new System.EventHandler(this.moderators_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button done;
        private System.Windows.Forms.ComboBox editors;
        private System.Windows.Forms.Button changePermission;
        private System.Windows.Forms.Button removeMod;
        private System.Windows.Forms.TextBox userIDTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Button createAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer updateTick;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox permissionCombo;
        private System.Windows.Forms.Label label4;
    }
}