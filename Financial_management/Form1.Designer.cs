namespace finance
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnAccept = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnImport = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDohod = new System.Windows.Forms.ComboBox();
            this.dateDohod = new System.Windows.Forms.DateTimePicker();
            this.dateRashod = new System.Windows.Forms.DateTimePicker();
            this.cmbRashod = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRashod = new System.Windows.Forms.TextBox();
            this.txtDohod = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnExcel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chartDohod = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartRashod = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dateSecond = new System.Windows.Forms.DateTimePicker();
            this.dateFirst = new System.Windows.Forms.DateTimePicker();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateNapom = new System.Windows.Forms.DateTimePicker();
            this.txtNapom = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnNapom = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDohod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRashod)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(576, 298);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(111, 41);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.Text = "ПРИНЯТЬ";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 438);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnImport);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.cmbDohod);
            this.tabPage1.Controls.Add(this.dateDohod);
            this.tabPage1.Controls.Add(this.dateRashod);
            this.tabPage1.Controls.Add(this.cmbRashod);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtRashod);
            this.tabPage1.Controls.Add(this.txtDohod);
            this.tabPage1.Controls.Add(this.btnAccept);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Доходы и расходы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(440, 298);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(111, 41);
            this.btnImport.TabIndex = 16;
            this.btnImport.Text = "ИМПОРТ CSV-ФАЙЛА";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(281, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "RUB";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(281, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "RUB";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(170, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(414, 64);
            this.label5.TabIndex = 9;
            this.label5.Text = "Зафиксируйте ваши доходы и расходы";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbDohod
            // 
            this.cmbDohod.FormattingEnabled = true;
            this.cmbDohod.Location = new System.Drawing.Point(345, 133);
            this.cmbDohod.Name = "cmbDohod";
            this.cmbDohod.Size = new System.Drawing.Size(121, 21);
            this.cmbDohod.TabIndex = 8;
            // 
            // dateDohod
            // 
            this.dateDohod.Location = new System.Drawing.Point(487, 136);
            this.dateDohod.Name = "dateDohod";
            this.dateDohod.Size = new System.Drawing.Size(200, 20);
            this.dateDohod.TabIndex = 7;
            // 
            // dateRashod
            // 
            this.dateRashod.Location = new System.Drawing.Point(487, 219);
            this.dateRashod.Name = "dateRashod";
            this.dateRashod.Size = new System.Drawing.Size(200, 20);
            this.dateRashod.TabIndex = 6;
            // 
            // cmbRashod
            // 
            this.cmbRashod.FormattingEnabled = true;
            this.cmbRashod.Location = new System.Drawing.Point(345, 218);
            this.cmbRashod.Name = "cmbRashod";
            this.cmbRashod.Size = new System.Drawing.Size(121, 21);
            this.cmbRashod.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(62, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Расходы:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(69, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Доходы:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRashod
            // 
            this.txtRashod.Location = new System.Drawing.Point(175, 218);
            this.txtRashod.Name = "txtRashod";
            this.txtRashod.Size = new System.Drawing.Size(100, 20);
            this.txtRashod.TabIndex = 2;
            // 
            // txtDohod
            // 
            this.txtDohod.Location = new System.Drawing.Point(175, 136);
            this.txtDohod.Name = "txtDohod";
            this.txtDohod.Size = new System.Drawing.Size(100, 20);
            this.txtDohod.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnExcel);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.chartDohod);
            this.tabPage2.Controls.Add(this.chartRashod);
            this.tabPage2.Controls.Add(this.dateSecond);
            this.tabPage2.Controls.Add(this.dateFirst);
            this.tabPage2.Controls.Add(this.btnCalculate);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(780, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Отчет и анализ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(399, 337);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(121, 48);
            this.btnExcel.TabIndex = 7;
            this.btnExcel.Text = "ЭКСПОРТ В EXCEL";
            this.btnExcel.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(510, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Расходы:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(109, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Доходы:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartDohod
            // 
            chartArea3.Name = "ChartArea1";
            this.chartDohod.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartDohod.Legends.Add(legend3);
            this.chartDohod.Location = new System.Drawing.Point(41, 31);
            this.chartDohod.Name = "chartDohod";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartDohod.Series.Add(series3);
            this.chartDohod.Size = new System.Drawing.Size(300, 300);
            this.chartDohod.TabIndex = 4;
            this.chartDohod.Text = "chart2";
            // 
            // chartRashod
            // 
            chartArea4.Name = "ChartArea1";
            this.chartRashod.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartRashod.Legends.Add(legend4);
            this.chartRashod.Location = new System.Drawing.Point(436, 31);
            this.chartRashod.Name = "chartRashod";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartRashod.Series.Add(series4);
            this.chartRashod.Size = new System.Drawing.Size(300, 300);
            this.chartRashod.TabIndex = 3;
            this.chartRashod.Text = "chart1";
            // 
            // dateSecond
            // 
            this.dateSecond.Location = new System.Drawing.Point(526, 351);
            this.dateSecond.Name = "dateSecond";
            this.dateSecond.Size = new System.Drawing.Size(200, 20);
            this.dateSecond.TabIndex = 2;
            // 
            // dateFirst
            // 
            this.dateFirst.Location = new System.Drawing.Point(41, 351);
            this.dateFirst.Name = "dateFirst";
            this.dateFirst.Size = new System.Drawing.Size(200, 20);
            this.dateFirst.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(247, 337);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(121, 48);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "РАССЧИТАТЬ";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(780, 412);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Месячный лимит";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(8, 126);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(766, 280);
            this.dataGridView2.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(261, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(226, 64);
            this.label10.TabIndex = 10;
            this.label10.Text = "Месячный лимит";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Controls.Add(this.dateNapom);
            this.tabPage4.Controls.Add(this.txtNapom);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.btnNapom);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(780, 412);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Напоминания";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(766, 280);
            this.dataGridView1.TabIndex = 16;
            // 
            // dateNapom
            // 
            this.dateNapom.Location = new System.Drawing.Point(458, 87);
            this.dateNapom.Name = "dateNapom";
            this.dateNapom.Size = new System.Drawing.Size(200, 20);
            this.dateNapom.TabIndex = 15;
            // 
            // txtNapom
            // 
            this.txtNapom.Location = new System.Drawing.Point(266, 87);
            this.txtNapom.Name = "txtNapom";
            this.txtNapom.Size = new System.Drawing.Size(186, 20);
            this.txtNapom.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(3, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(257, 23);
            this.label12.TabIndex = 13;
            this.label12.Text = "Описание напоминания:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNapom
            // 
            this.btnNapom.Location = new System.Drawing.Point(671, 77);
            this.btnNapom.Name = "btnNapom";
            this.btnNapom.Size = new System.Drawing.Size(95, 38);
            this.btnNapom.TabIndex = 12;
            this.btnNapom.Text = "ДОБАВИТЬ";
            this.btnNapom.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(216, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(332, 64);
            this.label11.TabIndex = 11;
            this.label11.Text = "Напоминания об оплате";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(546, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "ПРИНЯТЬ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(336, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(272, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 23);
            this.label13.TabIndex = 18;
            this.label13.Text = "RUB";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(17, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 23);
            this.label14.TabIndex = 16;
            this.label14.Text = "Месячный лимит:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "УПРАВЛЕНИЕ ДИР";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDohod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRashod)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRashod;
        private System.Windows.Forms.TextBox txtDohod;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cmbRashod;
        private System.Windows.Forms.DateTimePicker dateRashod;
        private System.Windows.Forms.ComboBox cmbDohod;
        private System.Windows.Forms.DateTimePicker dateDohod;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRashod;
        private System.Windows.Forms.DateTimePicker dateSecond;
        private System.Windows.Forms.DateTimePicker dateFirst;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDohod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateNapom;
        private System.Windows.Forms.TextBox txtNapom;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnNapom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label14;
    }
}

