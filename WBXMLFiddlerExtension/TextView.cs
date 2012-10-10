using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WBXMLFiddlerExtension
{
    public partial class TextView : UserControl
    {
        public TextView()
        {
            InitializeComponent();
        }

        public void SetText(string text)
        {
            showText.Text = text;
        }
    }
}
