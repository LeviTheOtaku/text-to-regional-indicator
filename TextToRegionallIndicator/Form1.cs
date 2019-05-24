using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextToRegionallIndicator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string output = "";

        private void convertButton_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            foreach (char c in s)
            {
                if (c.ToString() == "a" || c.ToString() == "A" ||
                    c.ToString() == "b" || c.ToString() == "B" ||
                    c.ToString() == "c" || c.ToString() == "C" ||
                    c.ToString() == "d" || c.ToString() == "D" ||
                    c.ToString() == "e" || c.ToString() == "E" ||
                    c.ToString() == "f" || c.ToString() == "F" ||
                    c.ToString() == "g" || c.ToString() == "G" ||
                    c.ToString() == "h" || c.ToString() == "H" ||
                    c.ToString() == "i" || c.ToString() == "I" ||
                    c.ToString() == "j" || c.ToString() == "J" ||
                    c.ToString() == "k" || c.ToString() == "K" ||
                    c.ToString() == "l" || c.ToString() == "L" ||
                    c.ToString() == "m" || c.ToString() == "M" ||
                    c.ToString() == "n" || c.ToString() == "N" ||
                    c.ToString() == "o" || c.ToString() == "O" ||
                    c.ToString() == "p" || c.ToString() == "P" ||
                    c.ToString() == "q" || c.ToString() == "Q" ||
                    c.ToString() == "r" || c.ToString() == "R" ||
                    c.ToString() == "s" || c.ToString() == "S" ||
                    c.ToString() == "t" || c.ToString() == "T" ||
                    c.ToString() == "u" || c.ToString() == "U" ||
                    c.ToString() == "v" || c.ToString() == "V" ||
                    c.ToString() == "w" || c.ToString() == "W" ||
                    c.ToString() == "x" || c.ToString() == "X" ||
                    c.ToString() == "y" || c.ToString() == "Y" ||
                    c.ToString() == "z" || c.ToString() == "Z")
                {
                    output = output + ":regional_indicator_" + c.ToString().ToLower() + ": ";
                }
                if (c.ToString() == "0")
                {
                    output = output + ":zero: ";
                }
                if (c.ToString() == "1")
                {
                    output = output + ":one: ";
                }
                if (c.ToString() == "2")
                {
                    output = output + ":two: ";
                }
                if (c.ToString() == "3")
                {
                    output = output + ":three:" ;
                }
                if (c.ToString() == "4")
                {
                    output = output + ":four: ";
                }
                if (c.ToString() == "5")
                {
                    output = output + ":five: ";
                }
                if (c.ToString() == "6")
                {
                    output = output + ":six: ";
                }
                if (c.ToString() == "7")
                {
                    output = output + ":seven: ";
                }
                if (c.ToString() == "8")
                {
                    output = output + ":eight: ";
                }
                if (c.ToString() == "9")
                {
                    output = output + ":nine: ";
                }
                if (c.ToString() == "#")
                {
                    output = output + ":hash: ";
                }
                if (c.ToString() == "*")
                {
                    output = output + ":asterisk: ";
                }
                if (c.ToString() == "!")
                {
                    output = output + ":grey_exclamation: ";
                }
                if (c.ToString() == "?")
                {
                    output = output + ":grey_question: ";
                }
                if (c.ToString() == "<")
                {
                    output = output + ":arrow_backward: ";
                }
                if (c.ToString() == ">")
                {
                    output = output + ":arrow_forward: ";
                }
                if (c.ToString() == " ")
                {
                    output = output + "     ";
                }
            }

            Clipboard.SetText(output);
            output = "";
            textBox1.Text = "";
        }
    }
}
