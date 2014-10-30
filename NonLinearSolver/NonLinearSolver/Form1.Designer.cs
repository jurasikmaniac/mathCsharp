namespace NonLinearSolver
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.resultButton = new System.Windows.Forms.Button();
            this.FunctionText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.zGC1 = new ZedGraph.ZedGraphControl();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonBi = new System.Windows.Forms.Button();
            this.buttonHord = new System.Windows.Forms.Button();
            this.buttonNewton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultButton
            // 
            this.resultButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resultButton.Location = new System.Drawing.Point(173, 28);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(113, 23);
            this.resultButton.TabIndex = 0;
            this.resultButton.Text = "Показать график";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // FunctionText
            // 
            this.FunctionText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FunctionText.Location = new System.Drawing.Point(13, 28);
            this.FunctionText.Multiline = true;
            this.FunctionText.Name = "FunctionText";
            this.FunctionText.Size = new System.Drawing.Size(154, 106);
            this.FunctionText.TabIndex = 1;
            this.FunctionText.Text = "sin(x)^2+cos(x)^2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Формула";
            // 
            // zGC1
            // 
            this.zGC1.Location = new System.Drawing.Point(12, 184);
            this.zGC1.Name = "zGC1";
            this.zGC1.ScrollGrace = 0D;
            this.zGC1.ScrollMaxX = 0D;
            this.zGC1.ScrollMaxY = 0D;
            this.zGC1.ScrollMaxY2 = 0D;
            this.zGC1.ScrollMinX = 0D;
            this.zGC1.ScrollMinY = 0D;
            this.zGC1.ScrollMinY2 = 0D;
            this.zGC1.Size = new System.Drawing.Size(619, 341);
            this.zGC1.TabIndex = 3;
            this.zGC1.ZoomEvent += new ZedGraph.ZedGraphControl.ZoomEventHandler(this.zedGraph_ZoomEvent);
            // 
            // buttonBi
            // 
            this.buttonBi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBi.Location = new System.Drawing.Point(292, 28);
            this.buttonBi.Name = "buttonBi";
            this.buttonBi.Size = new System.Drawing.Size(113, 23);
            this.buttonBi.TabIndex = 10;
            this.buttonBi.Text = "Бисекции";
            this.buttonBi.UseVisualStyleBackColor = true;
            this.buttonBi.Click += new System.EventHandler(this.buttonBi_Click);
            // 
            // buttonHord
            // 
            this.buttonHord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHord.Location = new System.Drawing.Point(411, 28);
            this.buttonHord.Name = "buttonHord";
            this.buttonHord.Size = new System.Drawing.Size(113, 23);
            this.buttonHord.TabIndex = 11;
            this.buttonHord.Text = "Хорд";
            this.buttonHord.UseVisualStyleBackColor = true;
            this.buttonHord.Click += new System.EventHandler(this.buttonHord_Click);
            // 
            // buttonNewton
            // 
            this.buttonNewton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewton.Location = new System.Drawing.Point(530, 28);
            this.buttonNewton.Name = "buttonNewton";
            this.buttonNewton.Size = new System.Drawing.Size(113, 23);
            this.buttonNewton.TabIndex = 12;
            this.buttonNewton.Text = "Касательных";
            this.buttonNewton.UseVisualStyleBackColor = true;
            this.buttonNewton.Click += new System.EventHandler(this.buttonNewton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(353, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "-10";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(471, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 20);
            this.textBox2.TabIndex = 14;
            this.textBox2.Text = "10";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Интервал поиска корня";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(471, 114);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(112, 20);
            this.textBox3.TabIndex = 16;
            this.textBox3.Text = "0,01";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(529, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Точность";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(421, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Корень";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(353, 114);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(112, 20);
            this.textBox4.TabIndex = 20;
            this.textBox4.Text = "Nan";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(471, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "На графике";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(353, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Стереть корни";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 537);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonNewton);
            this.Controls.Add(this.buttonHord);
            this.Controls.Add(this.buttonBi);
            this.Controls.Add(this.zGC1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FunctionText);
            this.Controls.Add(this.resultButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Решение нелинейных уравнений";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resultButton;
        private System.Windows.Forms.TextBox FunctionText;
        private System.Windows.Forms.Label label1;
        private ZedGraph.ZedGraphControl zGC1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonBi;
        private System.Windows.Forms.Button buttonHord;
        private System.Windows.Forms.Button buttonNewton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;        
    }
}

