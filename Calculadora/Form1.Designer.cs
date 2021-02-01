
namespace Calculadora
{
    partial class Form1
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
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.visor = new System.Windows.Forms.TextBox();
            this.bt0 = new System.Windows.Forms.Button();
            this.btmultiplicacao = new System.Windows.Forms.Button();
            this.btsubtracao = new System.Windows.Forms.Button();
            this.btsoma = new System.Windows.Forms.Button();
            this.btdivisao = new System.Windows.Forms.Button();
            this.btigual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(26, 175);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(75, 23);
            this.bt1.TabIndex = 0;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(107, 175);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(75, 23);
            this.bt2.TabIndex = 1;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(188, 175);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(75, 23);
            this.bt3.TabIndex = 2;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // bt6
            // 
            this.bt6.Location = new System.Drawing.Point(188, 146);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(75, 23);
            this.bt6.TabIndex = 5;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.bt6_Click);
            // 
            // bt5
            // 
            this.bt5.Location = new System.Drawing.Point(107, 146);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(75, 23);
            this.bt5.TabIndex = 4;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(26, 146);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(75, 23);
            this.bt4.TabIndex = 3;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // bt9
            // 
            this.bt9.Location = new System.Drawing.Point(188, 117);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(75, 23);
            this.bt9.TabIndex = 8;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.bt9_Click);
            // 
            // bt8
            // 
            this.bt8.Location = new System.Drawing.Point(107, 117);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(75, 23);
            this.bt8.TabIndex = 7;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.bt8_Click);
            // 
            // bt7
            // 
            this.bt7.Location = new System.Drawing.Point(26, 117);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(75, 23);
            this.bt7.TabIndex = 6;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.bt7_Click);
            // 
            // visor
            // 
            this.visor.Enabled = false;
            this.visor.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visor.Location = new System.Drawing.Point(26, 12);
            this.visor.Name = "visor";
            this.visor.Size = new System.Drawing.Size(237, 40);
            this.visor.TabIndex = 9;
            this.visor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bt0
            // 
            this.bt0.Location = new System.Drawing.Point(26, 204);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(237, 23);
            this.bt0.TabIndex = 10;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.bt0_Click);
            // 
            // btmultiplicacao
            // 
            this.btmultiplicacao.Location = new System.Drawing.Point(147, 88);
            this.btmultiplicacao.Name = "btmultiplicacao";
            this.btmultiplicacao.Size = new System.Drawing.Size(55, 23);
            this.btmultiplicacao.TabIndex = 13;
            this.btmultiplicacao.Text = "*";
            this.btmultiplicacao.UseVisualStyleBackColor = true;
            // 
            // btsubtracao
            // 
            this.btsubtracao.Location = new System.Drawing.Point(86, 88);
            this.btsubtracao.Name = "btsubtracao";
            this.btsubtracao.Size = new System.Drawing.Size(55, 23);
            this.btsubtracao.TabIndex = 12;
            this.btsubtracao.Text = "-";
            this.btsubtracao.UseVisualStyleBackColor = true;
            this.btsubtracao.Click += new System.EventHandler(this.btsubtracao_Click);
            // 
            // btsoma
            // 
            this.btsoma.Location = new System.Drawing.Point(26, 88);
            this.btsoma.Name = "btsoma";
            this.btsoma.Size = new System.Drawing.Size(55, 23);
            this.btsoma.TabIndex = 11;
            this.btsoma.Text = "+";
            this.btsoma.UseVisualStyleBackColor = true;
            this.btsoma.Click += new System.EventHandler(this.btsoma_Click);
            // 
            // btdivisao
            // 
            this.btdivisao.Location = new System.Drawing.Point(208, 88);
            this.btdivisao.Name = "btdivisao";
            this.btdivisao.Size = new System.Drawing.Size(55, 23);
            this.btdivisao.TabIndex = 14;
            this.btdivisao.Text = "/";
            this.btdivisao.UseVisualStyleBackColor = true;
            // 
            // btigual
            // 
            this.btigual.Location = new System.Drawing.Point(26, 59);
            this.btigual.Name = "btigual";
            this.btigual.Size = new System.Drawing.Size(237, 23);
            this.btigual.TabIndex = 15;
            this.btigual.Text = "=";
            this.btigual.UseVisualStyleBackColor = true;
            this.btigual.Click += new System.EventHandler(this.btigual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 253);
            this.Controls.Add(this.btigual);
            this.Controls.Add(this.btdivisao);
            this.Controls.Add(this.btmultiplicacao);
            this.Controls.Add(this.btsubtracao);
            this.Controls.Add(this.btsoma);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.visor);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.TextBox visor;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button btmultiplicacao;
        private System.Windows.Forms.Button btsubtracao;
        private System.Windows.Forms.Button btsoma;
        private System.Windows.Forms.Button btdivisao;
        private System.Windows.Forms.Button btigual;
    }
}

