using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace CAR_RENTAL.Classes
{
    class WordsHelper
    {
        private FileInfo _fileInfo;

        public WordsHelper(string fileName)
        {
            if (File.Exists(fileName))
            {
                _fileInfo = new FileInfo(fileName);
            }
            else
            {
                throw new ArgumentException("File not found");
            }
        }

        internal void ProcessIssuedCar(Dictionary<string, string> items, int idRentalCar, string nameCar , string[] idAdditionalServices,string[] nameAdditionalServices,string[] priceAdditionalServices)
        {
            Word.Application app = null;
            try
            {
                app = new Word.Application();
                Object file = _fileInfo.FullName;
                Object missing = Type.Missing;
                app.Documents.Open(file);
                foreach (var item in items)
                {
                    Word.Find find = app.Selection.Find;
                    find.Text = item.Key;
                    find.Replacement.Text = item.Value;

                    Object wrap = Word.WdFindWrap.wdFindContinue;
                    Object replace = Word.WdReplace.wdReplaceAll;

                    find.Execute(FindText: Type.Missing,
                        MatchCase: false,
                        MatchWholeWord: false,
                        MatchWildcards: false,
                        MatchSoundsLike: missing,
                        MatchAllWordForms: false,
                        Forward: true,
                        Wrap: wrap,
                        Format: false,
                        ReplaceWith: missing,
                        Replace: replace
                        );
                }
                Word.Table table = app.ActiveDocument.Tables[2];
                int rowNow = 3;
                for(int i = 0; i < idAdditionalServices.Length; i++)
                {
                    table.Rows.Add();
                    table.Cell(rowNow,1).Range.Text = idAdditionalServices[i];
                    table.Cell(rowNow, 2).Range.Text = nameAdditionalServices[i];
                    table.Cell(rowNow, 3).Range.Text = priceAdditionalServices[i];
                    rowNow++;
                }
                Object newFileName = Path.Combine(_fileInfo.DirectoryName, nameCar +"_"+ idRentalCar + ".doc");
                app.ActiveDocument.SaveAs2(newFileName);
                app.ActiveDocument.Close();
                app.Quit();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally
            {
                if (app != null) app.Quit();
            }
        }
        internal void ProcessReturnCarWithDamage(Dictionary<string, string> items, int idRentalCar, string nameCar, string[] idAdditionalServices, string[] nameAdditionalServices, string[] priceAdditionalServices)
        {
            Word.Application app = null;
            try
            {
                app = new Word.Application();
                Object file = _fileInfo.FullName;
                Object missing = Type.Missing;
                app.Documents.Open(file);
                foreach (var item in items)
                {
                    Word.Find find = app.Selection.Find;
                    find.Text = item.Key;
                    find.Replacement.Text = item.Value;

                    Object wrap = Word.WdFindWrap.wdFindContinue;
                    Object replace = Word.WdReplace.wdReplaceAll;

                    find.Execute(FindText: Type.Missing,
                        MatchCase: false,
                        MatchWholeWord: false,
                        MatchWildcards: false,
                        MatchSoundsLike: missing,
                        MatchAllWordForms: false,
                        Forward: true,
                        Wrap: wrap,
                        Format: false,
                        ReplaceWith: missing,
                        Replace: replace
                        );
                }
                Word.Table table = app.ActiveDocument.Tables[2];
                int rowNow = 3;
                for (int i = 0; i < idAdditionalServices.Length; i++)
                {
                    table.Rows.Add();
                    table.Cell(rowNow, 1).Range.Text = idAdditionalServices[i];
                    table.Cell(rowNow, 2).Range.Text = nameAdditionalServices[i];
                    table.Cell(rowNow, 3).Range.Text = priceAdditionalServices[i];
                    rowNow++;
                }
                Object newFileName = Path.Combine(_fileInfo.DirectoryName, nameCar + "_" + idRentalCar + ".doc");
                app.ActiveDocument.SaveAs2(newFileName);
                app.ActiveDocument.Close();
                app.Quit();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally
            {
                if (app != null) app.Quit();
            }
        }
        internal void ProcessReturnCarWithoutDriver(Dictionary<string, string> items, int idRentalCar, string nameCar, string[] idAdditionalServices, string[] nameAdditionalServices, string[] priceAdditionalServices, string[] idFines, string[] nameFines, string[] dateReceiptFines, string[] priceFines, string[] idDamages, string[] nameDamages, string[] amountDamages, string[] priceDamages)
        {
            Word.Application app = null;
            try
            {
                app = new Word.Application();
                Object file = _fileInfo.FullName;
                Object missing = Type.Missing;
                app.Documents.Open(file);
                foreach (var item in items)
                {
                    Word.Find find = app.Selection.Find;
                    find.Text = item.Key;
                    find.Replacement.Text = item.Value;

                    Object wrap = Word.WdFindWrap.wdFindContinue;
                    Object replace = Word.WdReplace.wdReplaceAll;

                    find.Execute(FindText: Type.Missing,
                        MatchCase: false,
                        MatchWholeWord: false,
                        MatchWildcards: false,
                        MatchSoundsLike: missing,
                        MatchAllWordForms: false,
                        Forward: true,
                        Wrap: wrap,
                        Format: false,
                        ReplaceWith: missing,
                        Replace: replace
                        );
                }
                Word.Table table = app.ActiveDocument.Tables[2];
                int rowNow = 3;
                for (int i = 0; i < idAdditionalServices.Length; i++)
                {
                    table.Rows.Add();
                    table.Cell(rowNow, 1).Range.Text = idAdditionalServices[i];
                    table.Cell(rowNow, 2).Range.Text = nameAdditionalServices[i];
                    table.Cell(rowNow, 3).Range.Text = priceAdditionalServices[i];
                    rowNow++;
                }
                table = app.ActiveDocument.Tables[4];
                rowNow = 3;
                for (int i = 0; i < idDamages.Length; i++)
                {
                    table.Rows.Add();
                    table.Cell(rowNow, 1).Range.Text = idDamages[i];
                    table.Cell(rowNow, 2).Range.Text = nameDamages[i];
                    table.Cell(rowNow, 3).Range.Text = amountDamages[i];
                    table.Cell(rowNow, 4).Range.Text = priceDamages[i];
                    table.Cell(rowNow, 5).Range.Text = (Convert.ToInt32(amountDamages[i]) * Convert.ToInt32(priceDamages[i])).ToString();
                    rowNow++;
                }
                table = app.ActiveDocument.Tables[6];
                rowNow = 3;
                for (int i = 0; i < idFines.Length; i++)
                {
                    table.Rows.Add();
                    table.Cell(rowNow, 1).Range.Text = idFines[i];
                    table.Cell(rowNow, 2).Range.Text = nameFines[i];
                    table.Cell(rowNow, 3).Range.Text = dateReceiptFines[i];
                    table.Cell(rowNow, 4).Range.Text = priceFines[i];
                    rowNow++;
                }
                Object newFileName = Path.Combine(_fileInfo.DirectoryName, nameCar + "_" + idRentalCar + ".doc");
                app.ActiveDocument.SaveAs2(newFileName);
                app.ActiveDocument.Close();
                app.Quit();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally
            {
                if (app != null) app.Quit();
            }
        }

        internal void ProcessReportDriverOfPeriod(Dictionary<string, string> items, List<fc_OutputDriverWorkOfPeriodForPrint_Result> DataDriverWorkOfPeriod, string[] amountHoursAndMinute, string priceDriver,string driverId, string fullNameDriver,string periodStart,string periodEnd)
        {
            Word.Application app = null;
            try
            {
                app = new Word.Application();
                Object file = _fileInfo.FullName;
                Object missing = Type.Missing;
                app.Documents.Open(file);
                foreach (var item in items)
                {
                    Word.Find find = app.Selection.Find;
                    find.Text = item.Key;
                    find.Replacement.Text = item.Value;

                    Object wrap = Word.WdFindWrap.wdFindContinue;
                    Object replace = Word.WdReplace.wdReplaceAll;

                    find.Execute(FindText: Type.Missing,
                        MatchCase: false,
                        MatchWholeWord: false,
                        MatchWildcards: false,
                        MatchSoundsLike: missing,
                        MatchAllWordForms: false,
                        Forward: true,
                        Wrap: wrap,
                        Format: false,
                        ReplaceWith: missing,
                        Replace: replace
                        );
                }
                Word.Table table = app.ActiveDocument.Tables[1];
                int rowNow = 2,check = 0;
                foreach(var data in DataDriverWorkOfPeriod) { 
                    table.Rows.Add();
                    table.Cell(rowNow, 1).Range.Text = data.RentalCarId.ToString();
                    table.Cell(rowNow, 2).Range.Text = data.DaysWork.ToString();
                    table.Cell(rowNow, 3).Range.Text = amountHoursAndMinute[check];
                    table.Cell(rowNow, 4).Range.Text = priceDriver;
                    table.Cell(rowNow, 5).Range.Text = data.PriceDriverInRentalCar.ToString();
                    table.Cell(rowNow, 6).Range.Text = data.FullPriceFines.ToString();
                    table.Cell(rowNow, 7).Range.Text = data.FullPriceDamages.ToString();
                    table.Cell(rowNow, 8).Range.Text = data.FullPriceRentalCar.ToString();
                    rowNow++;
                    check++;
                }
                Object newFileName = Path.Combine(_fileInfo.DirectoryName,$"{driverId}_{fullNameDriver}_{periodStart}_{periodEnd}.doc"); 
                app.ActiveDocument.SaveAs2(newFileName);
                app.ActiveDocument.Close();
                app.Quit();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally
            {
                if (app != null) app.Quit();
            }
        }
    }
}
