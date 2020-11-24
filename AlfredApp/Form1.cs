using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlfredESK;

namespace AlfredApp
{
    public partial class Form1 : Form
    {
        Alfred esk;
        public Form1()
        {
            esk = new Alfred();
            InitializeComponent();
            boxLocations.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var results = esk.Search(new SearchInfo(
                boxLocations.SelectedItem.ToString(),
                int.Parse(tbxAreaMin.Text),
                int.Parse(tbxAreaMin.Text)));
            foreach (var result in results)
            {
                lbxResults.Items.Add(result);
            }
            MessageBox.Show("Cem");
            // Test
        }
    }
}
