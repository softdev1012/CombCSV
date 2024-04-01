using System;
using System.Windows.Forms;

namespace CombCSV
{
    public partial class ValueInputForm : Form
    {
        public ValueInputForm()
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
            this.DialogResult= DialogResult.Cancel;
            this.Close ();
        }

        private void ValueInputForm_Load(object sender, EventArgs e)
        {
            txtValue.Text = this.value;
        }
    }
}
