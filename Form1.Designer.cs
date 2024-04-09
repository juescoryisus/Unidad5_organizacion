namespace Organizacioness
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCargarCarpeta = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnOrdenar_por_fecha = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCargarCarpeta
            // 
            this.btnCargarCarpeta.Location = new System.Drawing.Point(25, 24);
            this.btnCargarCarpeta.Name = "btnCargarCarpeta";
            this.btnCargarCarpeta.Size = new System.Drawing.Size(135, 54);
            this.btnCargarCarpeta.TabIndex = 0;
            this.btnCargarCarpeta.Text = "Cargar Carpeta";
            this.btnCargarCarpeta.UseVisualStyleBackColor = true;
            this.btnCargarCarpeta.Click += new System.EventHandler(this.btnCargarCarpeta_Click_1);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(176, 24);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(135, 54);
            this.btnOrdenar.TabIndex = 1;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click_1);
            // 
            // btnOrdenar_por_fecha
            // 
            this.btnOrdenar_por_fecha.Location = new System.Drawing.Point(327, 24);
            this.btnOrdenar_por_fecha.Name = "btnOrdenar_por_fecha";
            this.btnOrdenar_por_fecha.Size = new System.Drawing.Size(135, 54);
            this.btnOrdenar_por_fecha.TabIndex = 2;
            this.btnOrdenar_por_fecha.Text = "ordenar por fecha";
            this.btnOrdenar_por_fecha.UseVisualStyleBackColor = true;
            this.btnOrdenar_por_fecha.Click += new System.EventHandler(this.btnOrdenar_por_fecha_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(25, 123);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1210, 344);
            this.listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 556);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnOrdenar_por_fecha);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnCargarCarpeta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargarCarpeta;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnOrdenar_por_fecha;
        private System.Windows.Forms.ListBox listBox1;
    }
}

