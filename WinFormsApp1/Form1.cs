namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            using var client = new HttpClient();
            string result = string.Empty;
            for (int i = 0; i < 10; i++)
            {
                var response = await client.GetAsync("http://localhost:5024");
                result = await response.Content.ReadAsStringAsync();
            }

            MessageBox.Show(result);
            //RV.Text = result;
        }
    }
}
