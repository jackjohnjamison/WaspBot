using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gecko;

namespace WaspBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Xpcom.Initialize("Firefox");
            geckoWebBrowser1.LoadHtml("<html><body> <style> body{background:#fff} </style> <h1>Hello!!!</h1></body></html>");
        }
    }
}
