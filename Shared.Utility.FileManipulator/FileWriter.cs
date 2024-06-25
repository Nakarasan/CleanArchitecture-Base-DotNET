using Microsoft.AspNetCore.Http;
using Shared.Utility.FileManipulator.Helper;
using Shared.Utility.FileManipulator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Utility.FileManipulator
{
    public class FileWriter : IFileWriter
    {
        public async Task<string> UploadImageAsync(int id, string folder, IFormFile file)
        {
            if (CheckIfImageFile(file))
            {
                return await WriteFile(id, folder, file);
            }
            return "Invalid image file";
        }

        private bool CheckIfImageFile(IFormFile file)
        {
            byte[] fileBytes;
            using (var ms = new MemoryStream())
            {
                file.CopyTo(ms);
                fileBytes = ms.ToArray();
            }

            return FileWriterHelper.GetImageFormat(fileBytes) != FileWriterHelper.ImageFormat.unknown;
        }

        public async Task<string> WriteFile(int fileRefName, string folder, IFormFile file)
        {
            string fileName;
            try
            {
                var extension = "." + file.FileName.Split('.')[file.FileName.Split('.').Length - 1];
                fileName = fileRefName + extension;

                var path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/Images/{folder}", fileName);

                using (var bits = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(bits);
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }

            return fileName;
        }




        public async Task<bool> DeleteFile(string relativeFilePath)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot", relativeFilePath);

            if (System.IO.File.Exists(path))
                System.IO.File.Delete(path);
            else
                return false;
            return true;
        }


        //document uploaded
        public async Task<ResponseResult> UploadDocumentAsync(int id, string folder, IFormFile file)
        {
            return await WriteFileForDoc(id, folder, file);

        }

        public async Task<ResponseResult> WriteFileForDoc(int fileRefName, string folder, IFormFile file)
        {
            string fileName;
            try
            {
                var extension = "." + file.FileName.Split('.')[file.FileName.Split('.').Length - 1];
                fileName = file.FileName.Split('.')[0] + extension;
                var path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/Staff/{folder}");
                var filepath = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/Staff/{folder}", fileName);

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                if (System.IO.File.Exists(filepath))
                {
                    return new ResponseResult()
                    {
                        Errors = fileName + "is already existing.",
                        Result = null,
                        Succeeded = false
                    };

                }
                else
                {
                    using (var bits = new FileStream(filepath, FileMode.Create))
                    {
                        await file.CopyToAsync(bits);
                    }
                }

            }
            catch (Exception e)
            {
                return new ResponseResult()
                {
                    Errors = e.Message,
                    Result = null,
                    Succeeded = false
                };
            }

            return new ResponseResult()
            {
                Errors = null,
                Result = fileName,
                Succeeded = true
            };
        }

        public class ResponseResult
        {
            public string Errors { get; set; }

            public string Result { get; set; }

            public bool Succeeded { get; set; }
        }


        //Get files to serial no
        public async Task<FileInfo[]> GetFileDetailsBySerialNo(string serialNo)
        {

            var path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/Staff/{serialNo}");

            if (Directory.Exists(path))
            {
                DirectoryInfo d = new DirectoryInfo(path); //Assuming Test is your Folder

                FileInfo[] t = d.GetFiles(); //Getting  files
                return t;
            }
            else
            {
                return null;
            }

        }

        Task<ResponseResult> IFileWriter.UploadDocumentAsync(int id, string folder, IFormFile file)
        {
            throw new NotImplementedException();
        }

    }
}
