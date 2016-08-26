using rah.lib.core;
using System;
using System.Windows.Forms;

namespace rah
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (acessoForm acessoForm = new acessoForm())
            {
                acessoForm.ShowDialog();
                if (WDMMain.GetInstance().Token != null)
                {
                    Application.Run(new MainForm());
                }
            }            
        }
    }
}
