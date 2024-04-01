using System;
using System.Windows.Forms;

namespace CombCSV
{
    public partial class MultiInputForm : Form
    {
        public MultiInputForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.value = txtValue.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void MultiInputForm_Load(object sender, EventArgs e)
        {
            txtValue.Text = this.value;
        }
    }
}
