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
            var connection = new ConnectionHandler();
            var response = connection.GetResponse(GetModelListUrl(model));
            buildResponse(response);
        }

        protected override IWEntityForm CreateEntityForm(string model, object primaryKey = null)
        {
            return base.CreateEntityForm(model, primaryKey);
        }
    }
}
