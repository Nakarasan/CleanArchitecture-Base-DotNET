using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Shared.Utility.FileManipulator.FileWriter;

namespace Shared.Utility.FileManipulator.Interfaces
{
    public interface IFileWriter
    {
        Task<string> UploadImageAsync(int id, string folder, IFormFile file);
        Task<ResponseResult> UploadDocumentAsync(int id, string folder, IFormFile file);
        Task<FileInfo[]> GetFileDetailsBySerialNo(string serialNo);
        Task<bool> DeleteFile(string relativeFilePath);
    }
}
