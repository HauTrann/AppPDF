using App.report;
using Newtonsoft.Json;
using PerpetuumSoft.Reporting.Components;
using PerpetuumSoft.Reporting.DOM;
using PerpetuumSoft.Reporting.Export;
using PerpetuumSoft.Reporting.Export.Pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace App
{
    public class GenPDF
    {

        private string DANG_KY_DU_TUYEN = "DANG_KY_DU_TUYEN";
        private string PHIEU_HEN = "PHIEU_HEN";

        public void getPDF(string name, string jsonObject, string preNameFile)
        {
            try
            {
                using (ReportManager reportManager1 = new PerpetuumSoft.Reporting.Components.ReportManager())
                {
                    reportManager1.DataSources = new PerpetuumSoft.Reporting.Components.ObjectPointerCollection(new string[0], new object[0]);
                    using (FileReportSlot fileReportSlot2 = new PerpetuumSoft.Reporting.Components.FileReportSlot())
                    {
                        reportManager1.Reports.AddRange(new PerpetuumSoft.Reporting.Components.ReportSlot[] { fileReportSlot2 });
                        fileReportSlot2.FilePath = "";
                        fileReportSlot2.ReportName = "";
                        fileReportSlot2.ReportScriptType = typeof(PerpetuumSoft.Reporting.Rendering.ReportScriptBase);
                        Object obj = null;
                        string nameFile = "";
                        if (name.Equals(DANG_KY_DU_TUYEN))
                        {
                            nameFile = "DangKyDuTuyen";
                            obj = Newtonsoft.Json.JsonConvert.DeserializeObject<DangKyThongTin>(jsonObject);
                        }
                        else if (name.Equals("PHIEU_HEN"))
                        {
                            nameFile = "PhieuHen";
                            obj = Newtonsoft.Json.JsonConvert.DeserializeObject<PhieuHen>(jsonObject);
                        }

                        string path = System.IO.Path.GetDirectoryName(
                            System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Replace("file:\\", "");
                        if (File.Exists(string.Format("{0}\\report\\" + nameFile + "Clone.rst", path)))
                        {
                            File.Delete(string.Format("{0}\\report\\" + nameFile + "Clone.rst", path));
                        }

                        File.Copy(string.Format("{0}\\report\\" + nameFile + ".rst", path), string.Format("{0}\\report\\" + nameFile + "Clone.rst", path));
                        File.WriteAllText("checkPath.txt", path);
                        fileReportSlot2.FilePath = string.Format("{0}\\report\\" + nameFile + "Clone.rst", path);

                        fileReportSlot2.Manager.DataSources.Remove("Data");
                        fileReportSlot2.Manager.DataSources.Clear();
                        fileReportSlot2.Manager.DataSources.Add("Data", obj);
                        //File.WriteAllText("exascsa.txt", JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.None,
                        //                                                                        new JsonSerializerSettings
                        //                                                                        {
                        //                                                                            NullValueHandling = NullValueHandling.Ignore

                        //                                                                        }));

                        fileReportSlot2.LoadReport();
                        Document document = fileReportSlot2.RenderDocument();
                        fileReportSlot2.SaveReport(document);
                        ExportFilter filter = new PdfExportFilter
                        {
                            AllowChangingDocument = true
                        };
                        filter.Export(document, path + "\\" + preNameFile + "value.pdf", false);
                        fileReportSlot2.Dispose();
                        filter.Dispose();
                        if (File.Exists(string.Format("{0}\\report\\" + preNameFile + nameFile + "Clone.rst", path)))
                        {
                            File.Delete(string.Format("{0}\\report\\" + preNameFile + nameFile + "Clone.rst", path));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                File.WriteAllText("err.txt", ex.Message);
            }
        }


    }
}
