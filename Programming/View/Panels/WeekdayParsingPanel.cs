using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    public partial class WeekdayParsingPanel : UserControl
    {
        public WeekdayParsingPanel()
        {
            InitializeComponent();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            var inputText = ParsingListBox.Text;

            if (int.TryParse(inputText, out var result))
            {
                WeekdayResultLable.Text = "Введённое значение не является текстом";

            }
            else
            {
                if (Enum.TryParse(typeof(Weekday), inputText, out var ParsedWeekday))
                {
                    WeekdayResultLable.Text = $"Текст является днём недели ({inputText} = {Convert.ToInt64(ParsedWeekday) + 1})";

                }
                else
                {
                    WeekdayResultLable.Text = "Такого дня недели нету :(";

                }
            }

            WeekdayResultLable.Visible = true;

        }
    }
}
