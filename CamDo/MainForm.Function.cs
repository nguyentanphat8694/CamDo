using CamDo.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamDo
{
    partial class MainForm
    {
        private Form activeForm { get; set; }
        private Button currentButton { get; set; }

        private Dictionary<EForm, Form> DictForm { get; set; } = new Dictionary<EForm, Form>();

        private void OpenChildForm(EForm eForm, object btnSender)
        {
            if (activeForm != null)
            {
                if (!DictForm.ContainsValue(activeForm))
                {
                    var oldKey = GetEFormValue(activeForm);
                    DictForm.Add(oldKey, activeForm);
                }
                activeForm.Hide();
            }
            var childForm = new Form();
            if (DictForm.ContainsKey(eForm))
                childForm = DictForm[eForm];
            else
                childForm = GenerateChildForm(eForm);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_form.Controls.Add(childForm);
            panel_form.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private Form GenerateChildForm(EForm eForm)
        {
            if (eForm == EForm.CreateForm)
                return new MFCreateForm();
            else if (eForm == EForm.RedeemForm)
                return new MFRedeemForm();
            else
                return new MFCreateForm();
        }

        private EForm GetEFormValue(Form form)
        {
            if (form is MFCreateForm)
                return EForm.CreateForm;
            else if (form is MFRedeemForm)
                return EForm.RedeemForm;
            else
                return EForm.CreateForm;
        }
    }
}
