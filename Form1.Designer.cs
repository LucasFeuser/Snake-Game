namespace JogoDaCobrona
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PnTela = new System.Windows.Forms.Panel();
            this.Pontos = new System.Windows.Forms.Label();
            this.MenuStripMoreAbas = new System.Windows.Forms.MenuStrip();
            this.menuzinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boraJogarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairForaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tempo = new System.Windows.Forms.Timer(this.components);
            this.MenuStripMoreAbas.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnTela
            // 
            this.PnTela.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnTela.Location = new System.Drawing.Point(7, 65);
            this.PnTela.Name = "PnTela";
            this.PnTela.Size = new System.Drawing.Size(428, 428);
            this.PnTela.TabIndex = 0;
            // 
            // Pontos
            // 
            this.Pontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pontos.Location = new System.Drawing.Point(7, 28);
            this.Pontos.Name = "Pontos";
            this.Pontos.Size = new System.Drawing.Size(422, 34);
            this.Pontos.TabIndex = 1;
            this.Pontos.Text = "PONTOS: 0";
            this.Pontos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MenuStripMoreAbas
            // 
            this.MenuStripMoreAbas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuzinToolStripMenuItem});
            this.MenuStripMoreAbas.Location = new System.Drawing.Point(0, 0);
            this.MenuStripMoreAbas.Name = "MenuStripMoreAbas";
            this.MenuStripMoreAbas.Size = new System.Drawing.Size(441, 24);
            this.MenuStripMoreAbas.TabIndex = 2;
            this.MenuStripMoreAbas.Text = "menuStrip1";
            // 
            // menuzinToolStripMenuItem
            // 
            this.menuzinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boraJogarToolStripMenuItem,
            this.sairForaToolStripMenuItem});
            this.menuzinToolStripMenuItem.Name = "menuzinToolStripMenuItem";
            this.menuzinToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.menuzinToolStripMenuItem.Text = "Menuzin";
            // 
            // boraJogarToolStripMenuItem
            // 
            this.boraJogarToolStripMenuItem.Name = "boraJogarToolStripMenuItem";
            this.boraJogarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.boraJogarToolStripMenuItem.Text = "Bora jogar!";
            this.boraJogarToolStripMenuItem.Click += new System.EventHandler(this.boraJogarToolStripMenuItem_Click);
            // 
            // sairForaToolStripMenuItem
            // 
            this.sairForaToolStripMenuItem.Name = "sairForaToolStripMenuItem";
            this.sairForaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairForaToolStripMenuItem.Text = "Sair fora";
            this.sairForaToolStripMenuItem.Click += new System.EventHandler(this.sairForaToolStripMenuItem_Click);
            // 
            // Tempo
            // 
            this.Tempo.Tick += new System.EventHandler(this.Tempo_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 498);
            this.Controls.Add(this.Pontos);
            this.Controls.Add(this.PnTela);
            this.Controls.Add(this.MenuStripMoreAbas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStripMoreAbas;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JogoDaCobrona";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Clicado);
            this.MenuStripMoreAbas.ResumeLayout(false);
            this.MenuStripMoreAbas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnTela;
        private System.Windows.Forms.Label Pontos;
        private System.Windows.Forms.MenuStrip MenuStripMoreAbas;
        private System.Windows.Forms.ToolStripMenuItem menuzinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boraJogarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairForaToolStripMenuItem;
        private System.Windows.Forms.Timer Tempo;
    }
}

