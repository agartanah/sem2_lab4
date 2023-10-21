using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sem2_lab4 {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    int countRow = 1;
    int countColumn = 1;

    double?[,] arr;

    private void Form1_Load(object sender, EventArgs e) {
      dataGridView1.Rows[0].HeaderCell.Value = "1";

      dataGridView2.AllowUserToAddRows = false;

      label1.Text = string.Empty;
    }

    private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e) {
      ++countRow;

      dataGridView1.Rows[e.RowIndex].HeaderCell.Value = countRow.ToString();
    }

    private void button1_Click(object sender, EventArgs e) {
      ReadDataGrid();

      if (checkBox1.Checked) {
        double?[,] arrBubble = SortMethods.BubbleSort(arr);

        WriteToGrid(arrBubble);

        label1.Text += $"Время выполнения библа: {SortMethods.timeExecution[0]}\n\n";
      }
    }

    private void ReadDataGrid() {
      int columnCount = dataGridView1.ColumnCount;
      int rowCount;

      List<int> rowCountList = new List<int>();
      List<int> columnCountList = new List<int>();

      for (int indexColumn = 0; indexColumn < dataGridView1.ColumnCount; ++indexColumn) {
        rowCount = dataGridView1.RowCount;

        for (int indexRow = 0; indexRow < dataGridView1.RowCount; ++indexRow) {
          if (dataGridView1[indexColumn, indexRow].Value == null) {
            --rowCount;
          }
        }

        if (rowCount > 0) {
          rowCountList.Add(rowCount);
        } else {
          --columnCount;
        }
      }

      arr = new double?[rowCountList.Max(), columnCount];

      int indexColumnArr = 0, indexRowArr = 0;

      for (int indexColumn = 0; indexColumn < dataGridView1.ColumnCount; ++indexColumn) {

        for (int indexRow = 0; indexRow < dataGridView1.RowCount; ++indexRow) {
          if (dataGridView1[indexColumn, indexRow].Value != null) {
            arr[indexRowArr, indexColumnArr] = Convert.ToDouble(dataGridView1[indexColumn, indexRow].Value.ToString());

            ++indexColumnArr;

            if (indexColumnArr >= arr.GetLength(1)) {
              indexColumnArr = 0;

              ++indexRowArr;
            }
          }
        }
      }
    }

    private void WriteToGrid(double?[,] arr) {
      dataGridView2.Columns.Clear();

      for (int indexColumn = 0; indexColumn < arr.GetLength(1); ++indexColumn) {
        dataGridView2.Columns.Add((indexColumn + 1).ToString(), (indexColumn + 1).ToString());
      }

      for (int indexRow = 0; indexRow < arr.GetLength(0); ++indexRow) {
        dataGridView2.Rows.Add();

        dataGridView2.Rows[indexRow].HeaderCell.Value = (indexRow + 1).ToString();
      }

      for (int indexColumn = 0; indexColumn < arr.GetLength(0); ++indexColumn) {
        for (int indexRow = 0; indexRow < arr.GetLength(1); ++indexRow) {
          dataGridView2[indexRow, indexColumn].Value = arr[indexColumn, indexRow].ToString();
        }
      }
    }

    private void button2_Click(object sender, EventArgs e) {
      ++countColumn;

      dataGridView1.Columns.Add(countColumn.ToString(), countColumn.ToString());

      if (countRow == 0) {
        ++countRow;
      }
    }

    private void button3_Click(object sender, EventArgs e) {
      dataGridView1.Columns.RemoveAt(countColumn - 1);

      --countColumn;

      if (countColumn == 0) {
        countRow = 0;
      } 
    }

    private void button4_Click(object sender, EventArgs e) {
      dataGridView2.Columns.Clear();
    }
  }
}
