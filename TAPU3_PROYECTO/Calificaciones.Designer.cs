
namespace TAPU3_PROYECTO
{
    partial class Calificaciones
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
            this.labelSemestre = new System.Windows.Forms.Label();
            this.labelCalificaciones = new System.Windows.Forms.Label();
            this.tablaC = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaC)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSemestre
            // 
            this.labelSemestre.AutoSize = true;
            this.labelSemestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemestre.ForeColor = System.Drawing.Color.White;
            this.labelSemestre.Location = new System.Drawing.Point(234, 160);
            this.labelSemestre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSemestre.Name = "labelSemestre";
            this.labelSemestre.Size = new System.Drawing.Size(130, 24);
            this.labelSemestre.TabIndex = 5;
            this.labelSemestre.Text = "labelSemestre";
            // 
            // labelCalificaciones
            // 
            this.labelCalificaciones.AutoSize = true;
            this.labelCalificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCalificaciones.ForeColor = System.Drawing.Color.White;
            this.labelCalificaciones.Location = new System.Drawing.Point(234, 126);
            this.labelCalificaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCalificaciones.Name = "labelCalificaciones";
            this.labelCalificaciones.Size = new System.Drawing.Size(162, 24);
            this.labelCalificaciones.TabIndex = 4;
            this.labelCalificaciones.Text = "Calificaciones de: ";
            // 
            // tablaC
            // 
            this.tablaC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.tablaC.Location = new System.Drawing.Point(66, 207);
            this.tablaC.Margin = new System.Windows.Forms.Padding(4);
            this.tablaC.Name = "tablaC";
            this.tablaC.RowHeadersWidth = 51;
            this.tablaC.Size = new System.Drawing.Size(632, 220);
            this.tablaC.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Materia";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 300;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Calificacion";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 130;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(264, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 36);
            this.label3.TabIndex = 13;
            this.label3.Text = "Calificaciones";
            // 
            // Calificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(763, 500);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelSemestre);
            this.Controls.Add(this.labelCalificaciones);
            this.Controls.Add(this.tablaC);
            this.Name = "Calificaciones";
            this.Text = "Calificaciones";
            ((System.ComponentModel.ISupportInitialize)(this.tablaC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSemestre;
        private System.Windows.Forms.Label labelCalificaciones;
        private System.Windows.Forms.DataGridView tablaC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label3;
    }
}