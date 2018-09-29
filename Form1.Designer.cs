namespace PONG
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbPalaDos = new System.Windows.Forms.PictureBox();
            this.pbLineaIntermedia = new System.Windows.Forms.PictureBox();
            this.pbPelota = new System.Windows.Forms.PictureBox();
            this.pbPala = new System.Windows.Forms.PictureBox();
            this.lblNivel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPalaDos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLineaIntermedia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPelota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPala)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.pbPalaDos);
            this.panel1.Controls.Add(this.pbPelota);
            this.panel1.Controls.Add(this.pbPala);
            this.panel1.Controls.Add(this.lblNivel);
            this.panel1.Controls.Add(this.pbLineaIntermedia);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 572);
            this.panel1.TabIndex = 0;
            // 
            // pbPalaDos
            // 
            this.pbPalaDos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pbPalaDos.Location = new System.Drawing.Point(852, 187);
            this.pbPalaDos.Name = "pbPalaDos";
            this.pbPalaDos.Size = new System.Drawing.Size(25, 149);
            this.pbPalaDos.TabIndex = 4;
            this.pbPalaDos.TabStop = false;
            // 
            // pbLineaIntermedia
            // 
            this.pbLineaIntermedia.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbLineaIntermedia.Location = new System.Drawing.Point(436, 12);
            this.pbLineaIntermedia.Name = "pbLineaIntermedia";
            this.pbLineaIntermedia.Size = new System.Drawing.Size(10, 548);
            this.pbLineaIntermedia.TabIndex = 3;
            this.pbLineaIntermedia.TabStop = false;
            // 
            // pbPelota
            // 
            this.pbPelota.BackColor = System.Drawing.Color.Yellow;
            this.pbPelota.Location = new System.Drawing.Point(631, 248);
            this.pbPelota.Name = "pbPelota";
            this.pbPelota.Size = new System.Drawing.Size(30, 30);
            this.pbPelota.TabIndex = 2;
            this.pbPelota.TabStop = false;
            // 
            // pbPala
            // 
            this.pbPala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pbPala.Location = new System.Drawing.Point(17, 187);
            this.pbPala.Name = "pbPala";
            this.pbPala.Size = new System.Drawing.Size(25, 149);
            this.pbPala.TabIndex = 1;
            this.pbPala.TabStop = false;
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNivel.Location = new System.Drawing.Point(321, 9);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(241, 55);
            this.lblNivel.TabIndex = 0;
            this.lblNivel.Text = "<<0 - 0>>";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 572);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPalaDos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLineaIntermedia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPelota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPala)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbLineaIntermedia;
        private System.Windows.Forms.PictureBox pbPelota;
        private System.Windows.Forms.PictureBox pbPala;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbPalaDos;
    }
}

