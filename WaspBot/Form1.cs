using System.IO;
using System.Reflection;
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

            Assembly assembly = Assembly.GetExecutingAssembly();
            string resourceName = "WaspBot.app.html";
            string appHTML;

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                appHTML = reader.ReadToEnd();
            }

            geckoWebBrowser1.LoadHtml(appHTML, null);
        }
    }
}
