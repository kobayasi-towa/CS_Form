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
        TestTextBox _testtextBox;
        public Form1()
        {
            InitializeComponent();

            string[] strs =
            {
                "あか",
                "あお",
                "きいろ",
                "みどり",
                "くろ",
                "しろ",
                "ちゃいろ",
                "ピンク",
                "むらさき",
                "きみどり",
            };



            for (int i = 0; i < 10; i++)
            {
                TestButton testButton = new TestButton(this, strs[i], (i % 5) * 100, (i / 5) * 100, 100, 100);
                Controls.Add(testButton);
            }



            _testlabel =
                  new TestLabel("らべるです。", 10, 330, 500, 100);
            Controls.Add(_testlabel);

            _testtextBox = new TestTextBox(
                "てきすとぼっくすです", 10, 300, 500, 100);

            Controls.Add(_testtextBox);

        }

        public void LabelTextUpdate(string str)
        {
            _testlabel.TextUpdate(str);
        }

        public string ButtonLabelReplacement(string str)
        {
            string s = _testtextBox.TextReplacement(str);

            return s;
        }
    }
}
