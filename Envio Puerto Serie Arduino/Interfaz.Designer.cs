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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interfaz));
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
            this.Bconectar.AutoSize = true;
            this.Bconectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bconectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bconectar.Location = new System.Drawing.Point(23, 129);
            this.Bconectar.Name = "Bconectar";
            this.Bconectar.Size = new System.Drawing.Size(135, 27);
            this.Bconectar.TabIndex = 4;
            this.Bconectar.Text = "Conectar";
            this.Bconectar.UseVisualStyleBackColor = true;
            this.Bconectar.Click += new System.EventHandler(this.Bconectar_Click);
            // 
            // Benviar
            // 
            this.Benviar.AutoSize = true;
            this.Benviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Benviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Benviar.Location = new System.Drawing.Point(170, 129);
            this.Benviar.Name = "Benviar";
            this.Benviar.Size = new System.Drawing.Size(94, 27);
            this.Benviar.TabIndex = 5;
            this.Benviar.Text = "Enviar";
            this.Benviar.UseVisualStyleBackColor = true;
            this.Benviar.Click += new System.EventHandler(this.Benviar_Click);
            // 
            // Bactualizar
            // 
            this.Bactualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bactualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bactualizar.Image = ((System.Drawing.Image)(resources.GetObject("Bactualizar.Image")));
            this.Bactualizar.Location = new System.Drawing.Point(134, 99);
            this.Bactualizar.Margin = new System.Windows.Forms.Padding(0);
            this.Bactualizar.Name = "Bactualizar";
            this.Bactualizar.Size = new System.Drawing.Size(24, 24);
            this.Bactualizar.TabIndex = 2;
            this.Bactualizar.UseVisualStyleBackColor = true;
            this.Bactualizar.Click += new System.EventHandler(this.Bactualizar_Click);
            // 
            // Ltitulo
            // 
            this.Ltitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ltitulo.Location = new System.Drawing.Point(19, 20);
            this.Ltitulo.Margin = new System.Windows.Forms.Padding(0);
            this.Ltitulo.Name = "Ltitulo";
            this.Ltitulo.Size = new System.Drawing.Size(244, 17);
            this.Ltitulo.TabIndex = 3;
            this.Ltitulo.Text = "Envío de datos.";
            this.Ltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBdato
            // 
            this.TBdato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBdato.Location = new System.Drawing.Point(170, 100);
            this.TBdato.Name = "TBdato";
            this.TBdato.Size = new System.Drawing.Size(94, 23);
            this.TBdato.TabIndex = 3;
            this.TBdato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBdato_TextEnter);
            // 
            // CBpuertos
            // 
            this.CBpuertos.AllowDrop = true;
            this.CBpuertos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBpuertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBpuertos.FormattingEnabled = true;
            this.CBpuertos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CBpuertos.ItemHeight = 16;
            this.CBpuertos.Location = new System.Drawing.Point(23, 99);
            this.CBpuertos.Name = "CBpuertos";
            this.CBpuertos.Size = new System.Drawing.Size(105, 24);
            this.CBpuertos.TabIndex = 1;
            // 
            // Lpuertos
            // 
            this.Lpuertos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lpuertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lpuertos.Location = new System.Drawing.Point(20, 67);
            this.Lpuertos.Name = "Lpuertos";
            this.Lpuertos.Size = new System.Drawing.Size(138, 17);
            this.Lpuertos.TabIndex = 6;
            this.Lpuertos.Text = "Puertos disponibles:";
            this.Lpuertos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ldato
            // 
            this.Ldato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ldato.Location = new System.Drawing.Point(167, 67);
            this.Ldato.Name = "Ldato";
            this.Ldato.Size = new System.Drawing.Size(97, 17);
            this.Ldato.TabIndex = 7;
            this.Ldato.Text = "Dato a enviar:";
            this.Ldato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lestado
            // 
            this.Lestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Lestado.Location = new System.Drawing.Point(23, 159);
            this.Lestado.Name = "Lestado";
            this.Lestado.Size = new System.Drawing.Size(241, 32);
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
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.Lestado);
            this.Controls.Add(this.Ldato);
            this.Controls.Add(this.Lpuertos);
            this.Controls.Add(this.CBpuertos);
            this.Controls.Add(this.TBdato);
            this.Controls.Add(this.Ltitulo);
            this.Controls.Add(this.Bactualizar);
            this.Controls.Add(this.Benviar);
            this.Controls.Add(this.Bconectar);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 250);
            this.MinimumSize = new System.Drawing.Size(300, 250);
            this.Name = "Interfaz";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Envío Arduino";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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

