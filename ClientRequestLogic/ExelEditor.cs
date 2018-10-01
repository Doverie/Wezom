using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ClientRequestLogic.Model;
using OfficeOpenXml;

namespace ClientRequestLogic
{
    public class ExelEditor
    {
        private string FilePath = "";
        private void CreateExel(string path)
        {
            
            using (ExcelPackage ePlus = new ExcelPackage(new FileInfo(path)))//
            {
                ePlus.Workbook.Properties.Title = "Wezom";
                var sheet = ePlus.Workbook.Worksheets.Add("Customers");
                int row = 1;
                int col = 1;
                sheet.Cells[row, col].Value = "Name";
                sheet.Cells[row, ++col].Value = "Last Name";
                sheet.Cells[row, ++col].Value = "Email";
                sheet.Cells[row, ++col].Value = "Count Of Tasks";
                sheet.Cells[row, ++col].Value = "Duration";
                sheet.Cells[row, ++col].Value = "Executed Tasks";
                sheet.Cells[row, ++col].Value = "% Of Executed Tasks";
                sheet.Cells[row, ++col].Value = "Duration Of Tasks";
                ePlus.Save();
            }
        }
        public bool SaveToFile(int countOfCustomers, string path)  
        {
            bool isSuccess = true;
            try
            {
                if (!System.IO.File.Exists(path))
                {
                    CustomersGenerator customersGenerator = new CustomersGenerator();
                    List<Customer> customers = customersGenerator.GenerateCustomers(countOfCustomers);
                    FilePath = path;
                    SaveToFile(customers);
                    System.Diagnostics.Process.Start(path);
                    return isSuccess;
                }
                else
                {
                    System.Diagnostics.Process.Start(path);
                    return isSuccess;
                }
            }
            catch (Exception e)
            {
                isSuccess = false;
                return isSuccess;
            }
        }

        public bool SaveToFile(List<Customer> customers) 
        {
            bool isSuccess = true;
            try
            {
                ExelEditor createExel = new ExelEditor();
                createExel.CreateExel(FilePath);
                using (ExcelPackage ePlus = new ExcelPackage(new FileInfo(FilePath)))
                {
                    ExcelWorkbook excelWorkBook = ePlus.Workbook;
                    ExcelWorksheet sheet = excelWorkBook.Worksheets.FirstOrDefault();

                    int row = 2;
                    int col = 1;
                    var countOfCustomers = customers.Count + 1;
                    sheet.Cells[String.Format("G2:G{0}", countOfCustomers)].Style.Numberformat.Format = "0%";
                    sheet.Cells[String.Format("H2:H{0}", countOfCustomers)].Style.Numberformat.Format = "0.0";
                    foreach (var item in customers)
                    {
                        sheet.Cells[row, col].Value = item.FirstName;
                        sheet.Cells[row, ++col].Value = item.LastName;
                        sheet.Cells[row, ++col].Value = item.Email;
                        sheet.Cells[row, ++col].Value = item.CountOfTasks;
                        sheet.Cells[row, ++col].Value = item.DurationHours;
                        sheet.Cells[row, ++col].Value = item.ExcecutedTasks;
                        sheet.Cells[row, ++col].Formula = String.Format("=F{0}/D{0}", row);
                        sheet.Cells[row, ++col].Formula = String.Format("=E{0}/F{0}", row);
                        col = 1;
                        row++;
                    }
                    ePlus.Save();
                }
                return isSuccess;
            }
            catch (Exception e)
            {
                isSuccess = false;
                return isSuccess;
            }
        }
    }
}
