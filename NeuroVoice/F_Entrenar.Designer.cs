﻿namespace NeuroVoice
{
    partial class F_Entrenar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Carpeta = new System.Windows.Forms.TextBox();
            this.B_Examinar = new System.Windows.Forms.Button();
            this.GV_Archivos = new System.Windows.Forms.DataGridView();
            this.archivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_Entrenar = new System.Windows.Forms.Button();
            this.TB_Ocultas = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GV_Archivos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENTRENAMIENTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patrones";
            // 
            // TB_Carpeta
            // 
            this.TB_Carpeta.Location = new System.Drawing.Point(117, 71);
            this.TB_Carpeta.Name = "TB_Carpeta";
            this.TB_Carpeta.ReadOnly = true;
            this.TB_Carpeta.Size = new System.Drawing.Size(138, 20);
            this.TB_Carpeta.TabIndex = 2;
            // 
            // B_Examinar
            // 
            this.B_Examinar.Location = new System.Drawing.Point(117, 98);
            this.B_Examinar.Name = "B_Examinar";
            this.B_Examinar.Size = new System.Drawing.Size(75, 23);
            this.B_Examinar.TabIndex = 3;
            this.B_Examinar.Text = "Examinar...";
            this.B_Examinar.UseVisualStyleBackColor = true;
            this.B_Examinar.Click += new System.EventHandler(this.B_Examinar_Click);
            // 
            // GV_Archivos
            // 
            this.GV_Archivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_Archivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.archivo,
            this.salida});
            this.GV_Archivos.Location = new System.Drawing.Point(12, 127);
            this.GV_Archivos.Name = "GV_Archivos";
            this.GV_Archivos.Size = new System.Drawing.Size(302, 239);
            this.GV_Archivos.TabIndex = 4;
            // 
            // archivo
            // 
            this.archivo.HeaderText = "Archivo";
            this.archivo.Name = "archivo";
            this.archivo.ReadOnly = true;
            // 
            // salida
            // 
            this.salida.HeaderText = "Salida";
            this.salida.Name = "salida";
            // 
            // B_Entrenar
            // 
            this.B_Entrenar.Location = new System.Drawing.Point(117, 372);
            this.B_Entrenar.Name = "B_Entrenar";
            this.B_Entrenar.Size = new System.Drawing.Size(75, 23);
            this.B_Entrenar.TabIndex = 5;
            this.B_Entrenar.Text = "Entrenar";
            this.B_Entrenar.UseVisualStyleBackColor = true;
            this.B_Entrenar.Click += new System.EventHandler(this.B_Entrenar_Click);
            // 
            // TB_Ocultas
            // 
            this.TB_Ocultas.Location = new System.Drawing.Point(345, 47);
            this.TB_Ocultas.Name = "TB_Ocultas";
            this.TB_Ocultas.Size = new System.Drawing.Size(44, 20);
            this.TB_Ocultas.TabIndex = 6;
            // 
            // F_Entrenar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 449);
            this.Controls.Add(this.TB_Ocultas);
            this.Controls.Add(this.B_Entrenar);
            this.Controls.Add(this.GV_Archivos);
            this.Controls.Add(this.B_Examinar);
            this.Controls.Add(this.TB_Carpeta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "F_Entrenar";
            this.Text = "F_Entrenar";
            ((System.ComponentModel.ISupportInitialize)(this.GV_Archivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Carpeta;
        private System.Windows.Forms.Button B_Examinar;
        private System.Windows.Forms.DataGridView GV_Archivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn archivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn salida;
        private System.Windows.Forms.Button B_Entrenar;
        private System.Windows.Forms.TextBox TB_Ocultas;
    }
}