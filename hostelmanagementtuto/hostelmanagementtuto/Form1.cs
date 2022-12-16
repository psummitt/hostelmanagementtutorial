using System;
using System.Windows.Forms;

namespace hostelmanagementtuto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void wizardPageContainer1_Cancelling(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Close();
        }

        private void wizardPageContainer1_Finished(object sender, EventArgs e)
        {
            this.Close();
        }

        private void wizardPageContainer1_SelectedPageChanged(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
