﻿using System;
using System.Windows.Forms;

namespace rah.lib.core
{
    public partial class WForm : Form, IWForm
    {
        public WForm()
        {
            InitializeComponent();
            KeyPress += (sender, e) =>
            {
                if (e.KeyChar == (char)Keys.Return)
                {
                    SendKeys.Send("{tab}");
                    e.Handled = true;
                }
            };

            KeyDown += (sender, e) =>
            {
                if (KeyCtrlPlusWEnable())
                {
                    if (e.KeyData == (Keys.Control | Keys.W))
                    {
                        Close();
                    }
                }
            };
        }

        protected virtual bool KeyCtrlPlusWEnable()
        {
            return true;
        }
    }
}