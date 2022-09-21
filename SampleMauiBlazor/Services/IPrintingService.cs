using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMauiBlazor.Services
{
    public interface IPrintingService
    {
        Task Print(PrintOptions options);
        Task Print(string printable, PrintType printType = PrintType.Pdf);
        Task Print(string printable, bool showModal, PrintType printType = PrintType.Pdf);
    }
}
