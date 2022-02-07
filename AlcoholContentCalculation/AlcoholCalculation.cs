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
    public partial class AlcoholCalculation : Form
    {
        public AlcoholCalculation()
        {
            InitializeComponent();
            TextRead();
        }

        public void TextRead()
        {
            using (System.IO.StreamReader file =
               new System.IO.StreamReader(@"..\..\AlcoholCalcTextFile.txt"))
            {
                TextView.Text = file.ReadToEnd();            
            }
        }
    }
}
