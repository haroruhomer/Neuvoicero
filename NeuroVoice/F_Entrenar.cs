using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuroVoice
{
    public partial class F_Entrenar : Form
    {
        public F_Entrenar()
        {
            InitializeComponent();
        }

        private void B_Examinar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = false;
            
            
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                DataTable dt=new DataTable();
                dt.Columns.Add("archivo");
                dt.Columns.Add("salida");
                DataRow row=dt.NewRow();
                TB_Carpeta.Text = fbd.SelectedPath;
                string[] archivos = System.IO.Directory.GetFiles(fbd.SelectedPath,"*.wma");
                foreach (String archivo in archivos)
                {
                    row[0] =System.IO.Path.GetFileName( archivo);
                    row[1] = "";
                    GV_Archivos.Rows.Add(row[0],row[1]);
                }
                    
//                    Console.WriteLine(ruta);
            }
            else
            {

            }
            fbd.Dispose();
        }

        private void B_Entrenar_Click(object sender, EventArgs e)
        {
            int[] sred=new int[3];//Estructura de red
            sred[0] = 1600;//Capa entrada
            sred[1] = int.Parse(TB_Ocultas.Text);// Capa Oculta
            sred[2] = 3;//Capa Salida

        }
    }
}
