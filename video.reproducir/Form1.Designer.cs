
namespace video.reproducir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btncargar = new System.Windows.Forms.Button();
            this.btnreproducir = new System.Windows.Forms.Button();
            this.btnparar = new System.Windows.Forms.Button();
            this.btnpausa = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnAbrirPdf = new System.Windows.Forms.Button();
            this.btnabrirNavegador = new System.Windows.Forms.Button();
            this.lblruta = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncargar
            // 
            this.btncargar.Location = new System.Drawing.Point(12, 299);
            this.btncargar.Name = "btncargar";
            this.btncargar.Size = new System.Drawing.Size(75, 23);
            this.btncargar.TabIndex = 5;
            this.btncargar.Text = "cargar";
            this.btncargar.UseVisualStyleBackColor = true;
            this.btncargar.Click += new System.EventHandler(this.btncargar_Click);
            // 
            // btnreproducir
            // 
            this.btnreproducir.Location = new System.Drawing.Point(107, 299);
            this.btnreproducir.Name = "btnreproducir";
            this.btnreproducir.Size = new System.Drawing.Size(75, 23);
            this.btnreproducir.TabIndex = 6;
            this.btnreproducir.Text = "reproducir";
            this.btnreproducir.UseVisualStyleBackColor = true;
            this.btnreproducir.Click += new System.EventHandler(this.btnreproducir_Click);
            // 
            // btnparar
            // 
            this.btnparar.Location = new System.Drawing.Point(205, 299);
            this.btnparar.Name = "btnparar";
            this.btnparar.Size = new System.Drawing.Size(75, 23);
            this.btnparar.TabIndex = 7;
            this.btnparar.Text = "parar";
            this.btnparar.UseVisualStyleBackColor = true;
            this.btnparar.Click += new System.EventHandler(this.btnparar_Click);
            // 
            // btnpausa
            // 
            this.btnpausa.Location = new System.Drawing.Point(299, 299);
            this.btnpausa.Name = "btnpausa";
            this.btnpausa.Size = new System.Drawing.Size(75, 23);
            this.btnpausa.TabIndex = 8;
            this.btnpausa.Text = "pausa";
            this.btnpausa.UseVisualStyleBackColor = true;
            this.btnpausa.Click += new System.EventHandler(this.btnpausa_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "todos|*.*";
            // 
            // btnAbrirPdf
            // 
            this.btnAbrirPdf.Location = new System.Drawing.Point(614, 347);
            this.btnAbrirPdf.Name = "btnAbrirPdf";
            this.btnAbrirPdf.Size = new System.Drawing.Size(92, 38);
            this.btnAbrirPdf.TabIndex = 11;
            this.btnAbrirPdf.Text = "Abrir PDF";
            this.btnAbrirPdf.UseVisualStyleBackColor = true;
            this.btnAbrirPdf.Click += new System.EventHandler(this.btnAbrirPdf_Click);
            // 
            // btnabrirNavegador
            // 
            this.btnabrirNavegador.Location = new System.Drawing.Point(744, 347);
            this.btnabrirNavegador.Name = "btnabrirNavegador";
            this.btnabrirNavegador.Size = new System.Drawing.Size(97, 38);
            this.btnabrirNavegador.TabIndex = 12;
            this.btnabrirNavegador.Text = "Abrir WebBrowser";
            this.btnabrirNavegador.UseVisualStyleBackColor = true;
            this.btnabrirNavegador.Click += new System.EventHandler(this.btnabrirNavegador_Click);
            // 
            // lblruta
            // 
            this.lblruta.AutoSize = true;
            this.lblruta.Location = new System.Drawing.Point(23, 347);
            this.lblruta.Name = "lblruta";
            this.lblruta.Size = new System.Drawing.Size(30, 13);
            this.lblruta.TabIndex = 13;
            this.lblruta.Text = "Ruta";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 23);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(829, 253);
            this.axWindowsMediaPlayer1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 410);
            this.Controls.Add(this.lblruta);
            this.Controls.Add(this.btnabrirNavegador);
            this.Controls.Add(this.btnAbrirPdf);
            this.Controls.Add(this.btnpausa);
            this.Controls.Add(this.btnparar);
            this.Controls.Add(this.btnreproducir);
            this.Controls.Add(this.btncargar);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "Form1";
            this.Text = "leerpodf";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btncargar;
        private System.Windows.Forms.Button btnreproducir;
        private System.Windows.Forms.Button btnparar;
        private System.Windows.Forms.Button btnpausa;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnAbrirPdf;
        private System.Windows.Forms.Button btnabrirNavegador;
        private System.Windows.Forms.Label lblruta;
    }
}

