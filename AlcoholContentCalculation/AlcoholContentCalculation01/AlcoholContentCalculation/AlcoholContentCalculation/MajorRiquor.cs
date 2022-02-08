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
    public partial class MajorRiquor : Form
    {
        public MajorRiquor()
        {
            InitializeComponent();
            TextRead();
        }

        public void TextRead()
        {
            using (System.IO.StreamReader file =
               new System.IO.StreamReader(@"..\..\MajorRiquor.txt"))
            {
                MajorRiquorLabel.Text = file.ReadToEnd();
            }
        }
    }
}
