namespace WeatherApp
{
    partial class WeatherForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.WeatherDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.poisk = new System.Windows.Forms.TextBox();
            this.filtr = new System.Windows.Forms.ComboBox();
            this.sortirovka = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sbros = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // WeatherDataGrid
            // 
            this.WeatherDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.WeatherDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WeatherDataGrid.Location = new System.Drawing.Point(12, 12);
            this.WeatherDataGrid.Name = "WeatherDataGrid";
            this.WeatherDataGrid.ReadOnly = true;
            this.WeatherDataGrid.Size = new System.Drawing.Size(776, 210);
            this.WeatherDataGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Город";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фильтр по единицам измерения";
            // 
            // poisk
            // 
            this.poisk.Location = new System.Drawing.Point(216, 264);
            this.poisk.Name = "poisk";
            this.poisk.Size = new System.Drawing.Size(100, 20);
            this.poisk.TabIndex = 3;
            this.poisk.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // filtr
            // 
            this.filtr.FormattingEnabled = true;
            this.filtr.Location = new System.Drawing.Point(530, 264);
            this.filtr.Name = "filtr";
            this.filtr.Size = new System.Drawing.Size(121, 21);
            this.filtr.TabIndex = 4;
            this.filtr.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // sortirovka
            // 
            this.sortirovka.Location = new System.Drawing.Point(241, 307);
            this.sortirovka.Name = "sortirovka";
            this.sortirovka.Size = new System.Drawing.Size(75, 23);
            this.sortirovka.TabIndex = 5;
            this.sortirovka.Text = "Сортировка ";
            this.sortirovka.UseVisualStyleBackColor = true;
            this.sortirovka.Click += new System.EventHandler(this.sortirovka_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Вывести \"+\"";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sbros
            // 
            this.sbros.Location = new System.Drawing.Point(460, 307);
            this.sbros.Name = "sbros";
            this.sbros.Size = new System.Drawing.Size(75, 23);
            this.sbros.TabIndex = 7;
            this.sbros.Text = "Сброс";
            this.sbros.UseVisualStyleBackColor = true;
            this.sbros.Click += new System.EventHandler(this.sbroc_Click);
            // 
            // WeatherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sbros);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sortirovka);
            this.Controls.Add(this.filtr);
            this.Controls.Add(this.poisk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WeatherDataGrid);
            this.Name = "WeatherForm";
            this.Text = "Погода Хакасии";
            ((System.ComponentModel.ISupportInitialize)(this.WeatherDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView WeatherDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox poisk;
        private System.Windows.Forms.ComboBox filtr;
        private System.Windows.Forms.Button sortirovka;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button sbros;
    }
}

