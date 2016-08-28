using System;

namespace rah.lib.core
{
    public partial class WScrollFrame : WFrame
    {
        public WScrollFrame()
        {
            InitializeComponent();
        }

        private WScrollFrame _compositeTopFrame = null;
        private WScrollFrame _compositeLeftFrame = null;
        private WScrollFrame _compositeRightFrame = null;
        private WScrollFrame _compositeBottomFrame = null;

        protected void CompositeTopFrame(Type type)
        {
            if (_compositeTopFrame != null)
                throw new Exception($"{type.Name} já foi registrada.");

            _compositeTopFrame = (WScrollFrame)Activator.CreateInstance(type);
            _compositeTopFrame.Parent = panRight;
            _compositeTopFrame.Dock = System.Windows.Forms.DockStyle.Fill;

            panTop.Height = _compositeTopFrame.Height;
            panTop.Visible = true;
        }

        protected void CompositeLeftFrame(Type type)
        {
            if (_compositeLeftFrame != null)
                throw new Exception($"{type.Name} já foi registrada.");

            _compositeLeftFrame = (WScrollFrame)Activator.CreateInstance(type);
            _compositeLeftFrame.Parent = panRight;
            _compositeLeftFrame.Dock = System.Windows.Forms.DockStyle.Fill;

            panLeft.Width = _compositeLeftFrame.Width;
            panLeft.Visible = true;
        }

        protected void CompositeRightFrame(Type type)
        {
            if(_compositeRightFrame != null)
                throw new Exception($"{type.Name} já foi registrada.");

            _compositeRightFrame = (WScrollFrame)Activator.CreateInstance(type);
            _compositeRightFrame.Parent = panRight;
            _compositeRightFrame.Dock = System.Windows.Forms.DockStyle.Fill;

            panRight.Width = _compositeRightFrame.Width;
            panRight.Visible = true;
        }

        protected void CompositeBottomFrame(Type type)
        {
            if (_compositeBottomFrame != null)
                throw new Exception($"{type.Name} já foi registrada.");

            _compositeBottomFrame = (WScrollFrame)Activator.CreateInstance(type);
            _compositeBottomFrame.Parent = panBottom;
            _compositeBottomFrame.Dock = System.Windows.Forms.DockStyle.Fill;

            panBottom.Height = _compositeBottomFrame.Height;
            panBottom.Visible = true;
        }
    }
}
