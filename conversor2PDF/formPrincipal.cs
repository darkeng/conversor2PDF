using System;
using System.Windows.Forms;

namespace conversor2PDF
{
    public partial class formPrincipal : Form
    {
        private datos dts;
        consola consol;
        private string FichDestino = "";
        private conversor conversor;
        public formPrincipal()
        {
            InitializeComponent();
            consol = new consola(this.txConsola);
            conversor = new conversor(consol);
        }

        private void btAbrirOrigen_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Seleccione los archivos que desea convertir";
            fileDialog.Multiselect = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                dts = new datos();
                dts.llenarDatos(fileDialog.FileNames);
                lbWorld.Text = dts.worlds.Count.ToString();
                lbExel.Text = dts.exels.Count.ToString();
                lbPowerP.Text = dts.powerps.Count.ToString();
                lbOtros.Text = dts.otros.ToString();
                consol.escribir(fileDialog.FileNames.Length + "archivos seleccionados...", true);
                consol.salto();
            }

            //FolderBrowserDialog dialog = new FolderBrowserDialog();
            //dialog.Description = "Elija el directorio de origen";
            //dialog.ShowNewFolderButton = false;
            //if (dialog.ShowDialog() == DialogResult.OK)
            //{
            //    txEntrada.Text = dialog.SelectedPath;
            //    dts = new datos();
            //    dts.llenarDatos(dialog.SelectedPath);
            //    lbWorld.Text = dts.worlds.Count.ToString();
            //    lbExel.Text = dts.exels.Count.ToString();
            //    lbPowerP.Text = dts.powerps.Count.ToString();
            //    lbOtros.Text = dts.otros.ToString();
            //    consol.escribir("Directorio de origen seleccionado: "+dialog.SelectedPath, true);
            //    consol.salto();
            //}
        }

        private void btAbrirDestino_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Elija el directorio de destino";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txSalida.Text = dialog.SelectedPath;
                FichDestino = dialog.SelectedPath;
                consol.escribir("Directorio de destino seleccionado: " + dialog.SelectedPath, true);
                consol.salto();
            }
        }

        private void btConvertir_Click(object sender, EventArgs e)
        {
            if (dts.todos.Length <=0)
            {
                MessageBox.Show("Aun no has seleccionado ningun archivo", "Todavia no...");
            }
            else
                if (txSalida.Text == "")
                {
                    MessageBox.Show("Elige un directorio de salida", "Falta algo...");
                }
                else
                    if (chkWorld.Checked == false && chkExel.Checked == false &&
                        chkPowerPoint.Checked == false)
                    {
                        MessageBox.Show("Elige al menos un tipo de archivo a convertir", "Áun falta algo...");
                    }
                    else
                    {
                        conversor.convertir(dts, FichDestino, chkWorld.Checked, chkExel.Checked, chkPowerPoint.Checked);
                    }
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
