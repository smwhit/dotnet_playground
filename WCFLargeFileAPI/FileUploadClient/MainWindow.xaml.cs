using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows;

namespace FileUploader
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var fileUpload = new LargeFileAPI.FileUploadClient();
            MessageBox.Show(fileUpload.SayHello(txtName.Text));
        }

        private async void ByteUpload(object sender, RoutedEventArgs e)
        {
            var bytes = File.ReadAllBytes(txtFileName.Text);
            var fileUpload = new LargeFileAPI.FileUploadClient();

            var response = await fileUpload.UploadFileAsync(bytes);
            MessageBox.Show(response.Message);
        }

        private async void StreamUpload(object sender, RoutedEventArgs e)
        {
            var fileUpload = new LargeFileAPI.FileUploadClient();
            using(var fileStream = new FileStream(txtFileName.Text, FileMode.Open))
            {
                var response = await fileUpload.UploadFileViaStreamAsync(fileStream);
                MessageBox.Show(response.Message);
            }
        }

        private async void SayHelloAsync(object sender, RoutedEventArgs e)
        {
            var fileUpload = new LargeFileAPI.FileUploadClient();
            
            //task based wcf operations
            var response = await fileUpload.SayHelloAsync(txtName.Text);
            MessageBox.Show(response);

            //async wcf operations
            //var task = Task<string>.Factory.FromAsync(fileUpload.BeginSayHello, fileUpload.EndSayHello, txtName.Text, null);
            //MessageBox.Show(task.Result);
        }
    }
}
