
namespace Subnautica_Server___Management_Tool
{
    partial class Main_Form
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.borderless_control = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.form_header = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.header_title_label = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.settings_save_button = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.game_settings_reset_default_button = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.game_settings_default_infection_value_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.game_settings_default_max_oxygen_value_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.game_settings_gamemode_combobox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.game_settings_default_health_value_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.game_settings_default_thirst_value_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.game_settings_default_oxygen_value_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.game_settings_default_hunger_value_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.server_settings_admin_password_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.server_settings_server_password_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.overview_port_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.overview_hostname_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.header_menu = new System.Windows.Forms.MenuStrip();
            this.refresh_settings_toolstrip_button = new System.Windows.Forms.ToolStripMenuItem();
            this.form_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.header_menu.SuspendLayout();
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
            this.form_header.Size = new System.Drawing.Size(1093, 33);
            this.form_header.TabIndex = 5;
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
            this.guna2ControlBox2.Location = new System.Drawing.Point(1003, 0);
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
            this.guna2ControlBox1.Location = new System.Drawing.Point(1048, 0);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1070, 496);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.settings_save_button);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1062, 462);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Overview";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // settings_save_button
            // 
            this.settings_save_button.Animated = true;
            this.settings_save_button.CheckedState.Parent = this.settings_save_button;
            this.settings_save_button.CustomImages.Parent = this.settings_save_button;
            this.settings_save_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.settings_save_button.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings_save_button.ForeColor = System.Drawing.Color.White;
            this.settings_save_button.HoverState.Parent = this.settings_save_button;
            this.settings_save_button.Location = new System.Drawing.Point(6, 419);
            this.settings_save_button.Name = "settings_save_button";
            this.settings_save_button.ShadowDecoration.Parent = this.settings_save_button;
            this.settings_save_button.Size = new System.Drawing.Size(1050, 37);
            this.settings_save_button.TabIndex = 109;
            this.settings_save_button.Text = "Apply Settings && Restart Server";
            this.settings_save_button.Click += new System.EventHandler(this.settings_save_button_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.game_settings_reset_default_button);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.game_settings_default_infection_value_textbox);
            this.groupBox3.Controls.Add(this.game_settings_default_max_oxygen_value_textbox);
            this.groupBox3.Controls.Add(this.game_settings_gamemode_combobox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.game_settings_default_health_value_textbox);
            this.groupBox3.Controls.Add(this.game_settings_default_thirst_value_textbox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.game_settings_default_oxygen_value_textbox);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.game_settings_default_hunger_value_textbox);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 117);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(596, 296);
            this.groupBox3.TabIndex = 109;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Game Settings";
            // 
            // game_settings_reset_default_button
            // 
            this.game_settings_reset_default_button.Animated = true;
            this.game_settings_reset_default_button.CheckedState.Parent = this.game_settings_reset_default_button;
            this.game_settings_reset_default_button.CustomImages.Parent = this.game_settings_reset_default_button;
            this.game_settings_reset_default_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.game_settings_reset_default_button.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game_settings_reset_default_button.ForeColor = System.Drawing.Color.White;
            this.game_settings_reset_default_button.HoverState.Parent = this.game_settings_reset_default_button;
            this.game_settings_reset_default_button.Location = new System.Drawing.Point(359, 257);
            this.game_settings_reset_default_button.Name = "game_settings_reset_default_button";
            this.game_settings_reset_default_button.ShadowDecoration.Parent = this.game_settings_reset_default_button;
            this.game_settings_reset_default_button.Size = new System.Drawing.Size(216, 26);
            this.game_settings_reset_default_button.TabIndex = 110;
            this.game_settings_reset_default_button.Text = "Reset Default Settings";
            this.game_settings_reset_default_button.Click += new System.EventHandler(this.game_settings_reset_default_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 25);
            this.label5.TabIndex = 88;
            this.label5.Text = "Default Oxygen Value:";
            // 
            // game_settings_default_infection_value_textbox
            // 
            this.game_settings_default_infection_value_textbox.Animated = true;
            this.game_settings_default_infection_value_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.game_settings_default_infection_value_textbox.DefaultText = "";
            this.game_settings_default_infection_value_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.game_settings_default_infection_value_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.game_settings_default_infection_value_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.game_settings_default_infection_value_textbox.DisabledState.Parent = this.game_settings_default_infection_value_textbox;
            this.game_settings_default_infection_value_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.game_settings_default_infection_value_textbox.Enabled = false;
            this.game_settings_default_infection_value_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.game_settings_default_infection_value_textbox.FocusedState.Parent = this.game_settings_default_infection_value_textbox;
            this.game_settings_default_infection_value_textbox.Font = new System.Drawing.Font("Arial", 9.75F);
            this.game_settings_default_infection_value_textbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.game_settings_default_infection_value_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.game_settings_default_infection_value_textbox.HoverState.Parent = this.game_settings_default_infection_value_textbox;
            this.game_settings_default_infection_value_textbox.Location = new System.Drawing.Point(251, 225);
            this.game_settings_default_infection_value_textbox.Name = "game_settings_default_infection_value_textbox";
            this.game_settings_default_infection_value_textbox.PasswordChar = '\0';
            this.game_settings_default_infection_value_textbox.PlaceholderText = "";
            this.game_settings_default_infection_value_textbox.SelectedText = "";
            this.game_settings_default_infection_value_textbox.ShadowDecoration.Parent = this.game_settings_default_infection_value_textbox;
            this.game_settings_default_infection_value_textbox.Size = new System.Drawing.Size(324, 26);
            this.game_settings_default_infection_value_textbox.TabIndex = 108;
            this.game_settings_default_infection_value_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // game_settings_default_max_oxygen_value_textbox
            // 
            this.game_settings_default_max_oxygen_value_textbox.Animated = true;
            this.game_settings_default_max_oxygen_value_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.game_settings_default_max_oxygen_value_textbox.DefaultText = "";
            this.game_settings_default_max_oxygen_value_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.game_settings_default_max_oxygen_value_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.game_settings_default_max_oxygen_value_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.game_settings_default_max_oxygen_value_textbox.DisabledState.Parent = this.game_settings_default_max_oxygen_value_textbox;
            this.game_settings_default_max_oxygen_value_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.game_settings_default_max_oxygen_value_textbox.Enabled = false;
            this.game_settings_default_max_oxygen_value_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.game_settings_default_max_oxygen_value_textbox.FocusedState.Parent = this.game_settings_default_max_oxygen_value_textbox;
            this.game_settings_default_max_oxygen_value_textbox.Font = new System.Drawing.Font("Arial", 9.75F);
            this.game_settings_default_max_oxygen_value_textbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.game_settings_default_max_oxygen_value_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.game_settings_default_max_oxygen_value_textbox.HoverState.Parent = this.game_settings_default_max_oxygen_value_textbox;
            this.game_settings_default_max_oxygen_value_textbox.Location = new System.Drawing.Point(251, 97);
            this.game_settings_default_max_oxygen_value_textbox.Name = "game_settings_default_max_oxygen_value_textbox";
            this.game_settings_default_max_oxygen_value_textbox.PasswordChar = '\0';
            this.game_settings_default_max_oxygen_value_textbox.PlaceholderText = "";
            this.game_settings_default_max_oxygen_value_textbox.SelectedText = "";
            this.game_settings_default_max_oxygen_value_textbox.ShadowDecoration.Parent = this.game_settings_default_max_oxygen_value_textbox;
            this.game_settings_default_max_oxygen_value_textbox.Size = new System.Drawing.Size(324, 26);
            this.game_settings_default_max_oxygen_value_textbox.TabIndex = 91;
            this.game_settings_default_max_oxygen_value_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // game_settings_gamemode_combobox
            // 
            this.game_settings_gamemode_combobox.Animated = true;
            this.game_settings_gamemode_combobox.BackColor = System.Drawing.Color.Transparent;
            this.game_settings_gamemode_combobox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.game_settings_gamemode_combobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.game_settings_gamemode_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.game_settings_gamemode_combobox.FillColor = System.Drawing.Color.WhiteSmoke;
            this.game_settings_gamemode_combobox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.game_settings_gamemode_combobox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.game_settings_gamemode_combobox.FocusedState.Parent = this.game_settings_gamemode_combobox;
            this.game_settings_gamemode_combobox.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.game_settings_gamemode_combobox.ForeColor = System.Drawing.Color.Black;
            this.game_settings_gamemode_combobox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.game_settings_gamemode_combobox.HoverState.Parent = this.game_settings_gamemode_combobox;
            this.game_settings_gamemode_combobox.IntegralHeight = false;
            this.game_settings_gamemode_combobox.ItemHeight = 20;
            this.game_settings_gamemode_combobox.Items.AddRange(new object[] {
            "SURVIVAL",
            "FREEDOM",
            "HARDCORE",
            "CREATIVE"});
            this.game_settings_gamemode_combobox.ItemsAppearance.Parent = this.game_settings_gamemode_combobox;
            this.game_settings_gamemode_combobox.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.game_settings_gamemode_combobox.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.game_settings_gamemode_combobox.Location = new System.Drawing.Point(251, 33);
            this.game_settings_gamemode_combobox.Name = "game_settings_gamemode_combobox";
            this.game_settings_gamemode_combobox.ShadowDecoration.Parent = this.game_settings_gamemode_combobox;
            this.game_settings_gamemode_combobox.Size = new System.Drawing.Size(324, 26);
            this.game_settings_gamemode_combobox.StartIndex = 0;
            this.game_settings_gamemode_combobox.TabIndex = 100;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(126, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 25);
            this.label4.TabIndex = 86;
            this.label4.Text = "Game Mode:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(56, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 25);
            this.label8.TabIndex = 101;
            this.label8.Text = "Default Health Value:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(37, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(208, 25);
            this.label10.TabIndex = 107;
            this.label10.Text = "Default Infection Value:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 25);
            this.label6.TabIndex = 90;
            this.label6.Text = "Default Max Oxygen Value:";
            // 
            // game_settings_default_health_value_textbox
            // 
            this.game_settings_default_health_value_textbox.Animated = true;
            this.game_settings_default_health_value_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.game_settings_default_health_value_textbox.DefaultText = "";
            this.game_settings_default_health_value_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.game_settings_default_health_value_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.game_settings_default_health_value_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.game_settings_default_health_value_textbox.DisabledState.Parent = this.game_settings_default_health_value_textbox;
            this.game_settings_default_health_value_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.game_settings_default_health_value_textbox.Enabled = false;
            this.game_settings_default_health_value_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.game_settings_default_health_value_textbox.FocusedState.Parent = this.game_settings_default_health_value_textbox;
            this.game_settings_default_health_value_textbox.Font = new System.Drawing.Font("Arial", 9.75F);
            this.game_settings_default_health_value_textbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.game_settings_default_health_value_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.game_settings_default_health_value_textbox.HoverState.Parent = this.game_settings_default_health_value_textbox;
            this.game_settings_default_health_value_textbox.Location = new System.Drawing.Point(251, 129);
            this.game_settings_default_health_value_textbox.Name = "game_settings_default_health_value_textbox";
            this.game_settings_default_health_value_textbox.PasswordChar = '\0';
            this.game_settings_default_health_value_textbox.PlaceholderText = "";
            this.game_settings_default_health_value_textbox.SelectedText = "";
            this.game_settings_default_health_value_textbox.ShadowDecoration.Parent = this.game_settings_default_health_value_textbox;
            this.game_settings_default_health_value_textbox.Size = new System.Drawing.Size(324, 26);
            this.game_settings_default_health_value_textbox.TabIndex = 102;
            this.game_settings_default_health_value_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // game_settings_default_thirst_value_textbox
            // 
            this.game_settings_default_thirst_value_textbox.Animated = true;
            this.game_settings_default_thirst_value_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.game_settings_default_thirst_value_textbox.DefaultText = "";
            this.game_settings_default_thirst_value_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.game_settings_default_thirst_value_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.game_settings_default_thirst_value_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.game_settings_default_thirst_value_textbox.DisabledState.Parent = this.game_settings_default_thirst_value_textbox;
            this.game_settings_default_thirst_value_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.game_settings_default_thirst_value_textbox.Enabled = false;
            this.game_settings_default_thirst_value_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.game_settings_default_thirst_value_textbox.FocusedState.Parent = this.game_settings_default_thirst_value_textbox;
            this.game_settings_default_thirst_value_textbox.Font = new System.Drawing.Font("Arial", 9.75F);
            this.game_settings_default_thirst_value_textbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.game_settings_default_thirst_value_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.game_settings_default_thirst_value_textbox.HoverState.Parent = this.game_settings_default_thirst_value_textbox;
            this.game_settings_default_thirst_value_textbox.Location = new System.Drawing.Point(251, 193);
            this.game_settings_default_thirst_value_textbox.Name = "game_settings_default_thirst_value_textbox";
            this.game_settings_default_thirst_value_textbox.PasswordChar = '\0';
            this.game_settings_default_thirst_value_textbox.PlaceholderText = "";
            this.game_settings_default_thirst_value_textbox.SelectedText = "";
            this.game_settings_default_thirst_value_textbox.ShadowDecoration.Parent = this.game_settings_default_thirst_value_textbox;
            this.game_settings_default_thirst_value_textbox.Size = new System.Drawing.Size(324, 26);
            this.game_settings_default_thirst_value_textbox.TabIndex = 106;
            this.game_settings_default_thirst_value_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 25);
            this.label7.TabIndex = 103;
            this.label7.Text = "Default Hunger Value:";
            // 
            // game_settings_default_oxygen_value_textbox
            // 
            this.game_settings_default_oxygen_value_textbox.Animated = true;
            this.game_settings_default_oxygen_value_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.game_settings_default_oxygen_value_textbox.DefaultText = "";
            this.game_settings_default_oxygen_value_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.game_settings_default_oxygen_value_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.game_settings_default_oxygen_value_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.game_settings_default_oxygen_value_textbox.DisabledState.Parent = this.game_settings_default_oxygen_value_textbox;
            this.game_settings_default_oxygen_value_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.game_settings_default_oxygen_value_textbox.Enabled = false;
            this.game_settings_default_oxygen_value_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.game_settings_default_oxygen_value_textbox.FocusedState.Parent = this.game_settings_default_oxygen_value_textbox;
            this.game_settings_default_oxygen_value_textbox.Font = new System.Drawing.Font("Arial", 9.75F);
            this.game_settings_default_oxygen_value_textbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.game_settings_default_oxygen_value_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.game_settings_default_oxygen_value_textbox.HoverState.Parent = this.game_settings_default_oxygen_value_textbox;
            this.game_settings_default_oxygen_value_textbox.Location = new System.Drawing.Point(251, 65);
            this.game_settings_default_oxygen_value_textbox.Name = "game_settings_default_oxygen_value_textbox";
            this.game_settings_default_oxygen_value_textbox.PasswordChar = '\0';
            this.game_settings_default_oxygen_value_textbox.PlaceholderText = "";
            this.game_settings_default_oxygen_value_textbox.SelectedText = "";
            this.game_settings_default_oxygen_value_textbox.ShadowDecoration.Parent = this.game_settings_default_oxygen_value_textbox;
            this.game_settings_default_oxygen_value_textbox.Size = new System.Drawing.Size(324, 26);
            this.game_settings_default_oxygen_value_textbox.TabIndex = 89;
            this.game_settings_default_oxygen_value_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(64, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 25);
            this.label9.TabIndex = 105;
            this.label9.Text = "Default Thirst Value:";
            // 
            // game_settings_default_hunger_value_textbox
            // 
            this.game_settings_default_hunger_value_textbox.Animated = true;
            this.game_settings_default_hunger_value_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.game_settings_default_hunger_value_textbox.DefaultText = "";
            this.game_settings_default_hunger_value_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.game_settings_default_hunger_value_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.game_settings_default_hunger_value_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.game_settings_default_hunger_value_textbox.DisabledState.Parent = this.game_settings_default_hunger_value_textbox;
            this.game_settings_default_hunger_value_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.game_settings_default_hunger_value_textbox.Enabled = false;
            this.game_settings_default_hunger_value_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.game_settings_default_hunger_value_textbox.FocusedState.Parent = this.game_settings_default_hunger_value_textbox;
            this.game_settings_default_hunger_value_textbox.Font = new System.Drawing.Font("Arial", 9.75F);
            this.game_settings_default_hunger_value_textbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.game_settings_default_hunger_value_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.game_settings_default_hunger_value_textbox.HoverState.Parent = this.game_settings_default_hunger_value_textbox;
            this.game_settings_default_hunger_value_textbox.Location = new System.Drawing.Point(251, 161);
            this.game_settings_default_hunger_value_textbox.Name = "game_settings_default_hunger_value_textbox";
            this.game_settings_default_hunger_value_textbox.PasswordChar = '\0';
            this.game_settings_default_hunger_value_textbox.PlaceholderText = "";
            this.game_settings_default_hunger_value_textbox.SelectedText = "";
            this.game_settings_default_hunger_value_textbox.ShadowDecoration.Parent = this.game_settings_default_hunger_value_textbox;
            this.game_settings_default_hunger_value_textbox.Size = new System.Drawing.Size(324, 26);
            this.game_settings_default_hunger_value_textbox.TabIndex = 104;
            this.game_settings_default_hunger_value_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.server_settings_admin_password_textbox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.server_settings_server_password_textbox);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(540, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(516, 105);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server Settings";
            // 
            // server_settings_admin_password_textbox
            // 
            this.server_settings_admin_password_textbox.Animated = true;
            this.server_settings_admin_password_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.server_settings_admin_password_textbox.DefaultText = "";
            this.server_settings_admin_password_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.server_settings_admin_password_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.server_settings_admin_password_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.server_settings_admin_password_textbox.DisabledState.Parent = this.server_settings_admin_password_textbox;
            this.server_settings_admin_password_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.server_settings_admin_password_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.server_settings_admin_password_textbox.FocusedState.Parent = this.server_settings_admin_password_textbox;
            this.server_settings_admin_password_textbox.Font = new System.Drawing.Font("Arial", 9.75F);
            this.server_settings_admin_password_textbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.server_settings_admin_password_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.server_settings_admin_password_textbox.HoverState.Parent = this.server_settings_admin_password_textbox;
            this.server_settings_admin_password_textbox.Location = new System.Drawing.Point(170, 64);
            this.server_settings_admin_password_textbox.Name = "server_settings_admin_password_textbox";
            this.server_settings_admin_password_textbox.PasswordChar = '\0';
            this.server_settings_admin_password_textbox.PlaceholderText = "";
            this.server_settings_admin_password_textbox.SelectedText = "";
            this.server_settings_admin_password_textbox.ShadowDecoration.Parent = this.server_settings_admin_password_textbox;
            this.server_settings_admin_password_textbox.Size = new System.Drawing.Size(324, 26);
            this.server_settings_admin_password_textbox.TabIndex = 85;
            this.server_settings_admin_password_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 84;
            this.label1.Text = "Admin Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 82;
            this.label3.Text = "Server Password:";
            // 
            // server_settings_server_password_textbox
            // 
            this.server_settings_server_password_textbox.Animated = true;
            this.server_settings_server_password_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.server_settings_server_password_textbox.DefaultText = "";
            this.server_settings_server_password_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.server_settings_server_password_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.server_settings_server_password_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.server_settings_server_password_textbox.DisabledState.Parent = this.server_settings_server_password_textbox;
            this.server_settings_server_password_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.server_settings_server_password_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.server_settings_server_password_textbox.FocusedState.Parent = this.server_settings_server_password_textbox;
            this.server_settings_server_password_textbox.Font = new System.Drawing.Font("Arial", 9.75F);
            this.server_settings_server_password_textbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.server_settings_server_password_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.server_settings_server_password_textbox.HoverState.Parent = this.server_settings_server_password_textbox;
            this.server_settings_server_password_textbox.Location = new System.Drawing.Point(170, 32);
            this.server_settings_server_password_textbox.Name = "server_settings_server_password_textbox";
            this.server_settings_server_password_textbox.PasswordChar = '\0';
            this.server_settings_server_password_textbox.PlaceholderText = "";
            this.server_settings_server_password_textbox.SelectedText = "";
            this.server_settings_server_password_textbox.ShadowDecoration.Parent = this.server_settings_server_password_textbox;
            this.server_settings_server_password_textbox.Size = new System.Drawing.Size(324, 26);
            this.server_settings_server_password_textbox.TabIndex = 83;
            this.server_settings_server_password_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.overview_port_textbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label70);
            this.groupBox1.Controls.Add(this.overview_hostname_textbox);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection Details";
            // 
            // overview_port_textbox
            // 
            this.overview_port_textbox.Animated = true;
            this.overview_port_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.overview_port_textbox.DefaultText = "";
            this.overview_port_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.overview_port_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.overview_port_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.overview_port_textbox.DisabledState.Parent = this.overview_port_textbox;
            this.overview_port_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.overview_port_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.overview_port_textbox.FocusedState.Parent = this.overview_port_textbox;
            this.overview_port_textbox.Font = new System.Drawing.Font("Arial", 9.75F);
            this.overview_port_textbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.overview_port_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.overview_port_textbox.HoverState.Parent = this.overview_port_textbox;
            this.overview_port_textbox.Location = new System.Drawing.Point(182, 64);
            this.overview_port_textbox.Name = "overview_port_textbox";
            this.overview_port_textbox.PasswordChar = '\0';
            this.overview_port_textbox.PlaceholderText = "";
            this.overview_port_textbox.ReadOnly = true;
            this.overview_port_textbox.SelectedText = "";
            this.overview_port_textbox.ShadowDecoration.Parent = this.overview_port_textbox;
            this.overview_port_textbox.Size = new System.Drawing.Size(324, 26);
            this.overview_port_textbox.TabIndex = 85;
            this.overview_port_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 84;
            this.label2.Text = "Server Port:";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label70.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label70.Location = new System.Drawing.Point(17, 29);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(159, 25);
            this.label70.TabIndex = 82;
            this.label70.Text = "Server Hostname:";
            // 
            // overview_hostname_textbox
            // 
            this.overview_hostname_textbox.Animated = true;
            this.overview_hostname_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.overview_hostname_textbox.DefaultText = "";
            this.overview_hostname_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.overview_hostname_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.overview_hostname_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.overview_hostname_textbox.DisabledState.Parent = this.overview_hostname_textbox;
            this.overview_hostname_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.overview_hostname_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.overview_hostname_textbox.FocusedState.Parent = this.overview_hostname_textbox;
            this.overview_hostname_textbox.Font = new System.Drawing.Font("Arial", 9.75F);
            this.overview_hostname_textbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.overview_hostname_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(153)))), ((int)(((byte)(226)))));
            this.overview_hostname_textbox.HoverState.Parent = this.overview_hostname_textbox;
            this.overview_hostname_textbox.Location = new System.Drawing.Point(182, 32);
            this.overview_hostname_textbox.Name = "overview_hostname_textbox";
            this.overview_hostname_textbox.PasswordChar = '\0';
            this.overview_hostname_textbox.PlaceholderText = "";
            this.overview_hostname_textbox.ReadOnly = true;
            this.overview_hostname_textbox.SelectedText = "";
            this.overview_hostname_textbox.ShadowDecoration.Parent = this.overview_hostname_textbox;
            this.overview_hostname_textbox.Size = new System.Drawing.Size(324, 26);
            this.overview_hostname_textbox.TabIndex = 83;
            this.overview_hostname_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // header_menu
            // 
            this.header_menu.Dock = System.Windows.Forms.DockStyle.None;
            this.header_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refresh_settings_toolstrip_button});
            this.header_menu.Location = new System.Drawing.Point(9, 36);
            this.header_menu.Name = "header_menu";
            this.header_menu.Size = new System.Drawing.Size(186, 24);
            this.header_menu.TabIndex = 7;
            this.header_menu.Text = "menuStrip1";
            // 
            // refresh_settings_toolstrip_button
            // 
            this.refresh_settings_toolstrip_button.Name = "refresh_settings_toolstrip_button";
            this.refresh_settings_toolstrip_button.Size = new System.Drawing.Size(58, 20);
            this.refresh_settings_toolstrip_button.Text = "Refresh";
            this.refresh_settings_toolstrip_button.Click += new System.EventHandler(this.refresh_settings_toolstrip_button_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1093, 570);
            this.Controls.Add(this.header_menu);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.form_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subnautica Server - Management Tool";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.form_header.ResumeLayout(false);
            this.form_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.header_menu.ResumeLayout(false);
            this.header_menu.PerformLayout();
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label70;
        private Guna.UI2.WinForms.Guna2TextBox overview_hostname_textbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TextBox overview_port_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2ComboBox game_settings_gamemode_combobox;
        private Guna.UI2.WinForms.Guna2TextBox game_settings_default_max_oxygen_value_textbox;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox game_settings_default_oxygen_value_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox server_settings_admin_password_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox server_settings_server_password_textbox;
        private Guna.UI2.WinForms.Guna2TextBox game_settings_default_infection_value_textbox;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox game_settings_default_thirst_value_textbox;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox game_settings_default_hunger_value_textbox;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox game_settings_default_health_value_textbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private Guna.UI2.WinForms.Guna2Button settings_save_button;
        private System.Windows.Forms.MenuStrip header_menu;
        private System.Windows.Forms.ToolStripMenuItem refresh_settings_toolstrip_button;
        private Guna.UI2.WinForms.Guna2Button game_settings_reset_default_button;
    }
}

