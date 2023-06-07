namespace Zad1_08_06_23
{
    partial class frmGraphics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series25 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtStep = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbGraphics = new System.Windows.Forms.ComboBox();
            this.txtZnach = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkSin = new System.Windows.Forms.CheckBox();
            this.chkCos = new System.Windows.Forms.CheckBox();
            this.chkCos2 = new System.Windows.Forms.CheckBox();
            this.chkFunc1 = new System.Windows.Forms.CheckBox();
            this.chkFunc2 = new System.Windows.Forms.CheckBox();
            this.chartGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btCount = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btExit);
            this.groupBox1.Controls.Add(this.btClear);
            this.groupBox1.Controls.Add(this.btCount);
            this.groupBox1.Controls.Add(this.chkFunc2);
            this.groupBox1.Controls.Add(this.chkFunc1);
            this.groupBox1.Controls.Add(this.chkCos2);
            this.groupBox1.Controls.Add(this.chkCos);
            this.groupBox1.Controls.Add(this.chkSin);
            this.groupBox1.Controls.Add(this.txtStep);
            this.groupBox1.Controls.Add(this.txtMax);
            this.groupBox1.Controls.Add(this.txtMin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(471, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 499);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Начальные данные:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите Xmin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите Xmax:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введите шаг:";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(156, 43);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(100, 26);
            this.txtMin.TabIndex = 3;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(156, 75);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(100, 26);
            this.txtMax.TabIndex = 4;
            // 
            // txtStep
            // 
            this.txtStep.Location = new System.Drawing.Point(156, 110);
            this.txtStep.Name = "txtStep";
            this.txtStep.Size = new System.Drawing.Size(100, 26);
            this.txtStep.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtZnach);
            this.groupBox2.Controls.Add(this.cbGraphics);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(739, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 499);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Значения графика:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 65);
            this.label4.TabIndex = 0;
            this.label4.Text = "Выберите функцию, значения которой нужно показать:";
            // 
            // cbGraphics
            // 
            this.cbGraphics.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGraphics.FormattingEnabled = true;
            this.cbGraphics.Items.AddRange(new object[] {
            "Sin (x)",
            "Cos (x)",
            "Cos (x) +2*x",
            "√2",
            "4+x+x^2"});
            this.cbGraphics.Location = new System.Drawing.Point(6, 94);
            this.cbGraphics.Name = "cbGraphics";
            this.cbGraphics.Size = new System.Drawing.Size(224, 28);
            this.cbGraphics.TabIndex = 1;
            // 
            // txtZnach
            // 
            this.txtZnach.Location = new System.Drawing.Point(7, 129);
            this.txtZnach.Multiline = true;
            this.txtZnach.Name = "txtZnach";
            this.txtZnach.Size = new System.Drawing.Size(223, 364);
            this.txtZnach.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chartGraph);
            this.groupBox3.Location = new System.Drawing.Point(13, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(452, 499);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Построение графиков:";
            // 
            // chkSin
            // 
            this.chkSin.AutoSize = true;
            this.chkSin.Location = new System.Drawing.Point(28, 154);
            this.chkSin.Name = "chkSin";
            this.chkSin.Size = new System.Drawing.Size(220, 24);
            this.chkSin.TabIndex = 6;
            this.chkSin.Text = "Построить график Sin (x)";
            this.chkSin.UseVisualStyleBackColor = true;
            // 
            // chkCos
            // 
            this.chkCos.AutoSize = true;
            this.chkCos.Location = new System.Drawing.Point(28, 185);
            this.chkCos.Name = "chkCos";
            this.chkCos.Size = new System.Drawing.Size(221, 24);
            this.chkCos.TabIndex = 7;
            this.chkCos.Text = "Построить график Cos(x)";
            this.chkCos.UseVisualStyleBackColor = true;
            // 
            // chkCos2
            // 
            this.chkCos2.Location = new System.Drawing.Point(28, 216);
            this.chkCos2.Name = "chkCos2";
            this.chkCos2.Size = new System.Drawing.Size(220, 55);
            this.chkCos2.TabIndex = 8;
            this.chkCos2.Text = "Построить график Cos (x) +2*x";
            this.chkCos2.UseVisualStyleBackColor = true;
            // 
            // chkFunc1
            // 
            this.chkFunc1.AutoSize = true;
            this.chkFunc1.Location = new System.Drawing.Point(28, 273);
            this.chkFunc1.Name = "chkFunc1";
            this.chkFunc1.Size = new System.Drawing.Size(194, 24);
            this.chkFunc1.TabIndex = 9;
            this.chkFunc1.Text = "Построить график √2";
            this.chkFunc1.UseVisualStyleBackColor = true;
            // 
            // chkFunc2
            // 
            this.chkFunc2.Location = new System.Drawing.Point(28, 303);
            this.chkFunc2.Name = "chkFunc2";
            this.chkFunc2.Size = new System.Drawing.Size(220, 65);
            this.chkFunc2.TabIndex = 10;
            this.chkFunc2.Text = "Построить график 4+x+x^2";
            this.chkFunc2.UseVisualStyleBackColor = true;
            // 
            // chartGraph
            // 
            chartArea5.Name = "ChartArea1";
            this.chartGraph.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartGraph.Legends.Add(legend5);
            this.chartGraph.Location = new System.Drawing.Point(7, 26);
            this.chartGraph.Name = "chartGraph";
            series21.BorderWidth = 2;
            series21.ChartArea = "ChartArea1";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series21.Legend = "Legend1";
            series21.Name = "Sin (x)";
            series21.YValuesPerPoint = 2;
            series22.BorderWidth = 2;
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series22.Legend = "Legend1";
            series22.Name = "Cos (x)";
            series22.YValuesPerPoint = 2;
            series23.BorderWidth = 2;
            series23.ChartArea = "ChartArea1";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series23.Legend = "Legend1";
            series23.Name = "Cos (x) +2*x";
            series23.YValuesPerPoint = 2;
            series24.BorderWidth = 2;
            series24.ChartArea = "ChartArea1";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series24.Legend = "Legend1";
            series24.Name = "√2";
            series24.YValuesPerPoint = 2;
            series25.BorderWidth = 2;
            series25.ChartArea = "ChartArea1";
            series25.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series25.Legend = "Legend1";
            series25.Name = "4+x+x^2";
            series25.YValuesPerPoint = 2;
            this.chartGraph.Series.Add(series21);
            this.chartGraph.Series.Add(series22);
            this.chartGraph.Series.Add(series23);
            this.chartGraph.Series.Add(series24);
            this.chartGraph.Series.Add(series25);
            this.chartGraph.Size = new System.Drawing.Size(439, 467);
            this.chartGraph.TabIndex = 0;
            this.chartGraph.Text = "chart1";
            // 
            // btCount
            // 
            this.btCount.Location = new System.Drawing.Point(7, 365);
            this.btCount.Name = "btCount";
            this.btCount.Size = new System.Drawing.Size(249, 32);
            this.btCount.TabIndex = 11;
            this.btCount.Text = "Расчёт";
            this.btCount.UseVisualStyleBackColor = true;
            this.btCount.Click += new System.EventHandler(this.btCount_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(6, 403);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(249, 32);
            this.btClear.TabIndex = 12;
            this.btClear.Text = "Очистить графики";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(6, 441);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(249, 32);
            this.btExit.TabIndex = 13;
            this.btExit.Text = "Выход";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // frmGraphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 523);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmGraphics";
            this.Text = "Графики";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btCount;
        private System.Windows.Forms.CheckBox chkFunc2;
        private System.Windows.Forms.CheckBox chkFunc1;
        private System.Windows.Forms.CheckBox chkCos2;
        private System.Windows.Forms.CheckBox chkCos;
        private System.Windows.Forms.CheckBox chkSin;
        private System.Windows.Forms.TextBox txtStep;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtZnach;
        private System.Windows.Forms.ComboBox cbGraphics;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraph;
    }
}

