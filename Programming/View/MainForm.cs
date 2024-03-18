using Programming;
using System.Security.Cryptography.X509Certificates;

namespace Programming
{
    public partial class MainForm : Form
    {
        private Rectangle[] _rectangles = new Rectangle[5];
        private Rectangle _curretRentagles;

        private Movie[] _movies = new Movie[5];
        private Movie _curretMovie;

        Random rdn = new Random();


        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            EnumsListBox.SelectedIndex = 0;


            var seasonsValue = Enum.GetValues(typeof(Seasons));
            object[] SeasonValues = Enum.GetValues(typeof(Seasons)).Cast<object>().ToArray();
            SeasonsComboBox.Items.AddRange(SeasonValues);


            SeasonsComboBox.SelectedIndex = 0;

            for (int i = 0; i < _rectangles.Length; i++)
            {
                _rectangles[i] = new Rectangle(rdn.Next(1, 10), rdn.Next(1, 10), "Red", rdn.Next(1, 10), rdn.Next(1, 10));
            }

            RectanglesListBox.SelectedIndex = 0;

            for (int i = 0; i < _movies.Length; i++)
            {
                _movies[i] = new Movie();
                _movies[i].Title = "Название фильма";
                _movies[i].Year = rdn.Next(1900, 2024);
                _movies[i].Rating = rdn.Next(1, 10);
            }
            MoviesListBox.SelectedIndex = 0;

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

            object[] temp = enumValues.Cast<object>().ToArray();
            ValuesListBox.Items.AddRange(temp);

        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntEnumsIndex.Text = Convert.ToString(ValuesListBox.SelectedIndex);


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

        private void SeasonResulrButton_Click(object sender, EventArgs e)
        {
            var curValue = Convert.ToString(SeasonsComboBox.SelectedItem);
            switch (curValue)
            {
                case "Summer":
                    {
                        SeasonResultLable.Text = "Ура! Солнце!";
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
                        SeasonResultLable.Text = "Брррр! Холодно!";
                        SeasonResultLable.Visible = true;
                        break;
                    }

            }
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _curretRentagles = _rectangles[RectanglesListBox.SelectedIndex];

            LenghtTB.Text = _curretRentagles.Length.ToString();
            WidthTB.Text = _curretRentagles.Wide.ToString();
            ColorTB.Text = _curretRentagles.Color;
            CenterXTB.Text = _curretRentagles.Center.X.ToString();
            CenterYTB.Text = _curretRentagles.Center.Y.ToString();
            IDTB.Text = _curretRentagles.id.ToString();

        }

        private void LenghtTB_TextChanged(object sender, EventArgs e)
        {

            try
            {
                _curretRentagles.Length = Convert.ToDouble(LenghtTB.Text);
                LenghtTB.BackColor = Color.White;
            }
            catch
            {
                LenghtTB.BackColor = Color.LightPink;
            }
        }

        private void WidhtTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _curretRentagles.Wide = Convert.ToDouble(WidthTB.Text);
                WidthTB.BackColor = Color.White;
            }
            catch
            {
                WidthTB.BackColor = Color.LightPink;
            }
        }

        private void ColorTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _curretRentagles.Color = ColorTB.Text;
                ColorTB.BackColor = Color.White;
            }
            catch
            {
                ColorTB.BackColor = Color.LightPink;
            }
        }

        private int FindRectangleWithMaxWidth(Rectangle[] array)
        {
            double maxWidth = array[0].Wide;
            int maxWideIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Wide > maxWidth)
                {
                    maxWidth = array[i].Wide;
                    maxWideIndex = i;
                }
            }
            return maxWideIndex;
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _curretMovie = _movies[MoviesListBox.SelectedIndex];

            TittleTB.Text = _curretMovie.Title;
            YearTB.Text = _curretMovie.Year.ToString();
            RatingTB.Text = _curretMovie.Rating.ToString();

        }

        private void TittleTB_TextChanged(object sender, EventArgs e)
        {
            _curretMovie.Title = TittleTB.Text;
        }

        private void YearTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _curretMovie.Year = Convert.ToInt32(YearTB.Text);
                YearTB.BackColor = Color.White;
            }
            catch
            {
                YearTB.BackColor = Color.LightPink;
            }

        }

        private void RatingTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _curretMovie.Rating = Convert.ToInt32(RatingTB.Text);
                RatingTB.BackColor = Color.White;
            }
            catch
            {
                RatingTB.BackColor = Color.LightPink;
            }
        }

        private int FindMovieleWithRating(Movie[] array)
        {
            int maxRating = array[0].Rating;
            int maxRatingIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Rating > maxRating)
                {
                    maxRating = array[i].Rating;
                    maxRatingIndex = i;
                }
            }
            return maxRatingIndex;
        }

        private void FindMovButton_Click(object sender, EventArgs e)
        {
            MoviesListBox.SelectedIndex = FindMovieleWithRating(_movies);
        }
    }

}
