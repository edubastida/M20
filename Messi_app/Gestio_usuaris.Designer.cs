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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMAC
            // 
            this.txtMAC.Enabled = false;
            this.txtMAC.Location = new System.Drawing.Point(165, 28);
            this.txtMAC.Multiline = true;
            this.txtMAC.Name = "txtMAC";
            this.txtMAC.Size = new System.Drawing.Size(180, 25);
            this.txtMAC.TabIndex = 0;
            // 
            // txtHostName
            // 
            this.txtHostName.Enabled = false;
            this.txtHostName.Location = new System.Drawing.Point(165, 81);
            this.txtHostName.Multiline = true;
            this.txtHostName.Name = "txtHostName";
            this.txtHostName.Size = new System.Drawing.Size(261, 25);
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
            this.combUser.Location = new System.Drawing.Point(680, 32);
            this.combUser.Name = "combUser";
            this.combUser.Size = new System.Drawing.Size(175, 30);
            this.combUser.TabIndex = 2;
            // 
            // lblMAC
            // 
            this.lblMAC.AutoSize = true;
            this.lblMAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMAC.Location = new System.Drawing.Point(26, 28);
            this.lblMAC.Name = "lblMAC";
            this.lblMAC.Size = new System.Drawing.Size(73, 25);
            this.lblMAC.TabIndex = 3;
            this.lblMAC.Text = "M.A.C.";
            // 
            // lblHostName
            // 
            this.lblHostName.AutoSize = true;
            this.lblHostName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostName.Location = new System.Drawing.Point(26, 81);
            this.lblHostName.Name = "lblHostName";
            this.lblHostName.Size = new System.Drawing.Size(104, 25);
            this.lblHostName.TabIndex = 4;
            this.lblHostName.Text = "HostName";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtUsers);
            this.panel1.Controls.Add(this.txtMAC);
            this.panel1.Controls.Add(this.lblHostName);
            this.panel1.Controls.Add(this.txtHostName);
            this.panel1.Controls.Add(this.lblMAC);
            this.panel1.Controls.Add(this.combUser);
            this.panel1.Location = new System.Drawing.Point(45, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 134);
            this.panel1.TabIndex = 5;
            // 
            // txtUsers
            // 
            this.txtUsers.AutoSize = true;
            this.txtUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsers.Location = new System.Drawing.Point(590, 32);
            this.txtUsers.Name = "txtUsers";
            this.txtUsers.Size = new System.Drawing.Size(59, 25);
            this.txtUsers.TabIndex = 5;
            this.txtUsers.Text = "User:";
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(96, 222);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(103, 40);
            this.btnCheck.TabIndex = 6;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(239, 222);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(103, 40);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(384, 222);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 40);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // Gestio_usuaris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.panel1);
            this.Name = "Gestio_usuaris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Gestio_usuaris_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}