using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamDo
{
    partial class MainForm
    {
        private Form activeForm { get; set; }
        private Button currentButton { get; set; }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_form.Controls.Add(childForm);
            panel_form.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
