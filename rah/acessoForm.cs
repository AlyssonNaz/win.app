﻿using rah.lib.core;
using System;
using System.Windows.Forms;

namespace rah
{
    public partial class acessoForm : WForm
    {
        public acessoForm()
        {
            InitializeComponent();            
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                var connection = new ConnectionHandler();                                
                Token token = new Token();                               
                token.loadToken(connection.GetResponse($"username={textBoxUserName.Text}&password={textBoxPassword.Text}", "api/auth"));
                WDMMain.GetInstance().RegisterToken(token);                                
                Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Usuário e/ou senha invalidos.\n\n" + Ex.Message);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {            
            Close();
        }

        protected override bool KeyCtrlPlusWEnable()
        {
            return false;
        }
    }
}
