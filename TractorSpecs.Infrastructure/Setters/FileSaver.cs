using AutoClutch.Core.Objects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Hosting;
using TractorSpecs.Core.Interfaces;

namespace TractorSpecs.Infrastructure.Setters
{
    public class FileSaver : IFileSaver
    {
        public IEnumerable<Error> Errors { get; set; }

        public FileSaver()
        {
            Errors = new List<Error>();
        }

        public void SaveFile(string hostingEnvironmentFilePath, string fileName, string base64String)
        {
            try
            {
                var mappedPath = HostingEnvironment.MapPath("~/" + hostingEnvironmentFilePath);

                if (!Directory.Exists(mappedPath))
                {
                    Directory.CreateDirectory(mappedPath);
                }

                mappedPath = mappedPath + "\\" + fileName;

                SaveFile(base64String, mappedPath);
            }
            catch (Exception ex)
            {
                ((List<Error>)Errors).Add(new Error { Description = ex.Message, Property = hostingEnvironmentFilePath });
            }
        }

        public void SaveFile(string base64String, string mappedPath)
        {
            base64String = base64String.Contains("data:") ? base64String.Split(",".ToCharArray()).Last() : base64String;

            File.WriteAllBytes(mappedPath, Convert.FromBase64String(base64String));
        }
    }           
}
