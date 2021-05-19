using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Noten
{
    public partial class Noten : Form
    {
        public Noten()
        {
            InitializeComponent();
            customizeDesign();

        }
        private void customizeDesign()
        {
            panelSubMenu0.Visible = false;
            panelSubMenu1.Visible = false;
            panelSubMenu2.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelSubMenu0.Visible == true)
                panelSubMenu0.Visible = false;
            if (panelSubMenu1.Visible == true)
                panelSubMenu1.Visible = false;
            if (panelSubMenu2.Visible == true)
                panelSubMenu2.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false){
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Semesterdaten_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenu0);
        }

        private void Notenperiode_Click(object sender, EventArgs e)
        {
            
        }

        private void Studenten_Click(object sender, EventArgs e)
        {
            
        }

        private void Firmendaten_Click(object sender, EventArgs e)
        {
            
        }

        private void Schnellerfassung_Click(object sender, EventArgs e)
        {
            
        }

        private void Anreden_Click(object sender, EventArgs e)
        {
            stammdaten_anreden.Show();
            mainScreen.Hide();

        }

        private void Berufe_Click(object sender, EventArgs e)
        {
            mainScreen.Hide();
            Form form1 = new Form();
            form1.Location = new Point(100, 100);
  
            // Create two buttons to useas the accept and cancel buttons.
            Button button1 = new Button();
            Button button2 = new Button();
                        // Set the text of button1 to "OK".
            button1.Text = "OK";
            // Set the position of the button on the form.
            button1.Location = new Point(10, 10);
            // Set the text of button2 to "Cancel".
            button2.Text = "Abbrechen";
            // Set the position of the button based on the location of button1.
            button2.Location
               = new Point(button1.Left, button1.Height + button1.Top + 10);
            // Set the caption bar text of the form.   
            form1.Text = "Berufe";
            // Display a help button on the form.
            form1.MdiParent =  this;
            //form1.TopMost = true;
            //form1.ControlBox = false;
            //form1.AutoSize = true;
            //form1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            form1.FormBorderStyle = FormBorderStyle.None;
            form1.WindowState = FormWindowState.Maximized;

            // Define the border style of the form to a dialog box.
            // form1.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Set the MaximizeBox to false to remove the maximize box.
            form1.MaximizeBox = false;
            form1.MinimizeBox = false;
            form1.AcceptButton = button1;
            form1.CancelButton = button2;
            form1.StartPosition = FormStartPosition.CenterScreen;

            // Add button1 to the form.
            form1.Controls.Add(button1);
            // Add button2 to the form.
            form1.Controls.Add(button2);

            // Display the form as a modal dialog box.
            form1.Show();
        }

        private void Fächer_Click(object sender, EventArgs e)
        {
            
        }

        private void Klassen_Click(object sender, EventArgs e)
        {
            
        }

        private void Schulperioden_Click(object sender, EventArgs e)
        {
            
        }

        private void Adressen_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenu1);
        }

        private void Stammdaten_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenu2);
        }
        private Form activeForm = null;
        private void openContainer(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mainScreen.Show();
        }

        private void Notendaten_Click(object sender, EventArgs e)
        {
            mainScreen.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void stammdaten_anreden_Paint(object sender, PaintEventArgs e)
        {

        }

        private void stammdaten_berufe_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
