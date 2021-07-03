
namespace TAPU3_PROYECTO
{
    partial class Reticula
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
            this.tablaR = new System.Windows.Forms.DataGridView();
            this.Semestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asignatura1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asignatura2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asignatura3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asignatura4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asignatura5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asignatura6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaR)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaR
            // 
            this.tablaR.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablaR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Semestre,
            this.Asignatura1,
            this.Asignatura2,
            this.Asignatura3,
            this.Asignatura4,
            this.Asignatura5,
            this.Asignatura6});
            this.tablaR.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.tablaR.Location = new System.Drawing.Point(72, 112);
            this.tablaR.Margin = new System.Windows.Forms.Padding(4);
            this.tablaR.Name = "tablaR";
            this.tablaR.RowHeadersWidth = 51;
            this.tablaR.Size = new System.Drawing.Size(1243, 591);
            this.tablaR.TabIndex = 2;
            // 
            // Semestre
            // 
            this.Semestre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Semestre.HeaderText = "Semestre ";
            this.Semestre.MinimumWidth = 6;
            this.Semestre.Name = "Semestre";
            this.Semestre.Width = 101;
            // 
            // Asignatura1
            // 
            this.Asignatura1.HeaderText = "Asignatura1";
            this.Asignatura1.MinimumWidth = 6;
            this.Asignatura1.Name = "Asignatura1";
            this.Asignatura1.Width = 125;
            // 
            // Asignatura2
            // 
            this.Asignatura2.HeaderText = "Asignatura2";
            this.Asignatura2.MinimumWidth = 6;
            this.Asignatura2.Name = "Asignatura2";
            this.Asignatura2.Width = 125;
            // 
            // Asignatura3
            // 
            this.Asignatura3.HeaderText = "Asignatura3";
            this.Asignatura3.MinimumWidth = 6;
            this.Asignatura3.Name = "Asignatura3";
            this.Asignatura3.Width = 125;
            // 
            // Asignatura4
            // 
            this.Asignatura4.HeaderText = "Asignatura4";
            this.Asignatura4.MinimumWidth = 6;
            this.Asignatura4.Name = "Asignatura4";
            this.Asignatura4.Width = 125;
            // 
            // Asignatura5
            // 
            this.Asignatura5.HeaderText = "Asignatura5";
            this.Asignatura5.MinimumWidth = 6;
            this.Asignatura5.Name = "Asignatura5";
            this.Asignatura5.Width = 125;
            // 
            // Asignatura6
            // 
            this.Asignatura6.HeaderText = "Asignatura6";
            this.Asignatura6.MinimumWidth = 6;
            this.Asignatura6.Name = "Asignatura6";
            this.Asignatura6.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(592, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 36);
            this.label3.TabIndex = 14;
            this.label3.Text = "Reticula";
            // 
            // Reticula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1380, 741);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tablaR);
            this.Name = "Reticula";
            this.Text = "Reticula";
            ((System.ComponentModel.ISupportInitialize)(this.tablaR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asignatura1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asignatura2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asignatura3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asignatura4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asignatura5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asignatura6;
        private System.Windows.Forms.Label label3;
    }
}