using System;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtProductName.Text;
                double qty = double.Parse(txtQty.Text);
                double price = double.Parse(txtPrice.Text);
                double total = qty * price;

                // Add row to DataGridView
                dataGridView1.Rows.Add(name, qty, price, total);

                CalculateGrandTotal();
                ClearInputs();
            }
            catch (Exception)
            {
                MessageBox.Show("ກະລຸນາປ້ອນຂໍ້ມູນໃຫ້ຖືກຕ້ອງ (Please enter valid numbers)");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (!row.IsNewRow) dataGridView1.Rows.Remove(row);
                }
                CalculateGrandTotal();
            }
        }

        private void CalculateGrandTotal()
        {
            double grandTotal = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[3].Value != null)
                {
                    grandTotal += Convert.ToDouble(row.Cells[3].Value);
                }
            }
            lblTotalDisplay.Text = grandTotal.ToString("N0");
        }

        private void ClearInputs()
        {
            txtProductName.Clear();
            txtQty.Clear();
            txtPrice.Clear();
            txtProductName.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}