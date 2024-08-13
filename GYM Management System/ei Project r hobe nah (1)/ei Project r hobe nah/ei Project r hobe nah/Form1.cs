using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ei_Project_r_hobe_nah
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Boolean b = true;
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            {
                if (b == true)
                {
                    menuStrip1.Dock = DockStyle.Left;
                    b = false;
                    toolStripMenuItem1.Image = Image.FromFile(@"C:\Users\UseR\Desktop\New folder (4)\New folder (3)\img2.jpg");
                }
                else
                {
                    menuStrip1.Dock = DockStyle.Top;
                    b = true;
                    toolStripMenuItem1.Image = Image.FromFile(@"C:\Users\UseR\Desktop\New folder (4)\New folder (3)\img1.jpg");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewMember nm = new NewMember();
            nm.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Logout !! Confirm?", "Log Out", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
                Login lg = new Login();
                lg.Show();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will close your application. Confirm ?", "CLOSE", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Welcome Back", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void newStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewStaff ns = new NewStaff();
            ns.Show();
        }

        private void equipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipment eq = new Equipment();
            eq.Show();
        }

        private void deleteMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void searchMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void gYMMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchMember sm = new SearchMember();
            sm.Show();
        }

        private void gYMStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchGymStaff sgs = new SearchGymStaff();
            sgs.Show();
        }

        private void gYMMemberToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteMember dm = new DeleteMember();
            dm.Show();
        }

        private void gYMStaffToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteGymStaff dgs = new DeleteGymStaff();
            dgs.Show();
        }
    }
}
