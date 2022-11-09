using CamDo.Entity.VModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamDo.Forms
{
    public partial class MFCreateForm : Form
    {
        public MFCreateForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnSavePrint_Click(object sender, EventArgs e)
        {

        }

        private bool SaveContract()
        {
            var contract = new VContract()
            {
                Id = lblId.Text,
                CustomerName = txtCustomerName.Text,
                StaffName = GlobalValue.StaffName,
                Cost = Int32.Parse(txtMoney.Text),
                Description = txtDescription.Text,
                IsMachine = ckbIsMachine.Checked,
            };
            return false;
        }
    }
}
