namespace rah.lib.core
{
    public partial class WGenericViewFrame : WViewFrame
    {
        public WGenericViewFrame()
        {
            InitializeComponent();
        }

        protected override void DoLoadModel(string model)
        {
            base.DoLoadModel(model);                        
            buildResponse(WDMMain.GetInstance().GetConnection().GetResponse(GetModelListUrl(model)));
        }

        protected override IWEntityForm CreateEntityForm(string model, object primaryKey = null)
        {
            return base.CreateEntityForm(model, primaryKey);
        }
    }
}
