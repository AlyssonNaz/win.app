using rah.lib.core;
using rah.lib.bar;

namespace rah
{
    public partial class MainForm : WForm
    {
        public MainForm()
        {
            InitializeComponent();
            WDMMain.GetInstance().MainForm = this;            
        }

        private void ShowGenericModel(string model)
        {
            Utility.LockWindowUpdate();
            try
            {
                var childForm = new WChildForm();
                var viewFrame = new WGenericViewFrame();
                childForm.RegisterViewFrame(viewFrame);
                childForm.ViewFrame.LoadModel(model);
                childForm.MdiParent = this;
                childForm.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                childForm.Show();
            }
            finally
            {
                Utility.UnLockWindowUpdate();
            }
        }

        private void mesaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Utility.LockWindowUpdate();
            try
            {
                var childForm = new WChildForm();
                var mesa = new MesaViewFrame();
                childForm.RegisterViewFrame(mesa);
                childForm.ViewFrame.LoadModel("table");
                childForm.MdiParent = this;
                childForm.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                childForm.Show();
            }
            finally
            {
                Utility.UnLockWindowUpdate();
            }
        }

        private void baresToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ShowGenericModel("bar");
        }

        private void usuáriosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ShowGenericModel("user");
        }

        private void contextoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ShowGenericModel("context");
        }

        private void menuToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ShowGenericModel("menu");
        }

        private void sairToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
