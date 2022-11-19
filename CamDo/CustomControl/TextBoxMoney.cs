using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamDo.CustomControl
{
    public class TextBoxMoney : TextBox
    {
        public TextBoxMoney()
        {
            KeyPress += OnCustomKeyPress;
        }

        private void OnCustomKeyPress(object? sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
                if (string.IsNullOrEmpty(this.Text))
                {
                    this.Text = ",000";
                    SelectionStart = 0;
                }
                else
                {
                    var selectedText = SelectedText;
                    if (!string.IsNullOrEmpty(selectedText))
                    {
                        if (string.Equals(selectedText, this.Text))
                        {
                            this.Text = e.KeyChar.ToString() + ",000";
                            SelectionStart = 1;
                        }
                        else
                        {
                            var tempSelection = SelectionStart;
                            this.Text = AddCommaToString(this.Text.Replace(selectedText, e.KeyChar.ToString()));
                            SelectionStart = tempSelection + 1;
                        }
                        e.Handled = true;
                        return;
                    }
                    var changeText = "";
                    var tempOpSelStart = this.Text.Length - SelectionStart;
                    for (var i = 0; i < this.Text.Length; i++)
                    {
                        if (i == SelectionStart)
                            changeText += e.KeyChar.ToString();

                            changeText += this.Text[i];
                    }
                    var finalText = AddCommaToString(changeText);
                    this.Text = finalText;
                    SelectionStart = finalText.Length - tempOpSelStart;
                    e.Handled = true;
                }
            }
            //Backspace
            else if (e.KeyChar == (char)8)
            {

            }
            else if (e.KeyChar == (char)Keys.Enter)
            {

            }
            else
                e.Handled = true;
        }

        private string AddCommaToString(string changeText)
        {
            changeText = changeText.Replace(",", "");

            var finalText = "";
            var mod = changeText.Length % 3;
            var startComma = mod == 0 ? 0 : 3 - mod;
            for (var i = 0; i < changeText.Length; i++)
            {
                finalText += changeText[i];
                startComma++;
                if (startComma == 3 && i != changeText.Length - 1)
                {
                    finalText += ",";
                    startComma = 0;
                }
            }
            return finalText;
        }

        public int Value
        {
            get
            {
                var val = this.Text.Replace(",", "");
                return Int32.Parse(val);
            }
        }

    }
}
