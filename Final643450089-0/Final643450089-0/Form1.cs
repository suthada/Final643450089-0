using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final643450089_0
{
    public partial class Form1 : Form
    {
        //A02s a02s;
        //A21 a21;
        //A23 a23;
        //A52s a52s;
        //A71 a71;
        //A72 a72;
        //M12 m12;
        //M22 m22;
        //M32 m32;
        //S10Life s10Life;
        public Form1()
        {
            InitializeComponent();

        }


        //private void openToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    /*OpenFileDialog openFileDialog = new OpenFileDialog();
        //    openFileDialog.Filter = "CSV (*.csv) | *.csv";
        //    if (openFileDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        string[] readAllLine = File.ReadAllLines(openFileDialog.FileName);

        //        string readAllText = File.ReadAllText(openFileDialog.FileName);
        //        for (int i = 0; i < readAllLine.Length; i++)
        //        {
        //            string allDATARAW = readAllLine[i];
        //            string[] allDATASplited = allDATARAW.Split(',');
        //            this.dataGridView2.Rows.Add(allDATASplited[0], allDATASplited[1], allDATASplited[2], allDATASplited[3]);
        //        }
        //    }*/
        //}
        
        //private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    /*if (dataGridView2.Rows.Count > 0)
        //    {
        //        SaveFileDialog saveFileDialog = new SaveFileDialog();
        //        saveFileDialog.Filter = "CSV(*.csv)|*.csv";
        //        bool fileError = false;
        //        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        //        {
        //            if (!fileError)
        //            {
        //                try
        //                {
        //                    int columnCount = dataGridView2.Columns.Count;
        //                    string column = "";
        //                    string[] outputCSV = new string[dataGridView2.Rows.Count + 1];
        //                    for (int i = 0; i < columnCount; i++)
        //                    {
        //                        column += dataGridView2.Columns[i].HeaderText.ToString() + ",";
        //                    }
        //                    outputCSV[0] += column;
        //                    for (int i = 1; (i - 1) < dataGridView2.Rows.Count; i++)
        //                    {
        //                        for (int j = 0; j < columnCount; j++)
        //                        {
        //                            outputCSV[i] += dataGridView2.Rows[i - 1].Cells[j].Value.ToString() + ",";
        //                        }
        //                    }
        //                    File.WriteAllLines(saveFileDialog.FileName, outputCSV, Encoding.UTF8);
        //                }
        //                catch (Exception ex)
        //                {
        //                    MessageBox.Show("Error :" + ex.Message);
        //                }
        //            }
        //        }
        //    }*/
        //}
        //private void buttonSale_Click(object sender, EventArgs e)
        //{
        //    string NameProdutc = textBoxProduct.Text;
        //    string Price = textBoxPrice.Text;
        //    string TotalPrice = textBoxTotalPrice.Text;
        //    string Change = textBoxChange.Text;
        //    string Coupon = textBoxCoupon.Text;

        //    int n = dataGridView2.Rows.Add();

        //}
    }
}

