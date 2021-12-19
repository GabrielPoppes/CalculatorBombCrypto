
namespace CalculatorBombCrypto
{
    partial class FrmLoading
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelAzul = new System.Windows.Forms.Panel();
            this.panelAmarelo = new System.Windows.Forms.Panel();
            this.lblConectando = new System.Windows.Forms.Label();
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picEntrarApp = new System.Windows.Forms.PictureBox();
            this.picBonecoCrypto = new System.Windows.Forms.PictureBox();
            this.panelAzul.SuspendLayout();
            this.panelAmarelo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEntrarApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBonecoCrypto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAzul
            // 
            this.panelAzul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(27)))), ((int)(((byte)(86)))));
            this.panelAzul.Controls.Add(this.picEntrarApp);
            this.panelAzul.Controls.Add(this.lblConectando);
            this.panelAzul.Controls.Add(this.picBonecoCrypto);
            this.panelAzul.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAzul.Location = new System.Drawing.Point(0, 225);
            this.panelAzul.Name = "panelAzul";
            this.panelAzul.Size = new System.Drawing.Size(800, 225);
            this.panelAzul.TabIndex = 0;
            // 
            // panelAmarelo
            // 
            this.panelAmarelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(176)))), ((int)(((byte)(50)))));
            this.panelAmarelo.Controls.Add(this.pictureBox2);
            this.panelAmarelo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAmarelo.Location = new System.Drawing.Point(0, 0);
            this.panelAmarelo.Name = "panelAmarelo";
            this.panelAmarelo.Size = new System.Drawing.Size(800, 225);
            this.panelAmarelo.TabIndex = 1;
            // 
            // lblConectando
            // 
            this.lblConectando.AutoSize = true;
            this.lblConectando.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConectando.ForeColor = System.Drawing.Color.White;
            this.lblConectando.Location = new System.Drawing.Point(360, 3);
            this.lblConectando.Name = "lblConectando";
            this.lblConectando.Size = new System.Drawing.Size(93, 19);
            this.lblConectando.TabIndex = 1;
            this.lblConectando.Text = "Conectando...";
            // 
            // timerLoading
            // 
            this.timerLoading.Enabled = true;
            this.timerLoading.Interval = 10;
            this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CalculatorBombCrypto.Properties.Resources.CALCULADORA_BOMBCRYPTO;
            this.pictureBox2.Location = new System.Drawing.Point(193, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(460, 180);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // picEntrarApp
            // 
            this.picEntrarApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEntrarApp.Image = global::CalculatorBombCrypto.Properties.Resources.CALCULADORA_BOMBCRYPTO__1_;
            this.picEntrarApp.Location = new System.Drawing.Point(221, 283);
            this.picEntrarApp.Name = "picEntrarApp";
            this.picEntrarApp.Size = new System.Drawing.Size(422, 144);
            this.picEntrarApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEntrarApp.TabIndex = 3;
            this.picEntrarApp.TabStop = false;
            this.picEntrarApp.Click += new System.EventHandler(this.picEntrarApp_Click);
            // 
            // picBonecoCrypto
            // 
            this.picBonecoCrypto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBonecoCrypto.Image = global::CalculatorBombCrypto.Properties.Resources.ninja;
            this.picBonecoCrypto.Location = new System.Drawing.Point(300, 25);
            this.picBonecoCrypto.Name = "picBonecoCrypto";
            this.picBonecoCrypto.Size = new System.Drawing.Size(261, 305);
            this.picBonecoCrypto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBonecoCrypto.TabIndex = 0;
            this.picBonecoCrypto.TabStop = false;
            this.picBonecoCrypto.Click += new System.EventHandler(this.picBonecoCrypto_Click);
            // 
            // FrmLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelAmarelo);
            this.Controls.Add(this.panelAzul);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmLoading_Load);
            this.panelAzul.ResumeLayout(false);
            this.panelAzul.PerformLayout();
            this.panelAmarelo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEntrarApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBonecoCrypto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAzul;
        private System.Windows.Forms.Panel panelAmarelo;
        private System.Windows.Forms.PictureBox picBonecoCrypto;
        private System.Windows.Forms.Label lblConectando;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timerLoading;
        private System.Windows.Forms.PictureBox picEntrarApp;
    }
}

