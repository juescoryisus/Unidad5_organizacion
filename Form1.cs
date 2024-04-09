//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Organizacioness
//{
//    public partial class Form1 : Form
//    {
//        public Form1()
//        {
//            InitializeComponent();
//        }

//        private void Form1_Load(object sender, EventArgs e)
//        {

//        }
//    }
//}
using System;
using System.IO;
using System.Windows.Forms;
using System.Linq;

namespace Organizacioness
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargarCarpeta_Click_1(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Selecciona las carpetas";
                folderDialog.RootFolder = Environment.SpecialFolder.Desktop;
                folderDialog.ShowNewFolderButton = false;
                folderDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string[] selectedFolders = folderDialog.SelectedPath.Split(';');
                    CargarArchivosEnLista(selectedFolders);
                }
            }
        }

        private void CargarArchivosEnLista(string[]folders)
        {
            listBox1.Items.Clear();

            try
            {
                foreach (var folder in folders)
                {
                    var files = Directory.GetFiles(folder);
                    foreach (var file in files)
                    {
                        listBox1.Items.Add(file);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar archivos: " + ex.Message);
            }
        }

        private void btnOrdenar_Click_1(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                listBox1.Sorted = true;
            }
            else
            {
                MessageBox.Show("Primero carga una carpeta para ordenar los archivos.");
            }
        }

        private void btnOrdenar_por_fecha_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                var files = listBox1.Items.Cast<string>().OrderBy(f => File.GetCreationTime(f)).ToArray();
                listBox1.Items.Clear();
                listBox1.Items.AddRange(files);
            }
            else
            {
                MessageBox.Show("Primero carga una carpeta para ordenar los archivos.");
            }
        }

    }
}
