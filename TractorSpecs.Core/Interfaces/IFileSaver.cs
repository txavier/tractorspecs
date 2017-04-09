using AutoClutch.Core.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TractorSpecs.Core.Interfaces
{
    public interface IFileSaver
    {
        IEnumerable<Error> Errors { get; set; }

        void SaveFile(string folder, string fileName, string base64String);

        void SaveFile(string base64String, string mappedPath);
    }
}
