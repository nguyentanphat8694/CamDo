using CamDo.Business;
using CamDo.Db;
using CamDo.Forms;

namespace CamDo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            var dbService = new DatabaseServices();
            Task.Run(() => dbService.CheckAndUpdateDatabase()).Wait();
            InitializeComponent();
            InitLocalDatabase();
        }

        private void InitLocalDatabase()
        {
            DatabaseLocal.Init();
        }

        private void btnRedeemClick(object sender, EventArgs e)
        {
            OpenChildForm(EForm.RedeemForm, sender);
        }

        private void btnCreateClick(object sender, EventArgs e)
        {
            OpenChildForm(EForm.CreateForm, sender);
        }
    }
}