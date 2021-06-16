using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using RestSharp;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class Form1 : Form
    {
<<<<<<< HEAD
        public int loginStatus { get; set; }
=======
>>>>>>> 07a99eb1028bb6de68a34fd7971f7938737a4ecb
        public Form1()
        {
            InitializeComponent();
            hideSubMenu();
<<<<<<< HEAD
            loginStatus = 3;
            openChildForm(new Login());
            loginStatus = 0;
=======
>>>>>>> 07a99eb1028bb6de68a34fd7971f7938737a4ecb
        }

        private void hideSubMenu()
        {
            // panelMediaSubMenu.Visible = false;
            panelPlaylistSubMenu.Visible = false;
            panelToolsSubMenu.Visible = false;
            panel1.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
           // showSubMenu(panelMediaSubMenu);
        }

        #region MediaSubMenu
        private void button2_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            openChildForm(new Form2("Lehrling"));
=======
            openChildForm(new Form2());
            //..
            //your codes
            //..
>>>>>>> 07a99eb1028bb6de68a34fd7971f7938737a4ecb
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubMenu);
        }

        #region PlayListManagemetSubMenu
        private void button8_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            openChildForm(new Form2("Lehrzeiten"));
=======
            //..
            //your codes
            //..
>>>>>>> 07a99eb1028bb6de68a34fd7971f7938737a4ecb
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panelToolsSubMenu);
        }
        #region ToolsSubMenu
        private void button13_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            openChildForm(new Form2("Firma"));
=======
            //..
            //your codes
            //..
>>>>>>> 07a99eb1028bb6de68a34fd7971f7938737a4ecb
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            //openChildForm(new Form3());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            openChildForm(new Form2("Noten"));
=======
            //..
            //your codes
            //..
>>>>>>> 07a99eb1028bb6de68a34fd7971f7938737a4ecb
            hideSubMenu();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
<<<<<<< HEAD
            if (loginStatus == 1 || loginStatus == 2 || loginStatus == 3)
            {
                if (activeForm != null) activeForm.Close();
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelChildForm.Controls.Add(childForm);
                panelChildForm.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
=======
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
>>>>>>> 07a99eb1028bb6de68a34fd7971f7938737a4ecb
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panel1);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            openChildForm(new Form2("Anrede"));
=======
>>>>>>> 07a99eb1028bb6de68a34fd7971f7938737a4ecb
            hideSubMenu();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            openChildForm(new Form2("Beruf"));
=======
            openChildForm(new Form2());
>>>>>>> 07a99eb1028bb6de68a34fd7971f7938737a4ecb

            hideSubMenu();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            openChildForm(new Form2("Faecher"));
=======
>>>>>>> 07a99eb1028bb6de68a34fd7971f7938737a4ecb
            hideSubMenu();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            openChildForm(new Form2("Klasse"));
=======
>>>>>>> 07a99eb1028bb6de68a34fd7971f7938737a4ecb
            hideSubMenu();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            openChildForm(new Form2("Ort"));
=======
>>>>>>> 07a99eb1028bb6de68a34fd7971f7938737a4ecb
            hideSubMenu();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            openChildForm(new Form2("Lehrzeiten"));
            hideSubMenu();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(loginStatus == 2)
            {
                openChildForm(new Form2("Benutzer"));
            }
            else
            {
                MessageBox.Show("Du bist kein Admin, Hau ab!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
=======
            hideSubMenu();
        }
>>>>>>> 07a99eb1028bb6de68a34fd7971f7938737a4ecb
    }
}
