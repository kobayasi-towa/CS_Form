﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using  System.Net.Refleaction.Emit;
//using static ~~~
//↑追加されてたら消してください

using System.Windows.Forms;


namespace CS_Form
{
    class TestLabel : Label
    {
        /// <summary>
        /// コンストラクタ
        /// クラスを生成したときに呼び出される
        /// </summary>
        public TestLabel(string str, int x, int y,int width, int height)
        {
            
            //ラベル内に文字を表示させる
            Text = str; 
            //ボタンの生成の場所を指定
            Location = new Point(x, y);
            //ボタンの大きさを指定
            Size = new Size(width, height);
        }

        public void TextUpdate(string str)
        {
            Text = str;
        }

    }
}
