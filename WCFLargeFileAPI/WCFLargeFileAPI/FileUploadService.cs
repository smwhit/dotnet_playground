using System.IO;
using Interfaces;

namespace WCFLargeFileAPI
{
    public class FileUploadService : IFileUpload
    {
        public UploadFileResponse UploadFile(byte[] fileBytes)
        {
            var response = new UploadFileResponse();
            File.WriteAllBytes("test.txt", fileBytes);

            response.Message = "Successfully completed";
            return response;
        }

        public UploadFileResponse UploadFileViaStream(Stream stream)
        {
            var response = new UploadFileResponse();
            using (var fileStream = File.Create("teststreamdump.txt"))
            {
                stream.CopyTo(fileStream);
            }

            response.Message = "Successfully completed";
            return response;
        }

        public string SayHello(string name)
        {
            return string.Format("Hello - {0}", name);
        }
    }
}
