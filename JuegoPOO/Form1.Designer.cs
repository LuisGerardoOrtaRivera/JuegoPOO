namespace JuegoPOO
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnAtacar = new System.Windows.Forms.Button();
            this.btnEspecial = new System.Windows.Forms.Button();
            this.cmbPersonaje = new System.Windows.Forms.ComboBox();
            this.lblJugador = new System.Windows.Forms.Label();
            this.lblVidaJugador = new System.Windows.Forms.Label();
            this.lblVidaEnemigo = new System.Windows.Forms.Label();
            this.pbVidaJugador = new System.Windows.Forms.ProgressBar();
            this.pbVidaEnemigo = new System.Windows.Forms.ProgressBar();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.picPersonaje = new System.Windows.Forms.PictureBox();
            this.picEnemigo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPersonaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemigo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(72, 330);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(113, 41);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnAtacar
            // 
            this.btnAtacar.Location = new System.Drawing.Point(72, 403);
            this.btnAtacar.Name = "btnAtacar";
            this.btnAtacar.Size = new System.Drawing.Size(113, 41);
            this.btnAtacar.TabIndex = 1;
            this.btnAtacar.Text = "Atacar";
            this.btnAtacar.UseVisualStyleBackColor = true;
            this.btnAtacar.Click += new System.EventHandler(this.btnAtacar_Click);
            // 
            // btnEspecial
            // 
            this.btnEspecial.Location = new System.Drawing.Point(72, 471);
            this.btnEspecial.Name = "btnEspecial";
            this.btnEspecial.Size = new System.Drawing.Size(113, 41);
            this.btnEspecial.TabIndex = 2;
            this.btnEspecial.Text = "Especial";
            this.btnEspecial.UseVisualStyleBackColor = true;
            this.btnEspecial.Click += new System.EventHandler(this.btnEspecial_Click);
            // 
            // cmbPersonaje
            // 
            this.cmbPersonaje.FormattingEnabled = true;
            this.cmbPersonaje.Location = new System.Drawing.Point(42, 108);
            this.cmbPersonaje.Name = "cmbPersonaje";
            this.cmbPersonaje.Size = new System.Drawing.Size(143, 28);
            this.cmbPersonaje.TabIndex = 3;
            // 
            // lblJugador
            // 
            this.lblJugador.AutoSize = true;
            this.lblJugador.Location = new System.Drawing.Point(81, 44);
            this.lblJugador.Name = "lblJugador";
            this.lblJugador.Size = new System.Drawing.Size(67, 20);
            this.lblJugador.TabIndex = 4;
            this.lblJugador.Text = "Jugador";
            // 
            // lblVidaJugador
            // 
            this.lblVidaJugador.AutoSize = true;
            this.lblVidaJugador.Location = new System.Drawing.Point(394, 116);
            this.lblVidaJugador.Name = "lblVidaJugador";
            this.lblVidaJugador.Size = new System.Drawing.Size(123, 20);
            this.lblVidaJugador.TabIndex = 5;
            this.lblVidaJugador.Text = "Vida del jugador";
            // 
            // lblVidaEnemigo
            // 
            this.lblVidaEnemigo.AutoSize = true;
            this.lblVidaEnemigo.Location = new System.Drawing.Point(651, 116);
            this.lblVidaEnemigo.Name = "lblVidaEnemigo";
            this.lblVidaEnemigo.Size = new System.Drawing.Size(131, 20);
            this.lblVidaEnemigo.TabIndex = 6;
            this.lblVidaEnemigo.Text = "Vida del enemigo";
            // 
            // pbVidaJugador
            // 
            this.pbVidaJugador.Location = new System.Drawing.Point(352, 170);
            this.pbVidaJugador.Name = "pbVidaJugador";
            this.pbVidaJugador.Size = new System.Drawing.Size(209, 29);
            this.pbVidaJugador.TabIndex = 7;
            // 
            // pbVidaEnemigo
            // 
            this.pbVidaEnemigo.Location = new System.Drawing.Point(603, 170);
            this.pbVidaEnemigo.Name = "pbVidaEnemigo";
            this.pbVidaEnemigo.Size = new System.Drawing.Size(209, 29);
            this.pbVidaEnemigo.TabIndex = 8;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(379, 389);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(367, 188);
            this.txtLog.TabIndex = 9;
            // 
            // picPersonaje
            // 
            this.picPersonaje.Location = new System.Drawing.Point(398, 228);
            this.picPersonaje.Name = "picPersonaje";
            this.picPersonaje.Size = new System.Drawing.Size(134, 143);
            this.picPersonaje.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPersonaje.TabIndex = 10;
            this.picPersonaje.TabStop = false;
            // 
            // picEnemigo
            // 
            this.picEnemigo.Location = new System.Drawing.Point(648, 228);
            this.picEnemigo.Name = "picEnemigo";
            this.picEnemigo.Size = new System.Drawing.Size(134, 143);
            this.picEnemigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEnemigo.TabIndex = 11;
            this.picEnemigo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(942, 589);
            this.Controls.Add(this.picEnemigo);
            this.Controls.Add(this.picPersonaje);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.pbVidaEnemigo);
            this.Controls.Add(this.pbVidaJugador);
            this.Controls.Add(this.lblVidaEnemigo);
            this.Controls.Add(this.lblVidaJugador);
            this.Controls.Add(this.lblJugador);
            this.Controls.Add(this.cmbPersonaje);
            this.Controls.Add(this.btnEspecial);
            this.Controls.Add(this.btnAtacar);
            this.Controls.Add(this.btnCrear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPersonaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemigo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnAtacar;
        private System.Windows.Forms.Button btnEspecial;
        private System.Windows.Forms.ComboBox cmbPersonaje;
        private System.Windows.Forms.Label lblJugador;
        private System.Windows.Forms.Label lblVidaJugador;
        private System.Windows.Forms.Label lblVidaEnemigo;
        private System.Windows.Forms.ProgressBar pbVidaJugador;
        private System.Windows.Forms.ProgressBar pbVidaEnemigo;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.PictureBox picPersonaje;
        private System.Windows.Forms.PictureBox picEnemigo;
    }
}