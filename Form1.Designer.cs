namespace sem2_lab4 {
  partial class Form1 {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent() {
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.checkBox2 = new System.Windows.Forms.CheckBox();
      this.checkBox3 = new System.Windows.Forms.CheckBox();
      this.checkBox4 = new System.Windows.Forms.CheckBox();
      this.checkBox5 = new System.Windows.Forms.CheckBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.button1 = new System.Windows.Forms.Button();
      this.dataGridView2 = new System.Windows.Forms.DataGridView();
      this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.label1 = new System.Windows.Forms.Label();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.radioButton1 = new System.Windows.Forms.RadioButton();
      this.radioButton2 = new System.Windows.Forms.RadioButton();
      this.button5 = new System.Windows.Forms.Button();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.label2 = new System.Windows.Forms.Label();
      this.fileNameExcel = new System.Windows.Forms.TextBox();
      this.readFileExcel = new System.Windows.Forms.Button();
      this.rangeExcel = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.randArrCountRows = new System.Windows.Forms.TextBox();
      this.randArrCountColumns = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.randArrMinVal = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.randArrMaxVal = new System.Windows.Forms.TextBox();
      this.button6 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
      this.dataGridView1.Location = new System.Drawing.Point(12, 12);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowHeadersWidth = 51;
      this.dataGridView1.RowTemplate.Height = 24;
      this.dataGridView1.Size = new System.Drawing.Size(688, 339);
      this.dataGridView1.TabIndex = 0;
      this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
      // 
      // Column1
      // 
      this.Column1.HeaderText = "1";
      this.Column1.MinimumWidth = 6;
      this.Column1.Name = "Column1";
      this.Column1.Width = 125;
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.checkBox1.Location = new System.Drawing.Point(22, 15);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(230, 24);
      this.checkBox1.TabIndex = 1;
      this.checkBox1.Text = "Сортировка Пузырьком";
      this.checkBox1.UseVisualStyleBackColor = true;
      // 
      // checkBox2
      // 
      this.checkBox2.AutoSize = true;
      this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.checkBox2.Location = new System.Drawing.Point(22, 55);
      this.checkBox2.Name = "checkBox2";
      this.checkBox2.Size = new System.Drawing.Size(229, 24);
      this.checkBox2.TabIndex = 2;
      this.checkBox2.Text = "Сортировка Вставками";
      this.checkBox2.UseVisualStyleBackColor = true;
      // 
      // checkBox3
      // 
      this.checkBox3.AutoSize = true;
      this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.checkBox3.Location = new System.Drawing.Point(22, 94);
      this.checkBox3.Name = "checkBox3";
      this.checkBox3.Size = new System.Drawing.Size(230, 24);
      this.checkBox3.TabIndex = 3;
      this.checkBox3.Text = "Шейкерная Сортировка";
      this.checkBox3.UseVisualStyleBackColor = true;
      // 
      // checkBox4
      // 
      this.checkBox4.AutoSize = true;
      this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.checkBox4.Location = new System.Drawing.Point(22, 133);
      this.checkBox4.Name = "checkBox4";
      this.checkBox4.Size = new System.Drawing.Size(210, 24);
      this.checkBox4.TabIndex = 4;
      this.checkBox4.Text = "Быстрая Сортировка";
      this.checkBox4.UseVisualStyleBackColor = true;
      // 
      // checkBox5
      // 
      this.checkBox5.AutoSize = true;
      this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.checkBox5.Location = new System.Drawing.Point(22, 167);
      this.checkBox5.Name = "checkBox5";
      this.checkBox5.Size = new System.Drawing.Size(280, 24);
      this.checkBox5.TabIndex = 5;
      this.checkBox5.Text = "Случайная (Bogo) сортировка";
      this.checkBox5.UseVisualStyleBackColor = true;
      // 
      // panel1
      // 
      this.panel1.AutoScroll = true;
      this.panel1.Controls.Add(this.checkBox1);
      this.panel1.Controls.Add(this.checkBox5);
      this.panel1.Controls.Add(this.checkBox2);
      this.panel1.Controls.Add(this.checkBox4);
      this.panel1.Controls.Add(this.checkBox3);
      this.panel1.Location = new System.Drawing.Point(995, 46);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(381, 207);
      this.panel1.TabIndex = 6;
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.button1.Location = new System.Drawing.Point(713, 128);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(282, 109);
      this.button1.TabIndex = 7;
      this.button1.Text = "СОРТИРОВАТЬ";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // dataGridView2
      // 
      this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
      this.dataGridView2.Location = new System.Drawing.Point(12, 379);
      this.dataGridView2.Name = "dataGridView2";
      this.dataGridView2.RowHeadersWidth = 51;
      this.dataGridView2.RowTemplate.Height = 24;
      this.dataGridView2.Size = new System.Drawing.Size(688, 310);
      this.dataGridView2.TabIndex = 8;
      // 
      // Column2
      // 
      this.Column2.HeaderText = "1";
      this.Column2.MinimumWidth = 6;
      this.Column2.Name = "Column2";
      this.Column2.ReadOnly = true;
      this.Column2.Width = 125;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(718, 273);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(64, 25);
      this.label1.TabIndex = 9;
      this.label1.Text = "label1";
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(707, 13);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(187, 27);
      this.button2.TabIndex = 10;
      this.button2.Text = "Добавить столбец";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(900, 13);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(188, 27);
      this.button3.TabIndex = 11;
      this.button3.Text = "Удалить столбец";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(1104, 13);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(272, 27);
      this.button4.TabIndex = 12;
      this.button4.Text = "Очистить таблицу для вывода";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // radioButton1
      // 
      this.radioButton1.AutoSize = true;
      this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.radioButton1.Location = new System.Drawing.Point(743, 60);
      this.radioButton1.Name = "radioButton1";
      this.radioButton1.Size = new System.Drawing.Size(208, 24);
      this.radioButton1.TabIndex = 13;
      this.radioButton1.TabStop = true;
      this.radioButton1.Text = "Обычная сортировка";
      this.radioButton1.UseVisualStyleBackColor = true;
      this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
      // 
      // radioButton2
      // 
      this.radioButton2.AutoSize = true;
      this.radioButton2.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.radioButton2.Location = new System.Drawing.Point(743, 90);
      this.radioButton2.Name = "radioButton2";
      this.radioButton2.Size = new System.Drawing.Size(196, 23);
      this.radioButton2.TabIndex = 14;
      this.radioButton2.TabStop = true;
      this.radioButton2.Text = "Обратная сортировка";
      this.radioButton2.UseVisualStyleBackColor = true;
      // 
      // button5
      // 
      this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.button5.Location = new System.Drawing.Point(723, 586);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(44, 34);
      this.button5.TabIndex = 15;
      this.button5.Text = "...";
      this.button5.UseVisualStyleBackColor = true;
      this.button5.Click += new System.EventHandler(this.button5_Click);
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(718, 540);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(177, 25);
      this.label2.TabIndex = 16;
      this.label2.Text = "Считать из Excel:";
      // 
      // fileNameExcel
      // 
      this.fileNameExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.fileNameExcel.Location = new System.Drawing.Point(773, 588);
      this.fileNameExcel.Name = "fileNameExcel";
      this.fileNameExcel.Size = new System.Drawing.Size(222, 30);
      this.fileNameExcel.TabIndex = 17;
      // 
      // readFileExcel
      // 
      this.readFileExcel.Location = new System.Drawing.Point(829, 637);
      this.readFileExcel.Name = "readFileExcel";
      this.readFileExcel.Size = new System.Drawing.Size(166, 32);
      this.readFileExcel.TabIndex = 18;
      this.readFileExcel.Text = "Считать";
      this.readFileExcel.UseVisualStyleBackColor = true;
      this.readFileExcel.Click += new System.EventHandler(this.readFileExcel_Click);
      // 
      // rangeExcel
      // 
      this.rangeExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.rangeExcel.Location = new System.Drawing.Point(723, 637);
      this.rangeExcel.Name = "rangeExcel";
      this.rangeExcel.Size = new System.Drawing.Size(100, 30);
      this.rangeExcel.TabIndex = 19;
      this.rangeExcel.Text = "A1:A2";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label3.Location = new System.Drawing.Point(1012, 540);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(193, 25);
      this.label3.TabIndex = 20;
      this.label3.Text = "Случайный массив:";
      // 
      // randArrCountRows
      // 
      this.randArrCountRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.randArrCountRows.Location = new System.Drawing.Point(1017, 588);
      this.randArrCountRows.Name = "randArrCountRows";
      this.randArrCountRows.Size = new System.Drawing.Size(46, 30);
      this.randArrCountRows.TabIndex = 22;
      // 
      // randArrCountColumns
      // 
      this.randArrCountColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.randArrCountColumns.Location = new System.Drawing.Point(1017, 637);
      this.randArrCountColumns.Name = "randArrCountColumns";
      this.randArrCountColumns.Size = new System.Drawing.Size(46, 30);
      this.randArrCountColumns.TabIndex = 23;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label5.Location = new System.Drawing.Point(1078, 594);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(66, 25);
      this.label5.TabIndex = 24;
      this.label5.Text = "строк";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label6.Location = new System.Drawing.Point(1078, 644);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(101, 25);
      this.label6.TabIndex = 25;
      this.label6.Text = "столбцов";
      this.label6.Click += new System.EventHandler(this.label6_Click);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label4.Location = new System.Drawing.Point(1212, 591);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(35, 25);
      this.label4.TabIndex = 26;
      this.label4.Text = "от";
      // 
      // randArrMinVal
      // 
      this.randArrMinVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.randArrMinVal.Location = new System.Drawing.Point(1263, 591);
      this.randArrMinVal.Name = "randArrMinVal";
      this.randArrMinVal.Size = new System.Drawing.Size(54, 30);
      this.randArrMinVal.TabIndex = 27;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label7.Location = new System.Drawing.Point(1212, 644);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(35, 25);
      this.label7.TabIndex = 28;
      this.label7.Text = "до";
      // 
      // randArrMaxVal
      // 
      this.randArrMaxVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.randArrMaxVal.Location = new System.Drawing.Point(1263, 641);
      this.randArrMaxVal.Name = "randArrMaxVal";
      this.randArrMaxVal.Size = new System.Drawing.Size(54, 30);
      this.randArrMaxVal.TabIndex = 29;
      // 
      // button6
      // 
      this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.button6.Location = new System.Drawing.Point(1217, 540);
      this.button6.Name = "button6";
      this.button6.Size = new System.Drawing.Size(183, 29);
      this.button6.TabIndex = 30;
      this.button6.Text = "Сгенерировать";
      this.button6.UseVisualStyleBackColor = true;
      this.button6.Click += new System.EventHandler(this.button6_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1420, 704);
      this.Controls.Add(this.button6);
      this.Controls.Add(this.randArrMaxVal);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.randArrMinVal);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.randArrCountColumns);
      this.Controls.Add(this.randArrCountRows);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.rangeExcel);
      this.Controls.Add(this.readFileExcel);
      this.Controls.Add(this.fileNameExcel);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.button5);
      this.Controls.Add(this.radioButton2);
      this.Controls.Add(this.radioButton1);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.dataGridView2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.dataGridView1);
      this.Name = "Form1";
      this.Text = "Sort";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.CheckBox checkBox2;
    private System.Windows.Forms.CheckBox checkBox3;
    private System.Windows.Forms.CheckBox checkBox4;
    private System.Windows.Forms.CheckBox checkBox5;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.DataGridView dataGridView2;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.RadioButton radioButton1;
    private System.Windows.Forms.RadioButton radioButton2;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox fileNameExcel;
    private System.Windows.Forms.Button readFileExcel;
    private System.Windows.Forms.TextBox rangeExcel;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox randArrCountRows;
    private System.Windows.Forms.TextBox randArrCountColumns;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox randArrMinVal;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox randArrMaxVal;
    private System.Windows.Forms.Button button6;
  }
}

