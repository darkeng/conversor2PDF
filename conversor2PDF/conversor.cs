using Microsoft.Office.Core;
using System;
using System.Collections.Generic;
using System.IO;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Word = Microsoft.Office.Interop.Word;

namespace conversor2PDF
{
    class conversor
    {
        private consola consola;
        static int codigoC = -1;
        public conversor(consola consol)
        {
            this.consola = consol;
        }
        public int convertir(datos _datos, string dirSalida, bool world, bool excel, bool powerp)
        {
            consola.escribir("Opreacion \"Convertir\" iniciada...", true);
            consola.salto();
            if (world)
            {
                consola.escribir("Procesando archivos WORD", true);
                consola.salto();
                int docsOK=convertWorld2pdf(_datos.worlds, dirSalida);
                consola.escribir(docsOK + " documentos (*.doc, *.docx, *.txt, *.xml, *.odt) convertidos", true);
                consola.salto();
            }
            if (excel)
            {
                consola.escribir("Procesando archivos EXCEL", true);
                consola.salto();
                int docsOK = convertExeld2pdf(_datos.exels, dirSalida);
                consola.escribir(docsOK + " documentos (*.xls, *.xlsx, *.csv) convertidos", true);
                consola.salto();
            }
            if (powerp)
            {
                consola.escribir("Procesando archivos POWER POINT", true);
                consola.salto();
                int docsOK = convertPowerp2pdf(_datos.powerps, dirSalida);
                consola.escribir(docsOK + " documentos (*.ppt, *.pptx) convertidos", true);
                consola.salto();
            }
            consola.escribir("Opreacion \"Convertir\" terminada...", true);
            consola.salto();
            return codigoC;
        }
        private int convertWorld2pdf(List<string> wrl, string dirsal)
        {
            Word.Application msWordDoc = null;
            object objVacio = System.Reflection.Missing.Value;
            int code = 0;
            try
            {
                //iniiar aplicacion de word de forma oculta
                msWordDoc = new Microsoft.Office.Interop.Word.Application
                {
                    Visible = false,
                    ScreenUpdating = false
                };
            }
            catch (Exception e) { consola.escribir("Error al abrir MSWord", true); consola.salto(); return -1; }

            for (int i = 0; i < wrl.Count; i++)
            {
                string entrada = wrl[i];
                consola.escribir("Convirtiendo: " + entrada, true);
                string archSalida = Path.GetFileNameWithoutExtension(wrl[i]) + ".pdf";
                string salida = Path.Combine(dirsal, archSalida);

                Word.Document doc = null;

                try
                {
                    //abrir el archivo
                    object archivoDoc = (object)entrada;
                    doc = msWordDoc.Documents.Open(ref archivoDoc, ref objVacio,
                                                   ref objVacio, ref objVacio, ref objVacio, ref objVacio, ref objVacio,
                                                   ref objVacio, ref objVacio, ref objVacio, ref objVacio, ref objVacio,
                                                   ref objVacio, ref objVacio, ref objVacio, ref objVacio);
                    if (doc != null)
                    {
                        doc.Activate();

                        // guardar el documento como PDF
                        object fileFormat = Word.WdSaveFormat.wdFormatPDF;
                        object pdfPath = (object)salida;
                        doc.SaveAs(ref pdfPath,
                                   ref fileFormat, ref objVacio, ref objVacio,
                                   ref objVacio, ref objVacio, ref objVacio, ref objVacio,
                                   ref objVacio, ref objVacio, ref objVacio, ref objVacio,
                                   ref objVacio, ref objVacio, ref objVacio, ref objVacio);
                        consola.escribir("OK", false);
                        consola.salto();
                        code += 1;
                    }
                    else
                    {
                        consola.escribir(" fallo", false);
                        consola.salto();
                    }
                }
                catch (Exception exWord2Pdf)
                {
                    consola.escribir(" OK-ex", false);
                    consola.salto();
                }
                finally
                {
                    // cerrar el documento descartando los cambios.
                    if (doc != null)
                    {
                        object saveChanges = Word.WdSaveOptions.wdDoNotSaveChanges;
                        try
                        {
                            doc.Close(ref saveChanges, ref objVacio, ref objVacio);
                        }
                        catch (Exception eded) { }
                        funcionesVarias.liberarObjet(doc);
                    }
                }
            }
            try
            {
                // salir de word y liberar el objeto que representa la apliacion.
                ((Word._Application)msWordDoc).Quit(ref objVacio, ref objVacio, ref objVacio);
                funcionesVarias.liberarObjet(msWordDoc);
                msWordDoc = null;
            }
            catch (Exception ex) { }
            return code;
        }
        private int convertExeld2pdf(List<string> exc, string dirsal)
        {
            int code = 0;
            Microsoft.Office.Interop.Excel.Application excelApplication = null;
            Microsoft.Office.Interop.Excel.Workbook excelDoc = null;
            object ningunTipo = Type.Missing;
            try
            {
                //abrir la aplicacion de Excel en modo oculto
                excelApplication = new Microsoft.Office.Interop.Excel.Application
                {
                    ScreenUpdating = false,
                    DisplayAlerts = false
                };
            }
            catch (Exception e) { consola.escribir("Error al abrir MSExcel", true); consola.salto(); return -1; }


            for (int i = 0; i < exc.Count; i++)
            {
                string entrada = exc[i];
                consola.escribir("Convirtiendo: " + entrada, true);
                string archSalida = Path.GetFileNameWithoutExtension(exc[i]) + ".pdf";
                string salida = Path.Combine(dirsal, archSalida);

                try
                {
                    //abrir archivo de excel
                    if (excelApplication != null)
                        excelDoc = excelApplication.Workbooks.Open(entrada, ningunTipo, ningunTipo,
                                                                        ningunTipo, ningunTipo, ningunTipo,
                                                                        ningunTipo, ningunTipo, ningunTipo,
                                                                        ningunTipo, ningunTipo, ningunTipo,
                                                                        ningunTipo, ningunTipo, ningunTipo);
                    if (excelDoc != null)
                    {
                        // llamado a las funciones nativas de Excel para la exportacion de archivos (valido en Office 2007 y Office 2010)
                        excelDoc.ExportAsFixedFormat(Microsoft.Office.Interop.Excel.XlFixedFormatType.xlTypePDF,
                                                          salida,
                                                          ningunTipo, ningunTipo, ningunTipo, ningunTipo, ningunTipo,
                                                          ningunTipo, ningunTipo);
                        consola.escribir("OK", false);
                        consola.salto();
                        code += 1;
                    }
                    else
                    {
                        consola.escribir(" fallo", false);
                        consola.salto();
                    }

                }
                catch (Exception exExcel2Pdf)
                {
                    consola.escribir(" OK-ex", false);
                    consola.salto();
                }
                finally
                {
                    // cerrar el documento de excel descartando cambios en el archivo
                    try
                    {
                        if (excelDoc != null)
                            excelDoc.Close(ningunTipo, ningunTipo, ningunTipo);
                    }
                    catch (Exception expcsa) { }
                    funcionesVarias.liberarObjet(excelDoc);
                }
            }
            try
            {
                if (excelApplication != null) excelApplication.Quit();
                funcionesVarias.liberarObjet(excelApplication);
            }
            catch (Exception exep) { }
            return code;
        }
        private int convertPowerp2pdf(List<string> pwr, string dirsal)
        {
            PowerPoint.Application pptApplication = null;
            PowerPoint.Presentation pptPresentation = null;

            object unknownType = Type.Missing;
            try 
            {
                //Abrir aplicacion de PowerPoint
                pptApplication = new PowerPoint.Application();
            }
            catch (Exception exect) { }
            int code = 0;
            for (int i = 0; i < pwr.Count; i++)
            {
                string entrada = pwr[i];
                consola.escribir("Convirtiendo: " + entrada, true);
                string archSalida = Path.GetFileNameWithoutExtension(pwr[i]) + ".pdf";
                string salida = Path.Combine(dirsal, archSalida);

                try
                {
                    //abrir el docuemento de PowerPoint
                    pptPresentation = pptApplication.Presentations.Open(entrada,
                                                                        MsoTriState.msoTrue,
                                                                        MsoTriState.msoTrue,
                                                                        MsoTriState.msoFalse);


                    //exportar documento a PDF
                    if (pptPresentation != null)
                    {
                        pptPresentation.ExportAsFixedFormat(salida,
                                                             PowerPoint.PpFixedFormatType.ppFixedFormatTypePDF,
                                                             PowerPoint.PpFixedFormatIntent.ppFixedFormatIntentPrint,
                                                             MsoTriState.msoFalse,
                                                             PowerPoint.PpPrintHandoutOrder.ppPrintHandoutVerticalFirst,
                                                             PowerPoint.PpPrintOutputType.ppPrintOutputSlides,
                                                             MsoTriState.msoFalse, null,
                                                             PowerPoint.PpPrintRangeType.ppPrintAll, string.Empty,
                                                             true, true, true, true, false, unknownType);
                        consola.escribir("OK", false);
                        consola.salto();
                        code += 1;
                    }
                    else
                    {
                        consola.escribir(" fallo", false);
                        consola.salto();
                    }
                }
                catch (Exception exPowerPoint2Pdf)
                {
                    consola.escribir(" fallo", false);
                    consola.salto();
                }
                finally
                {
                    // cerrar y liberar documento
                    if (pptPresentation != null)
                    {
                        try
                        {
                            pptPresentation.Close();
                        }
                        catch (Exception dedsa) { }
                        funcionesVarias.liberarObjet(pptPresentation);
                        pptPresentation = null;
                    }

                }
            }
            try
            {
                // cerrar aplicacion y liberar objeto que lo representa
                pptApplication.Quit();
                funcionesVarias.liberarObjet(pptApplication);
                pptApplication = null;
            }
            catch (Exception ex) { }

                return code;
        }
    }
}
