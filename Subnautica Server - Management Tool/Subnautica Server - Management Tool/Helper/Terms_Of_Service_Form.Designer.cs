
namespace Subnautica_Server___Management_Tool.Helper
{
    partial class Terms_Of_Service_Form
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.welcome_label = new System.Windows.Forms.Label();
            this.accept_button = new Guna.UI2.WinForms.Guna2Button();
            this.decline_button = new Guna.UI2.WinForms.Guna2Button();
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
            this.form_header.Size = new System.Drawing.Size(923, 33);
            this.form_header.TabIndex = 8;
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
            this.guna2ControlBox2.Location = new System.Drawing.Point(833, 0);
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
            this.guna2ControlBox1.Location = new System.Drawing.Point(878, 0);
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
            this.header_title_label.Size = new System.Drawing.Size(268, 18);
            this.header_title_label.TabIndex = 1;
            this.header_title_label.Text = "Subnautica Server - Terms Of Service";
            this.header_title_label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_title_label_MouseDown);
            this.header_title_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.header_title_label_MouseMove);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(17, 64);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(894, 343);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.welcome_label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_label.Location = new System.Drawing.Point(12, 36);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(94, 25);
            this.welcome_label.TabIndex = 87;
            this.welcome_label.Text = "Welcome,";
            // 
            // accept_button
            // 
            this.accept_button.Animated = true;
            this.accept_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.accept_button.CheckedState.Parent = this.accept_button;
            this.accept_button.CustomImages.Parent = this.accept_button;
            this.accept_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.accept_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accept_button.ForeColor = System.Drawing.Color.White;
            this.accept_button.HoverState.Parent = this.accept_button;
            this.accept_button.Location = new System.Drawing.Point(738, 413);
            this.accept_button.Name = "accept_button";
            this.accept_button.ShadowDecoration.Parent = this.accept_button;
            this.accept_button.Size = new System.Drawing.Size(173, 25);
            this.accept_button.TabIndex = 92;
            this.accept_button.Text = "Acceppt";
            this.accept_button.Click += new System.EventHandler(this.accept_button_Click);
            // 
            // decline_button
            // 
            this.decline_button.Animated = true;
            this.decline_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.decline_button.CheckedState.Parent = this.decline_button;
            this.decline_button.CustomImages.Parent = this.decline_button;
            this.decline_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.decline_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decline_button.ForeColor = System.Drawing.Color.White;
            this.decline_button.HoverState.Parent = this.decline_button;
            this.decline_button.Location = new System.Drawing.Point(559, 413);
            this.decline_button.Name = "decline_button";
            this.decline_button.ShadowDecoration.Parent = this.decline_button;
            this.decline_button.Size = new System.Drawing.Size(173, 25);
            this.decline_button.TabIndex = 93;
            this.decline_button.Text = "Decline";
            this.decline_button.Click += new System.EventHandler(this.decline_button_Click);
            // 
            // Terms_Of_Service_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(923, 450);
            this.Controls.Add(this.decline_button);
            this.Controls.Add(this.accept_button);
            this.Controls.Add(this.welcome_label);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.form_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Terms_Of_Service_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Terms_Of_Service_Form";
            this.Load += new System.EventHandler(this.Terms_Of_Service_Form_Load);
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
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label welcome_label;
        private Guna.UI2.WinForms.Guna2Button decline_button;
        private Guna.UI2.WinForms.Guna2Button accept_button;
    }
}