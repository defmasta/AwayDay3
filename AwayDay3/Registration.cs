﻿/*
 * Danny Walasek
 * Radoslaw Warowny    
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwayDay3
{
    public partial class Registration : Form
    {
        private MainLogic logic;
        public Registration()
        {
            InitializeComponent();
        }
        public Registration(MainLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text != "" && txtLastName.Text != "" && txtBusinessName.Text != "" && txtDepartment.Text != "" && txtBusinessEmail.Text != ""
                && txtBusinessAddress.Text != "" && txtCity.Text != "" && txtPostCode.Text != "" && txtBusinessPhone.Text != "")
                txtstatus.Text = logic.Register(txtFirstName.Text, txtLastName.Text, txtBusinessName.Text, txtDepartment.Text,
                                                txtBusinessEmail.Text, txtBusinessAddress.Text, txtCity.Text, txtPostCode.Text, txtBusinessPhone.Text);
            else
                txtstatus.Text = "One of more fields have been left blank";
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            Events openForm = new Events(logic);
            openForm.Show();
            Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main openForm = new Main(logic);
            openForm.Show();
            Visible = false;
        }
    }
}
