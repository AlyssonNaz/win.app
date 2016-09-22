namespace rah.lib.core
{
    public partial class WChildForm : WForm, IWChildForm
    {
        public WChildForm()
        {
            InitializeComponent();
            ViewFrame = null;
        }

        public IWViewFrame ViewFrame { set; get; }

        public void RegisterViewFrame(IWViewFrame ViewFrame)
        {
            this.ViewFrame = ViewFrame;
            this.ViewFrame.Parent = this;
            this.ViewFrame.Dock = System.Windows.Forms.DockStyle.Fill;            
        }

        private void WChildForm_Leave(object sender, System.EventArgs e)
        {
            if (ViewFrame != null)
            {
                ViewFrame.DoLeave();
            }
        }
    }
}
