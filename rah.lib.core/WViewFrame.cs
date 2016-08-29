using System;

namespace rah.lib.core
{
    public partial class WViewFrame : WFrame
    {
        private MetaData metadata;
        public WViewFrame(MetaData metadata)
        {
            InitializeComponent();
            this.metadata = metadata;            
        }
    }
}
