using OfficeOpenXml;
using System;
using System.Linq;
using WinformApp.Services.Entities;

namespace WinformApp.Entities.Services.PartCenter
{
    public static class PartCenterServiceHelper
    {
        public static ExcelWorksheet CreatePartCSVWorksheet(this ExcelWorksheet worksheet, Product[] products)
        {
            worksheet.Cells[1, 1].Value = "id";
            worksheet.Cells[1, 2].Value = "name";
            worksheet.Cells[1, 3].Value = "description";
            worksheet.Cells[1, 4].Value = "part_number";
            worksheet.Cells[1, 5].Value = "price_cents";
            worksheet.Cells[1, 6].Value = "available";
            worksheet.Cells[1, 7].Value = "created_at";
            worksheet.Cells[1, 8].Value = "updated_at";
            worksheet.Cells[1, 9].Value = "first_asset_url";
            worksheet.Cells[1, 10].Value = "active";
            worksheet.Cells[1, 11].Value = "keywords";
            worksheet.Cells[1, 12].Value = "compatible_with";
            worksheet.Cells[1, 13].Value = "parts_central_update";
            worksheet.Cells[1, 14].Value = "parts_central_update_date";
            worksheet.Cells[1, 15].Value = "is_accessory";
            worksheet.Cells[1, 16].Value = "superseeded";
            worksheet.Cells[1, 17].Value = "comments";
            worksheet.Cells[1, 18].Value = "ndc";
            worksheet.Cells[1, 19].Value = "new_compatible_with";
            worksheet.Cells[1, 20].Value = "dangerous_good";
            worksheet.Cells[1, 21].Value = "indexed_at";

            for (int i = 0; i < products.Count(); i++)
            {
                var product = products[i];
                var cellRow = i + 2;
                worksheet.Cells[cellRow, 1].Value = product.ProductID;
                worksheet.Cells[cellRow, 2].Value = product.ProductName;
                worksheet.Cells[cellRow, 3].Value = product.ProductName;
                worksheet.Cells[cellRow, 4].Value = product.UnitsInStock;
                worksheet.Cells[cellRow, 5].Value = product.UnitPrice;
                worksheet.Cells[cellRow, 6].Value = true;
                worksheet.Cells[cellRow, 7].Value = DateTime.Now;
                worksheet.Cells[cellRow, 8].Value = DateTime.Now;
                worksheet.Cells[cellRow, 9].Value = "Some url to image";
                worksheet.Cells[cellRow, 10].Value = product.ProductName;
                worksheet.Cells[cellRow, 11].Value = product.ProductName;
                worksheet.Cells[cellRow, 12].Value = product.ProductName;
                worksheet.Cells[cellRow, 13].Value = product.ProductName;
                worksheet.Cells[cellRow, 14].Value = product.ProductName;
                worksheet.Cells[cellRow, 15].Value = product.ProductName;
                worksheet.Cells[cellRow, 16].Value = product.ProductName;
                worksheet.Cells[cellRow, 17].Value = product.ProductName;
                worksheet.Cells[cellRow, 18].Value = product.ProductName;
                worksheet.Cells[cellRow, 19].Value = product.ProductName;
                worksheet.Cells[cellRow, 20].Value = product.ProductName;
                worksheet.Cells[cellRow, 21].Value = product.ProductName;

            }

            return worksheet;
        }

        public static ExcelWorksheet CreateShippingWorksheet(this ExcelWorksheet worksheet)
        {
            worksheet.Cells[1, 1].Value = "Invoice Number";
            worksheet.Cells[1, 2].Value = "SKU";
            worksheet.Cells[1, 3].Value = "Tracking Number";
            worksheet.Cells[1, 4].Value = "Quantity";
            worksheet.Cells[1, 5].Value = "DC Code";
            worksheet.Cells[1, 6].Value = "Date Shipped";
            worksheet.Cells[1, 7].Value = "Shipping Carrier Code";
            worksheet.Cells[1, 8].Value = "Shipping Class Code";
            worksheet.Cells[1, 9].Value = "Shipment Cost";
            worksheet.Cells[1, 10].Value = "Shipment Tax Cost";
            worksheet.Cells[1, 11].Value = "Shipment Insurance Cost";
            worksheet.Cells[1, 12].Value = "Seller Fulfillment ID";
            worksheet.Cells[1, 13].Value = "PreventSiteProcessing";
            worksheet.Cells[1, 14].Value = "Fulfillment Cost";
            worksheet.Cells[1, 15].Value = "Fulfillment Status";
            worksheet.Cells[1, 16].Value = "Return Tracking Number";
            worksheet.Cells[1, 17].Value = "";

            return worksheet;
        }
    }
}
