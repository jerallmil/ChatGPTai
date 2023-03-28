namespace ChatGptAi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            webView21.Source = new Uri(ChatGptAi.Properties.Settings.Default.WebViewUrl);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Reload();
        }
    }
}