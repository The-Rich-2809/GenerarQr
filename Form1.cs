using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarcodeLib;
using System.Drawing.Imaging;

namespace GenerarQr
{
    public partial class Form1 : Form
    {
        public static List<string> miLista = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void GenerarBtn_Click(object sender, EventArgs e)
        {
            BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
            Codigo.IncludeLabel = true;
            pbCodigoBarras.Image = Codigo.Encode(BarcodeLib.TYPE.CODE128, txtCodigo.Text, Color.Black, Color.White, 200, 100);
        }
            

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            Image imgFinal = (Image)pbCodigoBarras.Image.Clone();

            SaveFileDialog Caja = new SaveFileDialog();
            Caja.AddExtension = true;
            Caja.ShowDialog();
            if(!string.IsNullOrEmpty(Caja.FileName))
            {
                imgFinal.Save(Caja.FileName, ImageFormat.Png);
            }
            imgFinal.Dispose();
        }

        private void ImportarBtn_Click(object sender, EventArgs e)
        {

            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Archivos de Excel|*.xlsx|Archivos de Excel 97-2003|*.xls" })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)

                    {
                        using (var stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read))

                        {
                            using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))

                            {
                                var dataSet = reader.AsDataSet(new ExcelDataSetConfiguration()
                                {
                                    ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()


                                    {
                                        UseHeaderRow = true

                                    }
                                });

                                dataGridView1.DataSource = dataSet.Tables[0];
                            }

                        }

                        dataGridView1.Columns[0].HeaderText = "Equipo";
                        dataGridView1.Columns[1].HeaderText = "Marca";
                        dataGridView1.Columns[2].HeaderText = "Serie";

                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        dataGridView1.AutoResizeColumns();
                        dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11);


                    }

                }

            }

        }


        private void ExportarBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                string Codigo = fila.Cells[2].Value.ToString();

                Zen.Barcode.Code128BarcodeDraw mGeneradorCB = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                pbCodigoBarras.Image = mGeneradorCB.Draw(Codigo, 60);

                var codigoBarras = pbCodigoBarras.Image;
                var imagenCompleta = new Bitmap(codigoBarras.Width, codigoBarras.Height + 20);
                var x = imagenCompleta.Width / 2;
                var y = imagenCompleta.Height;

                using (var grafic = Graphics.FromImage(imagenCompleta))
                using (var sFormat = new StringFormat()
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Far,
                })
                {
                    grafic.Clear(Color.Transparent);
                    grafic.DrawImage(codigoBarras, 2, 2);
                    grafic.DrawString(Codigo, new Font("Arial", 10),
                        Brushes.Black, x, y, sFormat);
                }
                pbCodigoBarras.Image = imagenCompleta;

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                saveFileDialog.FileName = Codigo + ".png";

                if (saveFileDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string codigo_barras = saveFileDialog.FileName;
                    Bitmap bitmap = new Bitmap(pbCodigoBarras.Image);
                    bitmap.Save(codigo_barras);
                }
            }
        }
    }
}
