using System;

namespace EnglishPronunciator
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private async void buttonPronounce_Click(object sender, EventArgs e)
        {
            string word = textBoxWord.Text;

            string address = "https://d1qx7pbj0dvboc.cloudfront.net";
            string extesion = "mp3";
            string uri = $"{address}/{word}.{extesion}";


        }

        /*
        private void DownloadFileAsync()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(uri))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        using (var content = response.Content)
                        {
                            var fileBytes = await content.ReadAsByteArrayAsync();
                            string fileName = $"{word}.{extesion}";
                            File.WriteAllBytes(fileName, fileBytes);
                        }
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }
        }
        */
    }
}
