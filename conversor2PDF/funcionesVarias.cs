using System;
using System.Windows.Forms;

namespace conversor2PDF
{
    class funcionesVarias
    {
        public static void liberarObjet(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }

            catch (Exception exlibObjet)
            {
                obj = null;
            }
            finally
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }
    }
    class consola
    {
        private TextBox tx;
        public consola(TextBox txb)
        {
            this.tx = txb;
        }
        public void escribir(string linea, bool inicioLinea)
        {
            if (linea == "limpiar")
            {
                tx.Text = "";
            }
            else
            {
                if (inicioLinea)
                    tx.Text += "--> " + linea;
                else
                    tx.Text += " " + linea;

            }
            tx.SelectionStart = tx.Text.Length - 1;
            tx.Focus();
            tx.ScrollToCaret();
        }
        public void salto()
        {
            tx.Text += System.Environment.NewLine;
            tx.SelectionStart = tx.Text.Length - 1;
            tx.Focus();
            tx.ScrollToCaret();
        }
    }
}
