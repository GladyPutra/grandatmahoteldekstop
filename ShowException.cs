﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace GAHDesktop
{
    class ShowException
    {
        public ShowException() { }

        public void ShowMessage(string message, string jenis)
        {
            string[] temp = message.Split((char)11);
            MessageBox.Show(temp[0], jenis);
        }
    }
}
