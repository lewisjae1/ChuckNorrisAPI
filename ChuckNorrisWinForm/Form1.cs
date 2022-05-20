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
            foreach (var cat in categories)
            {
                cbx_category.Items.Add(cat);
            }
        }
    }
}