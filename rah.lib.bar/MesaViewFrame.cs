using rah.lib.core;

namespace rah.lib.bar
{
    public partial class MesaViewFrame : WViewFrame
    {
        public MesaViewFrame()
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

        protected override IWEntityForm CreateEntityForm(string model, object primaryKey)
        {
            return base.CreateEntityForm(model, primaryKey);
        }
    }
}
