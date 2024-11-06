using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Form
{
    public partial class Form1 : Form
    {
        TestLabel _testlabel;
        public Form1()
        {
            InitializeComponent();



            for (int i = 0; i < 10; i++)
            {
                TestButton testButton = new TestButton(this, i, (i % 5) * 100, (i / 5) * 100, 100, 100);
                Controls.Add(testButton);
            }


            _testlabel =
                  new TestLabel("らべるです。", 10, 300, 100, 500);
            Controls.Add(_testlabel);

        }

        public void LabelTextUpdate(string str)
        {
            _testlabel.TextUpdate(str);
        }

    }
}
