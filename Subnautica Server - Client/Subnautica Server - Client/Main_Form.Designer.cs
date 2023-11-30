
namespace Subnautica_Server___Client
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
            this.sync_timer = new System.Windows.Forms.Timer(this.components);
            this.users_listbox = new System.Windows.Forms.ListBox();
            this.manual_sync_button = new System.Windows.Forms.Button();
            this.start_servers_button = new System.Windows.Forms.Button();
            this.register_server_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sync_timer
            // 
            this.sync_timer.Enabled = true;
            this.sync_timer.Interval = 60000;
            this.sync_timer.Tick += new System.EventHandler(this.sync_timer_Tick);
            // 
            // users_listbox
            // 
            this.users_listbox.FormattingEnabled = true;
            this.users_listbox.Location = new System.Drawing.Point(200, 12);
            this.users_listbox.Name = "users_listbox";
            this.users_listbox.Size = new System.Drawing.Size(174, 368);
            this.users_listbox.TabIndex = 0;
            // 
            // manual_sync_button
            // 
            this.manual_sync_button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manual_sync_button.Location = new System.Drawing.Point(12, 115);
            this.manual_sync_button.Name = "manual_sync_button";
            this.manual_sync_button.Size = new System.Drawing.Size(182, 150);
            this.manual_sync_button.TabIndex = 1;
            this.manual_sync_button.Text = "Sync Now";
            this.manual_sync_button.UseVisualStyleBackColor = true;
            this.manual_sync_button.Click += new System.EventHandler(this.manual_sync_button_Click);
            // 
            // start_servers_button
            // 
            this.start_servers_button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_servers_button.Location = new System.Drawing.Point(12, 13);
            this.start_servers_button.Name = "start_servers_button";
            this.start_servers_button.Size = new System.Drawing.Size(182, 45);
            this.start_servers_button.TabIndex = 2;
            this.start_servers_button.Text = "Start Servers";
            this.start_servers_button.UseVisualStyleBackColor = true;
            this.start_servers_button.Click += new System.EventHandler(this.start_servers_button_Click);
            // 
            // register_server_button
            // 
            this.register_server_button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_server_button.Location = new System.Drawing.Point(12, 64);
            this.register_server_button.Name = "register_server_button";
            this.register_server_button.Size = new System.Drawing.Size(182, 45);
            this.register_server_button.TabIndex = 3;
            this.register_server_button.Text = "Register Servers";
            this.register_server_button.UseVisualStyleBackColor = true;
            this.register_server_button.Click += new System.EventHandler(this.register_server_button_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 397);
            this.Controls.Add(this.register_server_button);
            this.Controls.Add(this.start_servers_button);
            this.Controls.Add(this.manual_sync_button);
            this.Controls.Add(this.users_listbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subnautica Server - Client";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer sync_timer;
        private System.Windows.Forms.ListBox users_listbox;
        private System.Windows.Forms.Button manual_sync_button;
        private System.Windows.Forms.Button start_servers_button;
        private System.Windows.Forms.Button register_server_button;
    }
}

