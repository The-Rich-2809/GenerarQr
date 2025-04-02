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
            Caja.FileName = txtCodigo.Text + ".png";
            Caja.ShowDialog();
            if (!string.IsNullOrEmpty(Caja.FileName))
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
                try
                {
                    string Code = fila.Cells[0].Value.ToString();

                    BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
                    Codigo.IncludeLabel = true;
                    pbCodigoBarras.Image = Codigo.Encode(BarcodeLib.TYPE.CODE128, Code, Color.Black, Color.White, 200, 100);

                    Image imgFinal = (Image)pbCodigoBarras.Image.Clone();

                    SaveFileDialog Caja = new SaveFileDialog();
                    Caja.AddExtension = true;
                    Caja.FileName = Code + ".png";
                    Caja.ShowDialog();
                    if (!string.IsNullOrEmpty(Caja.FileName))
                    {
                        imgFinal.Save(Caja.FileName, ImageFormat.Png);
                    }
                    imgFinal.Dispose();
                }
                catch
                {

                }
            }
        }
    }
}
