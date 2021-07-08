
namespace TAPU3_PROYECTO
{
    partial class Horario
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
            this.label3 = new System.Windows.Forms.Label();
            this.tablaH = new System.Windows.Forms.DataGridView();
            this.Semestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asignatura1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asignatura2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asignatura3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asignatura4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asignatura5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaH)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(463, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Horario";
            // 
            // tablaH
            // 
            this.tablaH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablaH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Semestre,
            this.Asignatura1,
            this.Asignatura2,
            this.Asignatura3,
            this.Asignatura4,
            this.Asignatura5});
            this.tablaH.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.tablaH.Location = new System.Drawing.Point(69, 76);
            this.tablaH.Name = "tablaH";
            this.tablaH.RowHeadersWidth = 51;
            this.tablaH.Size = new System.Drawing.Size(737, 480);
            this.tablaH.TabIndex = 15;
            // 
            // Semestre
            // 
            this.Semestre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Semestre.HeaderText = "Hora";
            this.Semestre.MinimumWidth = 6;
            this.Semestre.Name = "Semestre";
            this.Semestre.Width = 55;
            // 
            // Asignatura1
            // 
            this.Asignatura1.HeaderText = "Lunes";
            this.Asignatura1.MinimumWidth = 6;
            this.Asignatura1.Name = "Asignatura1";
            this.Asignatura1.Width = 125;
            // 
            // Asignatura2
            // 
            this.Asignatura2.HeaderText = "Martes";
            this.Asignatura2.MinimumWidth = 6;
            this.Asignatura2.Name = "Asignatura2";
            this.Asignatura2.Width = 125;
            // 
            // Asignatura3
            // 
            this.Asignatura3.HeaderText = "Miercoles";
            this.Asignatura3.MinimumWidth = 6;
            this.Asignatura3.Name = "Asignatura3";
            this.Asignatura3.Width = 125;
            // 
            // Asignatura4
            // 
            this.Asignatura4.HeaderText = "Jueves";
            this.Asignatura4.MinimumWidth = 6;
            this.Asignatura4.Name = "Asignatura4";
            this.Asignatura4.Width = 125;
            // 
            // Asignatura5
            // 
            this.Asignatura5.HeaderText = "Viernes";
            this.Asignatura5.MinimumWidth = 6;
            this.Asignatura5.Name = "Asignatura5";
            this.Asignatura5.Width = 125;
            // 
            // Horario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1052, 591);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tablaH);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Horario";
            this.Text = "Horario";
            this.Load += new System.EventHandler(this.Horario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView tablaH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asignatura1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asignatura2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asignatura3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asignatura4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asignatura5;
    }
}