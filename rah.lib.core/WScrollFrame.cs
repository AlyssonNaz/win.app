namespace rah.lib.core
{
    public partial class WScrollFrame : WFrame
    {
        public WScrollFrame()
        {
            InitializeComponent();
        }

        public WScrollFrame(IWEntity Entity)
        {
            InitializeComponent();
            _entity = Entity;
        }

        private IWEntity _entity = null;
        private WScrollFrame _compositeTopFrame = null;
        private WScrollFrame _compositeLeftFrame = null;
        private WScrollFrame _compositeRightFrame = null;
        private WScrollFrame _compositeBottomFrame = null;

        protected void CompositeTopFrame()
        {
            _compositeBottomFrame._entity = _entity;
        }

        protected void CompositeLeftFrame()
        {

        }        

        protected void CompositeRightFrame()
        {

        }

        protected void CompositeBottomFrame()
        {

        }
    }
}
