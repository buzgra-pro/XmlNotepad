using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XmlNotepad
{
    public partial class frmXQuery : Form
    {
        public frmXQuery()
        {
            InitializeComponent();
        }

        public String xQueryValue;
        private void CmdSetValue_Click(object sender, EventArgs e)
        {
            xQueryValue = txQuery.Text;
        }
    }
}
