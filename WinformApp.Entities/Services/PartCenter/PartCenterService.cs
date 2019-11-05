using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformApp.Entities.Responses;
using WinformApp.Services.Entities;

namespace WinformApp.Entities.Services.PartCenter
{
    public class PartCenterService : IPartCenterService
    {
        public BaseResponse<string> CreatePartCSV()
        {
            // Check if file is accessible

            // Create worksheet for PartCSV

            // Get and map data to PartCSVLineItem[]

            // Insert value to worksheet

            // Save file
            try
            {
                using (var excelPackage = new ExcelPackage())
                {
                    var fileName = "MyFile.csv";

                    // Check if file already opened
                    var fi = new FileInfo($"PartCSVs/{fileName}");

                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet 1");

                    excelPackage.SaveAs(fi);

                    excelPackage.Workbook.Properties.Author = "VDWWD";
                    excelPackage.Workbook.Properties.Title = "Title of Document";
                    excelPackage.Workbook.Properties.Subject = "EPPlus demo export data";
                    excelPackage.Workbook.Properties.Created = DateTime.Now;

                    var products = this.GetAndMapPartToLineItem();

                    worksheet = worksheet.CreatePartCSVWorksheet(products);

                    var fi2 = new FileInfo($"PartCSVs/{fileName}");

                    excelPackage.SaveAs(fi2);

                    return new BaseResponse<string>(fileName);
                }
            }
            catch (Exception ex)
            {
                var error = new BaseResponse<string>(ex);
                return error;
            }

        }


        public Product[] GetAndMapPartToLineItem()
        {
            using (var context = new NorthwindContext())
            {
                var products = context.Products.ToArray();
                return products;
            }
        }

        public object[] GetAndMapToOrderShippingLineItems()
        {
            throw new NotImplementedException();
        }
    }
}
