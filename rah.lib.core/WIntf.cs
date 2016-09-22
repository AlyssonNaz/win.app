using System.Windows.Forms;

namespace rah.lib.core
{
    public interface IWForm
    {
        void Show();
    }

    public interface IWChildForm : IWForm
    {
        Form MdiParent { set; get; }
    }

    public interface IWEntityForm : IWChildForm
    {
        
    }

    public interface IWFrame
    {

    }

    public interface IWViewFrame : IWFrame
    {

    }
}
