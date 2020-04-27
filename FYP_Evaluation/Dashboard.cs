using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYP_Evaluation
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            Customizedesign();
        }
        private void Customizedesign()
        {
            fyp1submenupanel.Visible = false;
            fyp2panelsubmenu.Visible = false;
        }
        private void hidesubmenu()
        {
            if(fyp1submenupanel.Visible == true)
            {
                fyp1submenupanel.Visible = false;
            }
            if (fyp2panelsubmenu.Visible == true)
            {
                fyp2panelsubmenu.Visible = false;
            }
        }
        private void showsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hidesubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;

            }
        }

        private void fyp1button_Click(object sender, EventArgs e)
        {
            showsubmenu(fyp1submenupanel);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openchildform(new ProposalForm());

            hidesubmenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openchildform(new ProposalEvaluationform());

            hidesubmenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openchildform(new Fyp1Final());

            hidesubmenu();
        }
        private void button5_Click(object sender, EventArgs e)
        {

            hidesubmenu();
        }
        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fyp2button_Click(object sender, EventArgs e)
        {
            showsubmenu(fyp2panelsubmenu);
        }

        private void button8_Click(object sender, EventArgs e)
        {


            hidesubmenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openchildform(new Fyp2MidEvaluationForm());

            hidesubmenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openchildform(new Fyp2FinalJuryEvaluation());
            hidesubmenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            openchildform(new Fyp2FinalExternalEvaluation());
            hidesubmenu();
        }
        private Form activeform = null;
        private void openchildform(Form childform)
        {
            if (activeform != null)
            {
                activeform.Close();
            }
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelchildforms.Controls.Add(childform);
            panelchildforms.Tag = childform;
            panelchildforms.AutoScroll = true;
            childform.AutoScroll = true;
            childform.BringToFront();
            childform.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            openchildform(new SupervisorProposalForm());

            hidesubmenu();
        }
    }
}
