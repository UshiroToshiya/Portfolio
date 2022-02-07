using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlcoholContentCalculation
{
    public partial class RiquorAbout : Form
    {
        public RiquorAbout()
        {
            InitializeComponent();
            TextRead();
        }

        public void TextRead()
        {
            using (System.IO.StreamReader file =
               new System.IO.StreamReader(@"..\..\RiquorAbout.txt"))
            {
                RiquorTextView.Text = file.ReadToEnd();
            }
        }
    }
}
