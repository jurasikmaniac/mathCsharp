namespace MathParserTestNS
{
    partial class MathParserTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MathParserTest));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkParant = new System.Windows.Forms.CheckBox();
            this.chkImplicit = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.valuePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.variableValue1 = new MathParserTestNS.VariableValue();
            this.variableValue2 = new MathParserTestNS.VariableValue();
            this.button3 = new System.Windows.Forms.Button();
            this.valuePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(78, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "xcos(x+y)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Function:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 206);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(319, 188);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(207, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Parse";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(90, 168);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(102, 20);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = "1000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Iterations:";
            // 
            // chkParant
            // 
            this.chkParant.AutoSize = true;
            this.chkParant.Checked = true;
            this.chkParant.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkParant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkParant.ForeColor = System.Drawing.Color.White;
            this.chkParant.Location = new System.Drawing.Point(16, 45);
            this.chkParant.Name = "chkParant";
            this.chkParant.Size = new System.Drawing.Size(144, 17);
            this.chkParant.TabIndex = 8;
            this.chkParant.Text = "Require Parentheses";
            this.chkParant.UseVisualStyleBackColor = true;
            // 
            // chkImplicit
            // 
            this.chkImplicit.AutoSize = true;
            this.chkImplicit.Checked = true;
            this.chkImplicit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkImplicit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkImplicit.ForeColor = System.Drawing.Color.White;
            this.chkImplicit.Location = new System.Drawing.Point(186, 45);
            this.chkImplicit.Name = "chkImplicit";
            this.chkImplicit.Size = new System.Drawing.Size(145, 17);
            this.chkImplicit.TabIndex = 9;
            this.chkImplicit.Text = "Implicit Multiplication";
            this.chkImplicit.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(303, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // valuePanel
            // 
            this.valuePanel.AutoScroll = true;
            this.valuePanel.BackColor = System.Drawing.Color.Navy;
            this.valuePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valuePanel.Controls.Add(this.variableValue1);
            this.valuePanel.Controls.Add(this.variableValue2);
            this.valuePanel.Location = new System.Drawing.Point(12, 69);
            this.valuePanel.Name = "valuePanel";
            this.valuePanel.Size = new System.Drawing.Size(285, 83);
            this.valuePanel.TabIndex = 12;
            // 
            // variableValue1
            // 
            this.variableValue1.BackColor = System.Drawing.Color.Navy;
            this.variableValue1.Location = new System.Drawing.Point(3, 3);
            this.variableValue1.Name = "variableValue1";
            this.variableValue1.Size = new System.Drawing.Size(258, 29);
            this.variableValue1.TabIndex = 0;
            this.variableValue1.Value = "";
            this.variableValue1.Variable = "";
            this.variableValue1.Load += new System.EventHandler(this.variableValue1_Load);
            // 
            // variableValue2
            // 
            this.variableValue2.BackColor = System.Drawing.Color.Navy;
            this.variableValue2.Location = new System.Drawing.Point(3, 38);
            this.variableValue2.Name = "variableValue2";
            this.variableValue2.Size = new System.Drawing.Size(258, 29);
            this.variableValue2.TabIndex = 1;
            this.variableValue2.Value = "";
            this.variableValue2.Variable = "";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(303, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MathParserTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(344, 406);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.valuePanel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chkImplicit);
            this.Controls.Add(this.chkParant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.Name = "MathParserTest";
            this.Text = "info.lundin.math - Test";
            this.valuePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkParant;
        private System.Windows.Forms.CheckBox chkImplicit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel valuePanel;
        private VariableValue variableValue1;
        private VariableValue variableValue2;
        private System.Windows.Forms.Button button3;
    }
}

