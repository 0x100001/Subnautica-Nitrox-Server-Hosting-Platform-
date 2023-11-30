
namespace Subnautica_Server___Management_Tool.Helper
{
    partial class Register_Server_Form
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
            this.borderless_control = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.form_header = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.header_title_label = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.username_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.password_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.confirm_password_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.register_button = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.form_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // borderless_control
            // 
            this.borderless_control.AnimateWindow = true;
            this.borderless_control.ContainerControl = this;
            this.borderless_control.DragStartTransparencyValue = 0.7D;
            this.borderless_control.ResizeForm = false;
            this.borderless_control.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.borderless_control.TransparentWhileDrag = true;
            // 
            // form_header
            // 
            this.form_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.form_header.Controls.Add(this.pictureBox1);
            this.form_header.Controls.Add(this.guna2ControlBox2);
            this.form_header.Controls.Add(this.guna2ControlBox1);
            this.form_header.Controls.Add(this.header_title_label);
            this.form_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.form_header.Location = new System.Drawing.Point(0, 0);
            this.form_header.Name = "form_header";
            this.form_header.Size = new System.Drawing.Size(519, 33);
            this.form_header.TabIndex = 7;
            this.form_header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_header_MouseDown);
            this.form_header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_header_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.pictureBox1.Image = global::Subnautica_Server___Management_Tool.Properties.Resources.subnautica_48px;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(429, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 33);
            this.guna2ControlBox2.TabIndex = 24;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(474, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 33);
            this.guna2ControlBox1.TabIndex = 23;
            // 
            // header_title_label
            // 
            this.header_title_label.AutoSize = true;
            this.header_title_label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_title_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.header_title_label.Location = new System.Drawing.Point(39, 8);
            this.header_title_label.Name = "header_title_label";
            this.header_title_label.Size = new System.Drawing.Size(258, 18);
            this.header_title_label.TabIndex = 1;
            this.header_title_label.Text = "Subnautica Server - Register Server";
            this.header_title_label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_title_label_MouseDown);
            this.header_title_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.header_title_label_MouseMove);
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label70.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label70.Location = new System.Drawing.Point(79, 81);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(101, 25);
            this.label70.TabIndex = 84;
            this.label70.Text = "Username:";
            // 
            // username_textbox
            // 
            this.username_textbox.Animated = true;
            this.username_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username_textbox.DefaultText = "";
            this.username_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.username_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.username_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username_textbox.DisabledState.Parent = this.username_textbox;
            this.username_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.username_textbox.FocusedState.Parent = this.username_textbox;
            this.username_textbox.Font = new System.Drawing.Font("Arial", 9.75F);
            this.username_textbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.username_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.username_textbox.HoverState.Parent = this.username_textbox;
            this.username_textbox.Location = new System.Drawing.Point(186, 80);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.PasswordChar = '\0';
            this.username_textbox.PlaceholderText = "";
            this.username_textbox.SelectedText = "";
            this.username_textbox.ShadowDecoration.Parent = this.username_textbox;
            this.username_textbox.Size = new System.Drawing.Size(324, 26);
            this.username_textbox.TabIndex = 85;
            this.username_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 87;
            this.label2.Text = "Password:";
            // 
            // password_textbox
            // 
            this.password_textbox.Animated = true;
            this.password_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password_textbox.DefaultText = "";
            this.password_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_textbox.DisabledState.Parent = this.password_textbox;
            this.password_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.password_textbox.FocusedState.Parent = this.password_textbox;
            this.password_textbox.Font = new System.Drawing.Font("Arial", 9.75F);
            this.password_textbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.password_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.password_textbox.HoverState.Parent = this.password_textbox;
            this.password_textbox.Location = new System.Drawing.Point(186, 112);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '\0';
            this.password_textbox.PlaceholderText = "";
            this.password_textbox.SelectedText = "";
            this.password_textbox.ShadowDecoration.Parent = this.password_textbox;
            this.password_textbox.Size = new System.Drawing.Size(324, 26);
            this.password_textbox.TabIndex = 88;
            this.password_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password_textbox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 25);
            this.label3.TabIndex = 89;
            this.label3.Text = "Confirm Password:";
            // 
            // confirm_password_textbox
            // 
            this.confirm_password_textbox.Animated = true;
            this.confirm_password_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.confirm_password_textbox.DefaultText = "";
            this.confirm_password_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.confirm_password_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.confirm_password_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.confirm_password_textbox.DisabledState.Parent = this.confirm_password_textbox;
            this.confirm_password_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.confirm_password_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.confirm_password_textbox.FocusedState.Parent = this.confirm_password_textbox;
            this.confirm_password_textbox.Font = new System.Drawing.Font("Arial", 9.75F);
            this.confirm_password_textbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.confirm_password_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.confirm_password_textbox.HoverState.Parent = this.confirm_password_textbox;
            this.confirm_password_textbox.Location = new System.Drawing.Point(186, 144);
            this.confirm_password_textbox.Name = "confirm_password_textbox";
            this.confirm_password_textbox.PasswordChar = '\0';
            this.confirm_password_textbox.PlaceholderText = "";
            this.confirm_password_textbox.SelectedText = "";
            this.confirm_password_textbox.ShadowDecoration.Parent = this.confirm_password_textbox;
            this.confirm_password_textbox.Size = new System.Drawing.Size(324, 26);
            this.confirm_password_textbox.TabIndex = 90;
            this.confirm_password_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.confirm_password_textbox.UseSystemPasswordChar = true;
            // 
            // register_button
            // 
            this.register_button.Animated = true;
            this.register_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.register_button.CheckedState.Parent = this.register_button;
            this.register_button.CustomImages.Parent = this.register_button;
            this.register_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.register_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_button.ForeColor = System.Drawing.Color.White;
            this.register_button.HoverState.Parent = this.register_button;
            this.register_button.Location = new System.Drawing.Point(186, 176);
            this.register_button.Name = "register_button";
            this.register_button.ShadowDecoration.Parent = this.register_button;
            this.register_button.Size = new System.Drawing.Size(324, 25);
            this.register_button.TabIndex = 91;
            this.register_button.Text = "Register";
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 25);
            this.label1.TabIndex = 86;
            this.label1.Text = "Welcome! Please register a account for your server.";
            // 
            // Register_Server_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(519, 211);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.confirm_password_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label70);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.form_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register_Server_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Register_Server_Form_Load);
            this.form_header.ResumeLayout(false);
            this.form_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm borderless_control;
        private System.Windows.Forms.Panel form_header;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label header_title_label;
        private System.Windows.Forms.Label label70;
        private Guna.UI2.WinForms.Guna2TextBox username_textbox;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox password_textbox;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox confirm_password_textbox;
        private Guna.UI2.WinForms.Guna2Button register_button;
        private System.Windows.Forms.Label label1;
    }
}