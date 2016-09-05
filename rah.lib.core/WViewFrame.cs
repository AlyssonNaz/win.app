namespace rah.lib.core
{
    public partial class WViewFrame : WFrame
    {        
        public WViewFrame()
        {
            InitializeComponent();            
        }

        protected virtual void DoLoadModel(string model)
        {
            // para ser sobrecarregado.
        }

        public void LoadModel(string model)
        {
            DoLoadModel(model);
        }
    }
}
