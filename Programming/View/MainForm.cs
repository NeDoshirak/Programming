using Programming;

namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            EnumsListBox.SelectedIndex = 0;


            var seasonsValue = Enum.GetValues(typeof(Seasons));
            object[] SeasonValues = Enum.GetValues(typeof(Seasons)).Cast<object>().ToArray();
            SeasonsComboBox.Items.AddRange(SeasonValues);


            SeasonsComboBox.SelectedIndex = 0;


        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curValue = Convert.ToString(EnumsListBox.SelectedItem);
            var enumValues = Enum.GetValues(typeof(Colors));

            ValuesListBox.Items.Clear();

            switch (curValue)
            {
                case "Weekday":
                    {
                        enumValues = Enum.GetValues(typeof(Weekday));
                        break;
                    }
                case "Colors":
                    {
                        enumValues = Enum.GetValues(typeof(Colors));
                        break;
                    }
                case "Manufacturers":
                    {
                        enumValues = Enum.GetValues(typeof(Manufacturers));
                        break;
                    }
                case "Genre":
                    {
                        enumValues = Enum.GetValues(typeof(Genre));
                        break;
                    }
                case "Seasons":
                    {
                        enumValues = Enum.GetValues(typeof(Seasons));
                        break;
                    }
                case "StudyForm":
                    {
                        enumValues = Enum.GetValues(typeof(StudyForm));
                        break;
                    }
            }


            Enumerable.Cast<string>(enumValues);
            foreach (var enumValue in enumValues)
            {
                ValuesListBox.Items.Add(enumValue);
            }
            ValuesListBox.SelectedIndex = 0;

        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntEnumsIndex.Text = Convert.ToString(ValuesListBox.SelectedIndex);


        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            var inputText = ParsingListBox.Text;

            if (Enum.TryParse(typeof(Weekday), inputText, out var ParsedWeekday))
            {
                WeekdayResultLable.Text = $"����� �������� ��� ������ ({inputText} = {Convert.ToInt64(ParsedWeekday) + 1})";
                WeekdayResultLable.Visible = true;
            }
            else
            {
                WeekdayResultLable.Text = "������ ��� ������ ���� :(";
                WeekdayResultLable.Visible = true;
            }


        }

        private void SeasonsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SeasonResulrButton_Click(object sender, EventArgs e)
        {
            var curValue = Convert.ToString(SeasonsComboBox.SelectedItem);
            switch (curValue)
            {
                case "Summer":
                    {
                        SeasonResultLable.Text = "���! ������!";
                        SeasonResultLable.Visible = true;
                        break;
                    }
                case "Autumn":
                    {
                        BackColor = Color.Orange;
                        break;
                    }
                case "Spring":
                    {
                        BackColor = Color.Green;
                        break;
                    }
                case "Winter":
                    {
                        SeasonResultLable.Text = "�����! �������!";
                        SeasonResultLable.Visible = true;
                        break;
                    }
      
            }
        }
    }
}
