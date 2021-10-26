using System;
using System.Windows.Forms;
using BusinessLayer.Controllers;

namespace Nya_projektet_Grupp_18_C_Projekt
{
    public partial class Form1 : Form
    {
        FeedController feedController;
        public Form1()
        {
            InitializeComponent();
            feedController = new FeedController();
        }

        private void btnNyPodcast_Click(object sender, EventArgs e)
        {
            feedController.CreatePodcast(tbUrl.Text, cbKategori.Text, cbUppF.Text);

            tbUrl.Text = String.Empty;
            cbKategori.Text = String.Empty;
            cbUppF.Text = String.Empty;
        }
    }
}
