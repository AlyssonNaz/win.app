using rah.lib.core;
using rah.lib.bar;

namespace rah
{
    public partial class MainForm : WForm
    {
        public MainForm()
        {
            InitializeComponent();            
        }

        private void mesaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var childForm = new WChildForm();
            var mesa = new MesaViewFrame();           
            childForm.RegisterViewFrame(mesa);
            childForm.ViewFrame.LoadModel("Mesa");
            childForm.MdiParent = this;
            childForm.Show();            
        }
    }
}
