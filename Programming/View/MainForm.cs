using Programming.Model;

namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            EnumsListBox.SelectedIndex = 0;
        }

        //переменные для работы
        string curValue;
        //

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            curValue = Convert.ToString(EnumsListBox.SelectedItem);
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
    }
}


//чтл-то 