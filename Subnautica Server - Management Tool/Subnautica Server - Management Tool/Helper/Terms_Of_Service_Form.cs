using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subnautica_Server___Management_Tool.Helper
{
    public partial class Terms_Of_Service_Form : Form
    {
        //######################################GUI START###############################################

        //GUI Handling
        Point move_window_last_point;

        //Move From if left mouse button clicked on it.
        private void form_header_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - move_window_last_point.X;
                this.Top += e.Y - move_window_last_point.Y;
            }
        }

        //Move Form if header is selected
        private void form_header_MouseDown(object sender, MouseEventArgs e)
        {
            move_window_last_point = new Point(e.X, e.Y);
        }

        private void header_title_label_MouseDown(object sender, MouseEventArgs e)
        {
            move_window_last_point = new Point(e.X, e.Y);
        }

        private void header_title_label_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - move_window_last_point.X;
                this.Top += e.Y - move_window_last_point.Y;
            }
        }

        private void background_picturebox_MouseDown(object sender, MouseEventArgs e)
        {
            move_window_last_point = new Point(e.X, e.Y);
        }

        private void background_picturebox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - move_window_last_point.X;
                this.Top += e.Y - move_window_last_point.Y;
            }
        }

        private void gui_misc_loader()
        {

        }

        public void Alert(string msg, Helper.Form_Alert.enmType type)
        {
            Helper.Form_Alert frm = new Helper.Form_Alert();
            frm.showAlert(msg, type);
        }

        //######################################GUI END###############################################

        public Terms_Of_Service_Form()
        {
            InitializeComponent();
            welcome_label.Text = "Welcome, " + Environment.UserName + "! Please carefully read our tos/rules before you continue and register your server. :-)"; 
        }

        private void Terms_Of_Service_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void decline_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void accept_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var show_form = new Helper.Register_Server_Form();
            show_form.Closed += (s, args) => this.Close();
            show_form.Show();
        }
    }
}
