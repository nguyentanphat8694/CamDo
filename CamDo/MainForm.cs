using CamDo.Forms;

namespace CamDo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MFRedeemForm(), sender);
        }
    }
}