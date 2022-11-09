using CamDo.Forms;

namespace CamDo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnRedeemClick(object sender, EventArgs e)
        {
            OpenChildForm(new MFRedeemForm(), sender);
        }

        private void btnCreateClick(object sender, EventArgs e)
        {
            OpenChildForm(new MFCreateForm(), sender);
        }
    }
}