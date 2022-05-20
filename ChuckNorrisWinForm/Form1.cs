using ChuckNorrisAPI;

namespace ChuckNorrisWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComboBox();
        }

        private async Task InitializeComboBox()
        {
            IEnumerable<string> categories = await ChuckNorrisClient.GetCategories();
            cbx_category.Items.Add("all");
            foreach (var cat in categories)
            {
                cbx_category.Items.Add(cat);
            }
        }

        private void btn_joke_Click(object sender, EventArgs e)
        {
            if(cbx_category.SelectedIndex == 0)
            {
                generateRandomJoke();
            }
            else if(cbx_category.SelectedIndex == 1)
            {
                generateExplicitJoke();
            }
            else if (cbx_category.SelectedIndex == 2)
            {
                generateNerdyJoke();
            }
            else
            {
                MessageBox.Show("Choose the Category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        }

        private async Task generateNerdyJoke()
        {
            Joke j = await ChuckNorrisClient.GetNerdyJoke();
            MessageBox.Show($"{j.Id}:{j.JokeText}\n\n{string.Join(", ", j.Categories)}");
        }

        private async Task generateExplicitJoke()
        {
            Joke j = await ChuckNorrisClient.GetExplicitJoke();
            MessageBox.Show($"{j.Id}:{j.JokeText}\n\n{string.Join(", ", j.Categories)}");
        }

        private async Task generateRandomJoke()
        {

            Joke j = await ChuckNorrisClient.GetRandomJoke();
            MessageBox.Show($"{j.Id}:{j.JokeText}\n\n{string.Join(", ", j.Categories)}");

        }
    }
}