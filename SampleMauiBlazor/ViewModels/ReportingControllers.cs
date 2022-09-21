using AspNetCore.Reporting;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace SampleMauiBlazor.ViewModels
{
    public class ReportingController
    {
        ReportService reportService = new ReportService();
        private readonly IHostingEnvironment _environment;
        public ReportingController(IHostingEnvironment _environment)
        {
            this._environment = _environment;
        }

        //public IActionResult TestReport()
        //{
        //    var dt = new DataTable();
        //    dt = reportService.GetReportInfo();
        //    string mimetype = "";
        //    int extension = 1;
        //    var path = $"{this._environment.ContentRootPath}\\Reports\\TestReport.rdlc";

        //    Dictionary<string, string> parameters = new Dictionary<string, string>();
        //    parameters.Add("param", "Blazor RDLC Report");

        //    LocalReport localReport = new LocalReport(path);
        //    localReport.AddDataSource("dsReportInfo", dt);
        //    var result = localReport.Execute(RenderType.Pdf, extension, parameters, mimetype);
        //    return File(result.MainStream, "application/pdf");
        //}
    }


    public class ReportService
    {
        public DataTable GetReportInfo()
        {
            var dt = new DataTable();
            dt.Columns.Add("Date");
            dt.Columns.Add("TemperatureC");
            dt.Columns.Add("TemperatureF");
            dt.Columns.Add("Summary");
            DataRow dr;
            for (int i = 0; i <= 50; i++)
            {
                dr = dt.NewRow();
                dr["Date"] = DateTime.Now.AddYears(5).AddDays(i);
                dr["TemperatureC"] = "17C";
                dr["TemperatureF"] = "17C";
                dr["Summary"] = "Summer";
                dt.Rows.Add(dr);

            }
            return dt;
        }
    }
}
