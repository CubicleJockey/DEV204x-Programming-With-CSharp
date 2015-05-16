using System;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows;

namespace Mod12_Homework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnWriteFile_Click(object sender, RoutedEventArgs e)
        {
           WriteFile();
        }

        private void btnReadFile_Click(object sender, RoutedEventArgs e)
        {
            ReadFile();
        }

        public async void WriteFile()
        {
            const string filePath = @"SampleFile.txt";
            var text = txtContents.Text;

            await WriteText(filePath, text);
        }

        private static async Task WriteText(string filePath, string text)
        {
            var encodedText = Encoding.Unicode.GetBytes(text);

            using (var sourceStream = new FileStream(filePath,
                FileMode.Append, FileAccess.Write, FileShare.None,
                4096, FileOptions.Asynchronous))
            {
                await sourceStream.WriteAsync(encodedText, 0, encodedText.Length);
            }
        }

        public async void ReadFile()
        {
            const string filePath = @"SampleFile.txt";

            if (File.Exists(filePath) == false)
            {
                MessageBox.Show(filePath + " not found", "File Error", MessageBoxButton.OK);
            }
            else
            {
                try
                {
                    var text = await ReadText(filePath);
                    txtContents.Text = text;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
        }

        private async static Task<string> ReadText(string filePath)
        {
            using (var sourceStream = new FileStream(filePath,
                FileMode.Open, FileAccess.Read, FileShare.Read,
                4096, FileOptions.Asynchronous))
            {
                StringBuilder sb = new StringBuilder();

                byte[] buffer = new byte[0x1000];
                Task<int> numRead;
                while (await (numRead = sourceStream.ReadAsync(buffer, 0, buffer.Length)) != 0)
                {
                    var text = Encoding.Unicode.GetString(buffer, 0, numRead.Result);
                    sb.Append(text);
                }

                return sb.ToString();
            }
        }
    }
}
