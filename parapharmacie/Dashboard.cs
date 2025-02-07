﻿using parapharmacie.Class;
using parapharmacie.usercontrols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parapharmacie
{
    public partial class Dashboard : Form
    {
        public User user = new User();
        public Dashboard(User user)
        {
            this.user = user;
            InitializeComponent();
            this.onInit();
        }

        private void onInit()
        {
            if (this.user.Role.Equals("ADMIN"))
            {
                adduser.Visible = true;
                guna2Button7.Visible = true;
            }
           
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uc_dashboard1.Visible = true;
            uc_dashboard1.BringToFront();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uc_dashboard1.Visible = false;
            ajoutProd1.Visible = false;
            listeProd1.Visible = false;
            validitycheck1.Visible = false;
            modification1.Visible = false;
            listUsers1.Visible = false;
            guna2Button1.PerformClick();
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ajoutProd1.Visible = true;
            ajoutProd1.BringToFront();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            listeProd1.Visible = true;
            listeProd1.BringToFront();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            validitycheck1.Visible = true;
            validitycheck1.BringToFront();
        }

        private void validitycheck1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            vendre1.Visible = true;
            vendre1.BringToFront();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            addUser a = new addUser();
            a.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            modification1.Visible = true;
            modification1.BringToFront();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            listUsers1.Visible = true;
            listUsers1.BringToFront();
        }
    }
}
