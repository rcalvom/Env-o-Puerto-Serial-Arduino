namespace Puerto_Serie_Arduino {
    partial class Interfaz {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.Bconectar = new System.Windows.Forms.Button();
            this.Benviar = new System.Windows.Forms.Button();
            this.Bactualizar = new System.Windows.Forms.Button();
            this.Ltitulo = new System.Windows.Forms.Label();
            this.TBdato = new System.Windows.Forms.TextBox();
            this.CBpuertos = new System.Windows.Forms.ComboBox();
            this.Lpuertos = new System.Windows.Forms.Label();
            this.Ldato = new System.Windows.Forms.Label();
            this.Lestado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Bconectar
            // 
            this.Bconectar.Font = new System.Drawing.Font("Ancizar Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bconectar.Location = new System.Drawing.Point(23, 262);
            this.Bconectar.Name = "Bconectar";
            this.Bconectar.Size = new System.Drawing.Size(204, 34);
            this.Bconectar.TabIndex = 4;
            this.Bconectar.Text = "Conectar";
            this.Bconectar.UseVisualStyleBackColor = true;
            this.Bconectar.Click += new System.EventHandler(this.Bconectar_Click);
            // 
            // Benviar
            // 
            this.Benviar.Font = new System.Drawing.Font("Ancizar Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Benviar.Location = new System.Drawing.Point(277, 262);
            this.Benviar.Name = "Benviar";
            this.Benviar.Size = new System.Drawing.Size(184, 34);
            this.Benviar.TabIndex = 5;
            this.Benviar.Text = "Enviar";
            this.Benviar.UseVisualStyleBackColor = true;
            this.Benviar.Click += new System.EventHandler(this.Benviar_Click);
            // 
            // Bactualizar
            // 
            this.Bactualizar.Font = new System.Drawing.Font("Ancizar Sans", 16F, System.Drawing.FontStyle.Bold);
            this.Bactualizar.Location = new System.Drawing.Point(195, 219);
            this.Bactualizar.Name = "Bactualizar";
            this.Bactualizar.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Bactualizar.Size = new System.Drawing.Size(32, 32);
            this.Bactualizar.TabIndex = 2;
            this.Bactualizar.UseVisualStyleBackColor = true;
            this.Bactualizar.Click += new System.EventHandler(this.Bactualizar_Click);
            // 
            // Ltitulo
            // 
            this.Ltitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ltitulo.Font = new System.Drawing.Font("Ancizar Sans Extrabold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ltitulo.Location = new System.Drawing.Point(23, 50);
            this.Ltitulo.Name = "Ltitulo";
            this.Ltitulo.Padding = new System.Windows.Forms.Padding(5);
            this.Ltitulo.Size = new System.Drawing.Size(438, 50);
            this.Ltitulo.TabIndex = 3;
            this.Ltitulo.Text = "Envío de datos.";
            this.Ltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBdato
            // 
            this.TBdato.Font = new System.Drawing.Font("Ancizar Sans", 16F, System.Drawing.FontStyle.Bold);
            this.TBdato.Location = new System.Drawing.Point(277, 218);
            this.TBdato.Name = "TBdato";
            this.TBdato.Size = new System.Drawing.Size(184, 33);
            this.TBdato.TabIndex = 3;
            this.TBdato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBdato_TextEnter);
            // 
            // CBpuertos
            // 
            this.CBpuertos.AllowDrop = true;
            this.CBpuertos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBpuertos.Font = new System.Drawing.Font("Ancizar Sans", 16F, System.Drawing.FontStyle.Bold);
            this.CBpuertos.FormattingEnabled = true;
            this.CBpuertos.Location = new System.Drawing.Point(23, 219);
            this.CBpuertos.Name = "CBpuertos";
            this.CBpuertos.Size = new System.Drawing.Size(166, 32);
            this.CBpuertos.TabIndex = 1;
            // 
            // Lpuertos
            // 
            this.Lpuertos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lpuertos.Font = new System.Drawing.Font("Ancizar Sans", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lpuertos.Location = new System.Drawing.Point(23, 181);
            this.Lpuertos.Name = "Lpuertos";
            this.Lpuertos.Size = new System.Drawing.Size(204, 24);
            this.Lpuertos.TabIndex = 6;
            this.Lpuertos.Text = "Puertos disponibles:";
            this.Lpuertos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ldato
            // 
            this.Ldato.Font = new System.Drawing.Font("Ancizar Sans", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ldato.Location = new System.Drawing.Point(273, 181);
            this.Ldato.Name = "Ldato";
            this.Ldato.Size = new System.Drawing.Size(188, 24);
            this.Ldato.TabIndex = 7;
            this.Ldato.Text = "Dato a enviar:";
            this.Ldato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lestado
            // 
            this.Lestado.Font = new System.Drawing.Font("Ancizar Sans", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lestado.Location = new System.Drawing.Point(23, 338);
            this.Lestado.Name = "Lestado";
            this.Lestado.Size = new System.Drawing.Size(438, 57);
            this.Lestado.TabIndex = 8;
            this.Lestado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Interfaz
            // 
            this.AccessibleName = "Envío de datos por el puerto serie";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.Lestado);
            this.Controls.Add(this.Ldato);
            this.Controls.Add(this.Lpuertos);
            this.Controls.Add(this.CBpuertos);
            this.Controls.Add(this.TBdato);
            this.Controls.Add(this.Ltitulo);
            this.Controls.Add(this.Bactualizar);
            this.Controls.Add(this.Benviar);
            this.Controls.Add(this.Bconectar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Interfaz";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Envío de datos Arduino";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bconectar;
        private System.Windows.Forms.Button Benviar;
        private System.Windows.Forms.Button Bactualizar;
        private System.Windows.Forms.Label Ltitulo;
        private System.Windows.Forms.TextBox TBdato;
        private System.Windows.Forms.ComboBox CBpuertos;
        private System.Windows.Forms.Label Lpuertos;
        private System.Windows.Forms.Label Ldato;
        private System.Windows.Forms.Label Lestado;
    }
}

