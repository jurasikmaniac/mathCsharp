namespace Drawer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lagrangeCheckBox = new System.Windows.Forms.CheckBox();
            this.newtonCheckBox = new System.Windows.Forms.CheckBox();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pointsDataGridView = new System.Windows.Forms.DataGridView();
            this.nColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addPointCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lagrangeCheckBox
            // 
            this.lagrangeCheckBox.AutoSize = true;
            this.lagrangeCheckBox.Location = new System.Drawing.Point(6, 19);
            this.lagrangeCheckBox.Name = "lagrangeCheckBox";
            this.lagrangeCheckBox.Size = new System.Drawing.Size(71, 17);
            this.lagrangeCheckBox.TabIndex = 1;
            this.lagrangeCheckBox.Text = "Лагранж";
            this.lagrangeCheckBox.UseVisualStyleBackColor = true;
            this.lagrangeCheckBox.CheckedChanged += new System.EventHandler(this.lagrangeCheckBox_CheckedChanged);
            // 
            // newtonCheckBox
            // 
            this.newtonCheckBox.AutoSize = true;
            this.newtonCheckBox.Location = new System.Drawing.Point(6, 42);
            this.newtonCheckBox.Name = "newtonCheckBox";
            this.newtonCheckBox.Size = new System.Drawing.Size(65, 17);
            this.newtonCheckBox.TabIndex = 2;
            this.newtonCheckBox.Text = "Ньютон";
            this.newtonCheckBox.UseVisualStyleBackColor = true;
            this.newtonCheckBox.CheckedChanged += new System.EventHandler(this.newtonCheckBox_CheckedChanged);
            // 
            // zedGraph
            // 
            this.zedGraph.Location = new System.Drawing.Point(12, 12);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(566, 379);
            this.zedGraph.TabIndex = 4;
            this.zedGraph.ZoomEvent += new ZedGraph.ZedGraphControl.ZoomEventHandler(this.zedGraph_ZoomEvent);
            this.zedGraph.MouseClick += new System.Windows.Forms.MouseEventHandler(this.zedGraph_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.newtonCheckBox);
            this.groupBox1.Controls.Add(this.lagrangeCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(584, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 75);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Показывать ";
            // 
            // pointsDataGridView
            // 
            this.pointsDataGridView.AllowUserToAddRows = false;
            this.pointsDataGridView.AllowUserToDeleteRows = false;
            this.pointsDataGridView.AllowUserToResizeColumns = false;
            this.pointsDataGridView.AllowUserToResizeRows = false;
            this.pointsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pointsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nColumn,
            this.xColumn,
            this.yColumn});
            this.pointsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.pointsDataGridView.Location = new System.Drawing.Point(584, 115);
            this.pointsDataGridView.Name = "pointsDataGridView";
            this.pointsDataGridView.ReadOnly = true;
            this.pointsDataGridView.RowHeadersVisible = false;
            this.pointsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pointsDataGridView.Size = new System.Drawing.Size(232, 150);
            this.pointsDataGridView.TabIndex = 6;
            this.pointsDataGridView.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.pointsDataGridView_CellMouseUp);
            this.pointsDataGridView.SelectionChanged += new System.EventHandler(this.pointsDataGridView_SelectionChanged);
            // 
            // nColumn
            // 
            this.nColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nColumn.Frozen = true;
            this.nColumn.HeaderText = "№";
            this.nColumn.Name = "nColumn";
            this.nColumn.ReadOnly = true;
            this.nColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nColumn.Width = 30;
            // 
            // xColumn
            // 
            this.xColumn.Frozen = true;
            this.xColumn.HeaderText = "X";
            this.xColumn.Name = "xColumn";
            this.xColumn.ReadOnly = true;
            this.xColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // yColumn
            // 
            this.yColumn.Frozen = true;
            this.yColumn.HeaderText = "Y";
            this.yColumn.Name = "yColumn";
            this.yColumn.ReadOnly = true;
            this.yColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // addPointCheckBox
            // 
            this.addPointCheckBox.AutoSize = true;
            this.addPointCheckBox.Location = new System.Drawing.Point(584, 272);
            this.addPointCheckBox.Name = "addPointCheckBox";
            this.addPointCheckBox.Size = new System.Drawing.Size(160, 17);
            this.addPointCheckBox.TabIndex = 7;
            this.addPointCheckBox.Text = "Добавлять точки по клику";
            this.addPointCheckBox.UseVisualStyleBackColor = true;
            this.addPointCheckBox.CheckedChanged += new System.EventHandler(this.addPointCheckBox_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(741, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(584, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(71, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "0";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(662, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(73, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 403);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addPointCheckBox);
            this.Controls.Add(this.pointsDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.zedGraph);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox lagrangeCheckBox;
        private System.Windows.Forms.CheckBox newtonCheckBox;
        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView pointsDataGridView;
        private System.Windows.Forms.CheckBox addPointCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn nColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

