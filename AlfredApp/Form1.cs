using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeArayuz1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Nasıl.BackColor = ButNasıl.BackColor;
            Evoz.BackColor = panel1.BackColor;
            Eks.BackColor = panel1.BackColor;
            kon.BackColor = panel1.BackColor;
            panelny.BringToFront();
            
        }

        private void ButKon_Click(object sender, EventArgs e)
        {
            kon.BackColor = ButKon.BackColor;
            Evoz.BackColor = panel1.BackColor;
            Eks.BackColor = panel1.BackColor;
            Nasıl.BackColor = panel1.BackColor;
            panelkb.BringToFront();
            
        }

        private void ButEvoz_Click(object sender, EventArgs e)
        {
            Evoz.BackColor = ButEvoz.BackColor;
            kon.BackColor = panel1.BackColor;
            Eks.BackColor = panel1.BackColor;
            Nasıl.BackColor = panel1.BackColor;
            paneleo.BringToFront();
            
        }

        private void ButEks_Click(object sender, EventArgs e)
        {
            Eks.BackColor = ButEks.BackColor;
            Evoz.BackColor = panel1.BackColor;
            kon.BackColor = panel1.BackColor;
            Nasıl.BackColor = panel1.BackColor;
            panelam.BringToFront();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelsonuc.BringToFront();
        }
    }
}
