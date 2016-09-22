namespace rah.lib.core
{
    public class WDMMain
    {
        static WDMMain Instance = null;

        public static WDMMain GetInstance()
        {
            if (Instance == null)
            {
                lock (typeof(WDMMain))
                {
                    if (Instance == null)
                    {
                        Instance = new WDMMain();                            
                    }
                }
            }

            return Instance;
        }

        public void RegisterToken(Token token)
        {
            Token = token;
        }

        public Token Token { private set; get; }
        public WForm MainForm { set; get; }
        public System.IntPtr MainFormHandle()
        {
            return MainForm.Handle;
        }
    }
}
