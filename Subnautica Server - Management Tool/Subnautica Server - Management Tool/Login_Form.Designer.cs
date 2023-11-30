
namespace Subnautica_Server___Management_Tool
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.borderless_control = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.form_header = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.header_title_label = new System.Windows.Forms.Label();
            this.password_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.username_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.login_button = new Guna.UI2.WinForms.Guna2Button();
            this.background_picturebox = new System.Windows.Forms.PictureBox();
            this.register_server_button = new Guna.UI2.WinForms.Guna2Button();
            this.contact_label = new System.Windows.Forms.Label();
            this.form_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background_picturebox)).BeginInit();
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
            this.form_header.Size = new System.Drawing.Size(1279, 33);
            this.form_header.TabIndex = 6;
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
            this.guna2ControlBox2.Location = new System.Drawing.Point(1189, 0);
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
            this.guna2ControlBox1.Location = new System.Drawing.Point(1234, 0);
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
            this.header_title_label.Size = new System.Drawing.Size(272, 18);
            this.header_title_label.TabIndex = 1;
            this.header_title_label.Text = "Subnautica Server - Management Tool";
            this.header_title_label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_title_label_MouseDown);
            this.header_title_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.header_title_label_MouseMove);
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
            this.password_textbox.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.password_textbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.password_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.password_textbox.HoverState.Parent = this.password_textbox;
            this.password_textbox.Location = new System.Drawing.Point(441, 328);
            this.password_textbox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '\0';
            this.password_textbox.PlaceholderText = "";
            this.password_textbox.SelectedText = "";
            this.password_textbox.ShadowDecoration.Parent = this.password_textbox;
            this.password_textbox.Size = new System.Drawing.Size(363, 41);
            this.password_textbox.TabIndex = 70;
            this.password_textbox.UseSystemPasswordChar = true;
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
            this.username_textbox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_textbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.username_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.username_textbox.HoverState.Parent = this.username_textbox;
            this.username_textbox.Location = new System.Drawing.Point(441, 281);
            this.username_textbox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.PasswordChar = '\0';
            this.username_textbox.PlaceholderText = "";
            this.username_textbox.SelectedText = "";
            this.username_textbox.ShadowDecoration.Parent = this.username_textbox;
            this.username_textbox.Size = new System.Drawing.Size(363, 41);
            this.username_textbox.TabIndex = 69;
            // 
            // login_button
            // 
            this.login_button.Animated = true;
            this.login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.login_button.CheckedState.Parent = this.login_button;
            this.login_button.CustomImages.Parent = this.login_button;
            this.login_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.login_button.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.login_button.ForeColor = System.Drawing.Color.White;
            this.login_button.HoverState.Parent = this.login_button;
            this.login_button.Location = new System.Drawing.Point(441, 375);
            this.login_button.Name = "login_button";
            this.login_button.ShadowDecoration.Parent = this.login_button;
            this.login_button.Size = new System.Drawing.Size(363, 40);
            this.login_button.TabIndex = 71;
            this.login_button.Text = "Login";
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // background_picturebox
            // 
            this.background_picturebox.Image = global::Subnautica_Server___Management_Tool.Properties.Resources.subnautica;
            this.background_picturebox.Location = new System.Drawing.Point(0, 29);
            this.background_picturebox.Name = "background_picturebox";
            this.background_picturebox.Size = new System.Drawing.Size(1279, 661);
            this.background_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background_picturebox.TabIndex = 72;
            this.background_picturebox.TabStop = false;
            this.background_picturebox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.background_picturebox_MouseDown);
            this.background_picturebox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.background_picturebox_MouseMove);
            // 
            // register_server_button
            // 
            this.register_server_button.Animated = true;
            this.register_server_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.register_server_button.CheckedState.Parent = this.register_server_button;
            this.register_server_button.CustomImages.Parent = this.register_server_button;
            this.register_server_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.register_server_button.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.register_server_button.ForeColor = System.Drawing.Color.White;
            this.register_server_button.HoverState.Parent = this.register_server_button;
            this.register_server_button.Location = new System.Drawing.Point(441, 421);
            this.register_server_button.Name = "register_server_button";
            this.register_server_button.ShadowDecoration.Parent = this.register_server_button;
            this.register_server_button.Size = new System.Drawing.Size(363, 40);
            this.register_server_button.TabIndex = 73;
            this.register_server_button.Text = "Register Server";
            this.register_server_button.Click += new System.EventHandler(this.register_server_button_Click);
            // 
            // contact_label
            // 
            this.contact_label.AutoSize = true;
            this.contact_label.BackColor = System.Drawing.Color.Transparent;
            this.contact_label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.contact_label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_label.ForeColor = System.Drawing.Color.White;
            this.contact_label.Location = new System.Drawing.Point(0, 665);
            this.contact_label.Name = "contact_label";
            this.contact_label.Size = new System.Drawing.Size(115, 25);
            this.contact_label.TabIndex = 74;
            this.contact_label.Text = "Contact Info";
            this.contact_label.Click += new System.EventHandler(this.contact_label_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 690);
            this.Controls.Add(this.contact_label);
            this.Controls.Add(this.register_server_button);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.background_picturebox);
            this.Controls.Add(this.form_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_Form";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            this.form_header.ResumeLayout(false);
            this.form_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background_picturebox)).EndInit();
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
        private Guna.UI2.WinForms.Guna2Button login_button;
        private System.Windows.Forms.PictureBox background_picturebox;
        public Guna.UI2.WinForms.Guna2TextBox password_textbox;
        public Guna.UI2.WinForms.Guna2TextBox username_textbox;
        private Guna.UI2.WinForms.Guna2Button register_server_button;
        private System.Windows.Forms.Label contact_label;
    }
}