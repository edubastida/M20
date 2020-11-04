namespace Messi_app
{
    partial class Gestio_usuaris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestio_usuaris));
            this.txtMAC = new System.Windows.Forms.TextBox();
            this.txtHostName = new System.Windows.Forms.TextBox();
            this.combUser = new System.Windows.Forms.ComboBox();
            this.lblMAC = new System.Windows.Forms.Label();
            this.lblHostName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUsers = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.boto_return1 = new Messi_Control.Boto_return(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMAC
            // 
            this.txtMAC.Enabled = false;
            this.txtMAC.Location = new System.Drawing.Point(124, 23);
            this.txtMAC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMAC.Multiline = true;
            this.txtMAC.Name = "txtMAC";
            this.txtMAC.Size = new System.Drawing.Size(136, 21);
            this.txtMAC.TabIndex = 0;
            // 
            // txtHostName
            // 
            this.txtHostName.Enabled = false;
            this.txtHostName.Location = new System.Drawing.Point(144, 66);
            this.txtHostName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHostName.Multiline = true;
            this.txtHostName.Name = "txtHostName";
            this.txtHostName.Size = new System.Drawing.Size(197, 21);
            this.txtHostName.TabIndex = 1;
            // 
            // combUser
            // 
            this.combUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combUser.FormattingEnabled = true;
            this.combUser.Items.AddRange(new object[] {
            "GutiTheBest",
            "EduTheBest",
            "RubenTheWorst"});
            this.combUser.Location = new System.Drawing.Point(510, 26);
            this.combUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.combUser.Name = "combUser";
            this.combUser.Size = new System.Drawing.Size(132, 25);
            this.combUser.TabIndex = 2;
            // 
            // lblMAC
            // 
            this.lblMAC.AutoSize = true;
            this.lblMAC.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMAC.Location = new System.Drawing.Point(20, 23);
            this.lblMAC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMAC.Name = "lblMAC";
            this.lblMAC.Size = new System.Drawing.Size(67, 19);
            this.lblMAC.TabIndex = 3;
            this.lblMAC.Text = "M.A.C.";
            // 
            // lblHostName
            // 
            this.lblHostName.AutoSize = true;
            this.lblHostName.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostName.Location = new System.Drawing.Point(20, 66);
            this.lblHostName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHostName.Name = "lblHostName";
            this.lblHostName.Size = new System.Drawing.Size(123, 19);
            this.lblHostName.TabIndex = 4;
            this.lblHostName.Text = "HostName";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtUsers);
            this.panel1.Controls.Add(this.txtMAC);
            this.panel1.Controls.Add(this.lblHostName);
            this.panel1.Controls.Add(this.txtHostName);
            this.panel1.Controls.Add(this.lblMAC);
            this.panel1.Controls.Add(this.combUser);
            this.panel1.Location = new System.Drawing.Point(74, 44);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 109);
            this.panel1.TabIndex = 5;
            // 
            // txtUsers
            // 
            this.txtUsers.AutoSize = true;
            this.txtUsers.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsers.Location = new System.Drawing.Point(435, 29);
            this.txtUsers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtUsers.Name = "txtUsers";
            this.txtUsers.Size = new System.Drawing.Size(66, 19);
            this.txtUsers.TabIndex = 5;
            this.txtUsers.Text = "User";
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCheck.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCheck.Location = new System.Drawing.Point(74, 180);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(86, 32);
            this.btnCheck.TabIndex = 6;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRegister.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegister.Location = new System.Drawing.Point(179, 180);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(116, 32);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDelete.Font = new System.Drawing.Font("ROG Fonts", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(315, 180);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 32);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Messi_app.Properties.Resources._987_1540913843_2062609336;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(488, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 271);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // boto_return1
            // 
            this.boto_return1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.boto_return1.BackColor = System.Drawing.Color.Transparent;
            this.boto_return1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("boto_return1.BackgroundImage")));
            this.boto_return1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boto_return1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.boto_return1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boto_return1.ForeColor = System.Drawing.Color.Transparent;
            this.boto_return1.Location = new System.Drawing.Point(3, 3);
            this.boto_return1.Name = "boto_return1";
            this.boto_return1.Size = new System.Drawing.Size(47, 40);
            this.boto_return1.TabIndex = 10;
            this.boto_return1.TabStop = false;
            this.boto_return1.UseVisualStyleBackColor = false;
            // 
            // Gestio_usuaris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boto_return1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Gestio_usuaris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Gestio_usuaris_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtMAC;
        private System.Windows.Forms.TextBox txtHostName;
        private System.Windows.Forms.ComboBox combUser;
        private System.Windows.Forms.Label lblMAC;
        private System.Windows.Forms.Label lblHostName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtUsers;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Messi_Control.Boto_return boto_return1;
    }
}