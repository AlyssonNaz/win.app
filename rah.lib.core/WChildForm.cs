namespace rah.lib.core
{
    public partial class WChildForm : WForm
    {
        public WChildForm()
        {
            InitializeComponent();
            ViewFrame = null;
        }

        public WViewFrame ViewFrame { set; get; }

        public void RegisterViewFrame(WViewFrame ViewFrame)
        {
            this.ViewFrame = ViewFrame;
            this.ViewFrame.Parent = this;
            this.ViewFrame.Dock = System.Windows.Forms.DockStyle.Fill;            
        }

        private void WChildForm_Leave(object sender, System.EventArgs e)
        {
            if (ViewFrame != null)
                ViewFrame.DoLeave();
        }
    }
}
