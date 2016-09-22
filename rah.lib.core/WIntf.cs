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
        Control Parent { get; set; }
        DockStyle Dock { get; set; }
    }

    public interface IWViewFrame : IWFrame
    {
        void DoLeave();
        void LoadModel(string model);
    }

    public interface IConnectionHandler
    {
        string GetResponse(string postData, string command);
        string GetResponse(string command);
    }
}
