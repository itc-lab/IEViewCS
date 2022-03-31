using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEViewCS
{
    public partial class Form1 : Form
    {
        public Form1( string url )
        {
            m_url = url;
            InitializeComponent();
            this.webBrowser1.Url = new System.Uri(m_url, System.UriKind.Absolute);
            this.Text = m_url.Substring(m_url.LastIndexOf("/") + 1);
        }
    }
}
