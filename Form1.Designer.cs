
namespace Joguinho_de_Buteco
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grupoPlacar = new System.Windows.Forms.GroupBox();
            this.placarCpu = new System.Windows.Forms.Label();
            this.placarJogador = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ImgEscolhaCpu = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ImgEscolhaJogador = new System.Windows.Forms.PictureBox();
            this.botaoTesoura = new System.Windows.Forms.Button();
            this.botaoPapel = new System.Windows.Forms.Button();
            this.botaoPedra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grupoPlacar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgEscolhaCpu)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgEscolhaJogador)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Controls.Add(this.grupoPlacar);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.botaoTesoura);
            this.splitContainer1.Panel2.Controls.Add(this.botaoPapel);
            this.splitContainer1.Panel2.Controls.Add(this.botaoPedra);
            this.splitContainer1.Size = new System.Drawing.Size(624, 441);
            this.splitContainer1.SplitterDistance = 249;
            this.splitContainer1.TabIndex = 0;
            // 
            // grupoPlacar
            // 
            this.grupoPlacar.Controls.Add(this.placarCpu);
            this.grupoPlacar.Controls.Add(this.placarJogador);
            this.grupoPlacar.Controls.Add(this.label2);
            this.grupoPlacar.Controls.Add(this.label1);
            this.grupoPlacar.Location = new System.Drawing.Point(207, 13);
            this.grupoPlacar.Name = "grupoPlacar";
            this.grupoPlacar.Size = new System.Drawing.Size(210, 222);
            this.grupoPlacar.TabIndex = 2;
            this.grupoPlacar.TabStop = false;
            this.grupoPlacar.Text = "Placar";
            // 
            // placarCpu
            // 
            this.placarCpu.AutoSize = true;
            this.placarCpu.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.placarCpu.Location = new System.Drawing.Point(139, 77);
            this.placarCpu.Name = "placarCpu";
            this.placarCpu.Size = new System.Drawing.Size(45, 54);
            this.placarCpu.TabIndex = 4;
            this.placarCpu.Text = "0";
            // 
            // placarJogador
            // 
            this.placarJogador.AutoSize = true;
            this.placarJogador.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.placarJogador.Location = new System.Drawing.Point(32, 77);
            this.placarJogador.Name = "placarJogador";
            this.placarJogador.Size = new System.Drawing.Size(45, 54);
            this.placarJogador.TabIndex = 3;
            this.placarJogador.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(139, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jogador";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ImgEscolhaCpu);
            this.groupBox2.Location = new System.Drawing.Point(417, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 221);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Jogada CPU";
            // 
            // ImgEscolhaCpu
            // 
            this.ImgEscolhaCpu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImgEscolhaCpu.Cursor = System.Windows.Forms.Cursors.Default;
            this.ImgEscolhaCpu.Location = new System.Drawing.Point(6, 19);
            this.ImgEscolhaCpu.Name = "ImgEscolhaCpu";
            this.ImgEscolhaCpu.Size = new System.Drawing.Size(198, 197);
            this.ImgEscolhaCpu.TabIndex = 0;
            this.ImgEscolhaCpu.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ImgEscolhaJogador);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Minha Jogada";
            // 
            // ImgEscolhaJogador
            // 
            this.ImgEscolhaJogador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImgEscolhaJogador.Cursor = System.Windows.Forms.Cursors.Default;
            this.ImgEscolhaJogador.Location = new System.Drawing.Point(8, 19);
            this.ImgEscolhaJogador.Name = "ImgEscolhaJogador";
            this.ImgEscolhaJogador.Size = new System.Drawing.Size(196, 197);
            this.ImgEscolhaJogador.TabIndex = 0;
            this.ImgEscolhaJogador.TabStop = false;
            // 
            // botaoTesoura
            // 
            this.botaoTesoura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoTesoura.BackgroundImage")));
            this.botaoTesoura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoTesoura.Cursor = System.Windows.Forms.Cursors.Default;
            this.botaoTesoura.Dock = System.Windows.Forms.DockStyle.Left;
            this.botaoTesoura.Location = new System.Drawing.Point(426, 0);
            this.botaoTesoura.Name = "botaoTesoura";
            this.botaoTesoura.Size = new System.Drawing.Size(198, 188);
            this.botaoTesoura.TabIndex = 2;
            this.botaoTesoura.UseVisualStyleBackColor = true;
            this.botaoTesoura.Click += new System.EventHandler(this.botaoTesoura_Click);
            // 
            // botaoPapel
            // 
            this.botaoPapel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoPapel.BackgroundImage")));
            this.botaoPapel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoPapel.Cursor = System.Windows.Forms.Cursors.Default;
            this.botaoPapel.Dock = System.Windows.Forms.DockStyle.Left;
            this.botaoPapel.Location = new System.Drawing.Point(213, 0);
            this.botaoPapel.Name = "botaoPapel";
            this.botaoPapel.Size = new System.Drawing.Size(213, 188);
            this.botaoPapel.TabIndex = 1;
            this.botaoPapel.UseVisualStyleBackColor = true;
            this.botaoPapel.Click += new System.EventHandler(this.botaoPapel_Click);
            // 
            // botaoPedra
            // 
            this.botaoPedra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoPedra.BackgroundImage")));
            this.botaoPedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoPedra.Cursor = System.Windows.Forms.Cursors.Default;
            this.botaoPedra.Dock = System.Windows.Forms.DockStyle.Left;
            this.botaoPedra.Location = new System.Drawing.Point(0, 0);
            this.botaoPedra.Name = "botaoPedra";
            this.botaoPedra.Size = new System.Drawing.Size(213, 188);
            this.botaoPedra.TabIndex = 0;
            this.botaoPedra.UseVisualStyleBackColor = true;
            this.botaoPedra.Click += new System.EventHandler(this.botaoPedra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedra Papel Tesoura";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grupoPlacar.ResumeLayout(false);
            this.grupoPlacar.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgEscolhaCpu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgEscolhaJogador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button botaoTesoura;
        private System.Windows.Forms.Button botaoPapel;
        private System.Windows.Forms.Button botaoPedra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox ImgEscolhaCpu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox ImgEscolhaJogador;
        private System.Windows.Forms.GroupBox grupoPlacar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label placarCpu;
        private System.Windows.Forms.Label placarJogador;
    }
}

