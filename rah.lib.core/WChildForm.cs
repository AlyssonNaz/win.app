namespace rah.lib.core
{
    public partial class WChildForm : WForm
    {
        public WChildForm()
        {
            InitializeComponent();
            _viewFrame = null;
        }

        private WViewFrame _viewFrame;

        public void RegisterViewFrame(WViewFrame ViewFrame)
        {
            _viewFrame = ViewFrame;
            _viewFrame.Parent = this;
            _viewFrame.Dock = System.Windows.Forms.DockStyle.Fill;
        }
    }
}
