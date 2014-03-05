using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    [ServiceContract]
    public interface IFileUpload
    {
        [OperationContract]
        UploadFileResponse UploadFile(byte[] fileBytes);

        [OperationContract]
        UploadFileResponse UploadFileViaStream(Stream fileStream);

        [OperationContract]
        string SayHello(string name);
    }

    public class UploadFileResponse
    {
        public string Message { get; set; }
    }
}
