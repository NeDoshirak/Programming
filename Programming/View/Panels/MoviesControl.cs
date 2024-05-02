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
    public partial class MoviesControl : UserControl
    {


        private Movie[] _movies = new Movie[5];
        private Movie _curretMovie;
        Random rnd = new Random();

        public MoviesControl()
        {
            InitializeComponent();

            for (int i = 0; i < _movies.Length; i++)
            {
                _movies[i] = new Movie();
                _movies[i].Title = "Название фильма";
                _movies[i].Year = rnd.Next(1900, 2024);
                _movies[i].Rating = rnd.Next(1, 10);
            }
            MoviesListBox.SelectedIndex = 0;
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
