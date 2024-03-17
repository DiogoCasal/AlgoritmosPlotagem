
namespace TrabalhoPratico1
{
    partial class tela
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
            this.painel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CohenSutherland = new System.Windows.Forms.Button();
            this.DescRecorte = new System.Windows.Forms.Label();
            this.DescRast = new System.Windows.Forms.Label();
            this.DescTrans = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.Bresenham = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.lbY2 = new System.Windows.Forms.Label();
            this.lbX2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btApagar = new System.Windows.Forms.Button();
            this.btCor = new System.Windows.Forms.Button();
            this.btDesenhar = new System.Windows.Forms.Button();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.lbY1 = new System.Windows.Forms.Label();
            this.lbX1 = new System.Windows.Forms.Label();
            this.imagem = new System.Windows.Forms.PictureBox();
            this.cdlg = new System.Windows.Forms.ColorDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.painel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // painel
            // 
            this.painel.Controls.Add(this.button7);
            this.painel.Controls.Add(this.pictureBox2);
            this.painel.Controls.Add(this.label2);
            this.painel.Controls.Add(this.label1);
            this.painel.Controls.Add(this.pictureBox1);
            this.painel.Controls.Add(this.CohenSutherland);
            this.painel.Controls.Add(this.DescRecorte);
            this.painel.Controls.Add(this.DescRast);
            this.painel.Controls.Add(this.DescTrans);
            this.painel.Controls.Add(this.button6);
            this.painel.Controls.Add(this.Bresenham);
            this.painel.Controls.Add(this.button5);
            this.painel.Controls.Add(this.txtY2);
            this.painel.Controls.Add(this.txtX2);
            this.painel.Controls.Add(this.lbY2);
            this.painel.Controls.Add(this.lbX2);
            this.painel.Controls.Add(this.button4);
            this.painel.Controls.Add(this.button3);
            this.painel.Controls.Add(this.button2);
            this.painel.Controls.Add(this.button1);
            this.painel.Controls.Add(this.btApagar);
            this.painel.Controls.Add(this.btCor);
            this.painel.Controls.Add(this.btDesenhar);
            this.painel.Controls.Add(this.txtY1);
            this.painel.Controls.Add(this.txtX1);
            this.painel.Controls.Add(this.lbY1);
            this.painel.Controls.Add(this.lbX1);
            this.painel.Dock = System.Windows.Forms.DockStyle.Right;
            this.painel.Location = new System.Drawing.Point(1083, 0);
            this.painel.Margin = new System.Windows.Forms.Padding(4);
            this.painel.Name = "painel";
            this.painel.Size = new System.Drawing.Size(505, 751);
            this.painel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 31);
            this.label1.TabIndex = 22;
            this.label1.Text = "Cohen-Sutherland";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(222, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 230);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // CohenSutherland
            // 
            this.CohenSutherland.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CohenSutherland.Location = new System.Drawing.Point(8, 617);
            this.CohenSutherland.Margin = new System.Windows.Forms.Padding(4);
            this.CohenSutherland.Name = "CohenSutherland";
            this.CohenSutherland.Size = new System.Drawing.Size(149, 44);
            this.CohenSutherland.TabIndex = 21;
            this.CohenSutherland.Text = "Cohen-Sutherland";
            this.CohenSutherland.UseVisualStyleBackColor = true;
            this.CohenSutherland.Click += new System.EventHandler(this.btCohenSutherlandLineDraw);
            // 
            // DescRecorte
            // 
            this.DescRecorte.AutoSize = true;
            this.DescRecorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescRecorte.Location = new System.Drawing.Point(10, 582);
            this.DescRecorte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DescRecorte.Name = "DescRecorte";
            this.DescRecorte.Size = new System.Drawing.Size(117, 31);
            this.DescRecorte.TabIndex = 20;
            this.DescRecorte.Text = "Recorte";
            // 
            // DescRast
            // 
            this.DescRast.AutoSize = true;
            this.DescRast.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescRast.Location = new System.Drawing.Point(10, 203);
            this.DescRast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DescRast.Name = "DescRast";
            this.DescRast.Size = new System.Drawing.Size(186, 31);
            this.DescRast.TabIndex = 19;
            this.DescRast.Text = "Rasterização";
            // 
            // DescTrans
            // 
            this.DescTrans.AutoSize = true;
            this.DescTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescTrans.Location = new System.Drawing.Point(10, 396);
            this.DescTrans.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DescTrans.Name = "DescTrans";
            this.DescTrans.Size = new System.Drawing.Size(134, 31);
            this.DescTrans.TabIndex = 18;
            this.DescTrans.Text = "Trans 2D";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(8, 342);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 44);
            this.button6.TabIndex = 17;
            this.button6.Text = "Circulo";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btCirculoBres);
            // 
            // Bresenham
            // 
            this.Bresenham.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bresenham.Location = new System.Drawing.Point(8, 290);
            this.Bresenham.Margin = new System.Windows.Forms.Padding(4);
            this.Bresenham.Name = "Bresenham";
            this.Bresenham.Size = new System.Drawing.Size(100, 44);
            this.Bresenham.TabIndex = 16;
            this.Bresenham.Text = "Bresenham";
            this.Bresenham.UseVisualStyleBackColor = true;
            this.Bresenham.Click += new System.EventHandler(this.bt_BresenhamLineDraw);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(8, 534);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 44);
            this.button5.TabIndex = 15;
            this.button5.Text = "Escala -";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.escalaDown);
            // 
            // txtY2
            // 
            this.txtY2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtY2.Location = new System.Drawing.Point(105, 138);
            this.txtY2.Margin = new System.Windows.Forms.Padding(4);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(65, 37);
            this.txtY2.TabIndex = 14;
            this.txtY2.Text = "0";
            // 
            // txtX2
            // 
            this.txtX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX2.Location = new System.Drawing.Point(109, 62);
            this.txtX2.Margin = new System.Windows.Forms.Padding(4);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(61, 37);
            this.txtX2.TabIndex = 13;
            this.txtX2.Text = "0";
            // 
            // lbY2
            // 
            this.lbY2.AutoSize = true;
            this.lbY2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbY2.Location = new System.Drawing.Point(109, 103);
            this.lbY2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbY2.Name = "lbY2";
            this.lbY2.Size = new System.Drawing.Size(33, 31);
            this.lbY2.TabIndex = 12;
            this.lbY2.Text = "Y";
            // 
            // lbX2
            // 
            this.lbX2.AutoSize = true;
            this.lbX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbX2.Location = new System.Drawing.Point(109, 27);
            this.lbX2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbX2.Name = "lbX2";
            this.lbX2.Size = new System.Drawing.Size(33, 31);
            this.lbX2.TabIndex = 11;
            this.lbX2.Text = "X";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(116, 431);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 44);
            this.button4.TabIndex = 10;
            this.button4.Text = "Translação";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.translacao);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(116, 483);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 44);
            this.button3.TabIndex = 9;
            this.button3.Text = "Reflexão";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.reflexao);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 483);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 44);
            this.button2.TabIndex = 8;
            this.button2.Text = "Escala +";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.escala);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 431);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 44);
            this.button1.TabIndex = 7;
            this.button1.Text = "Rotação";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.rotacao);
            // 
            // btApagar
            // 
            this.btApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btApagar.Location = new System.Drawing.Point(116, 238);
            this.btApagar.Margin = new System.Windows.Forms.Padding(4);
            this.btApagar.Name = "btApagar";
            this.btApagar.Size = new System.Drawing.Size(100, 44);
            this.btApagar.TabIndex = 6;
            this.btApagar.Text = "Apagar";
            this.btApagar.UseVisualStyleBackColor = true;
            this.btApagar.Click += new System.EventHandler(this.btApagar_Click);
            // 
            // btCor
            // 
            this.btCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCor.Location = new System.Drawing.Point(119, 290);
            this.btCor.Margin = new System.Windows.Forms.Padding(4);
            this.btCor.Name = "btCor";
            this.btCor.Size = new System.Drawing.Size(97, 37);
            this.btCor.TabIndex = 5;
            this.btCor.Text = "Cor";
            this.btCor.UseVisualStyleBackColor = true;
            this.btCor.Click += new System.EventHandler(this.btCor_Click);
            // 
            // btDesenhar
            // 
            this.btDesenhar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDesenhar.Location = new System.Drawing.Point(8, 238);
            this.btDesenhar.Margin = new System.Windows.Forms.Padding(4);
            this.btDesenhar.Name = "btDesenhar";
            this.btDesenhar.Size = new System.Drawing.Size(97, 44);
            this.btDesenhar.TabIndex = 4;
            this.btDesenhar.Text = "DDA";
            this.btDesenhar.UseVisualStyleBackColor = true;
            this.btDesenhar.Click += new System.EventHandler(this.bt_DDA);
            // 
            // txtY1
            // 
            this.txtY1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtY1.Location = new System.Drawing.Point(4, 138);
            this.txtY1.Margin = new System.Windows.Forms.Padding(4);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(66, 37);
            this.txtY1.TabIndex = 3;
            this.txtY1.Text = "0";
            // 
            // txtX1
            // 
            this.txtX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX1.Location = new System.Drawing.Point(8, 62);
            this.txtX1.Margin = new System.Windows.Forms.Padding(4);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(62, 37);
            this.txtX1.TabIndex = 2;
            this.txtX1.Text = "0";
            // 
            // lbY1
            // 
            this.lbY1.AutoSize = true;
            this.lbY1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbY1.Location = new System.Drawing.Point(8, 103);
            this.lbY1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbY1.Name = "lbY1";
            this.lbY1.Size = new System.Drawing.Size(33, 31);
            this.lbY1.TabIndex = 1;
            this.lbY1.Text = "Y";
            // 
            // lbX1
            // 
            this.lbX1.AutoSize = true;
            this.lbX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbX1.Location = new System.Drawing.Point(8, 27);
            this.lbX1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbX1.Name = "lbX1";
            this.lbX1.Size = new System.Drawing.Size(33, 31);
            this.lbX1.TabIndex = 0;
            this.lbX1.Text = "X";
            // 
            // imagem
            // 
            this.imagem.BackColor = System.Drawing.Color.White;
            this.imagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagem.Location = new System.Drawing.Point(0, 0);
            this.imagem.Margin = new System.Windows.Forms.Padding(4);
            this.imagem.Name = "imagem";
            this.imagem.Size = new System.Drawing.Size(1083, 751);
            this.imagem.TabIndex = 1;
            this.imagem.TabStop = false;
            this.imagem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imagem_MouseClick);
            this.imagem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imagem_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 355);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 31);
            this.label2.TabIndex = 23;
            this.label2.Text = "Liang-Barsky";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(222, 396);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(280, 230);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(8, 669);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(149, 44);
            this.button7.TabIndex = 25;
            this.button7.Text = "Liang-Barsky";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.bt_LiangBarskyLineDraw);
            // 
            // tela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1588, 751);
            this.Controls.Add(this.imagem);
            this.Controls.Add(this.painel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "tela";
            this.Text = "TrabalhoPratico1 - Diogo Casal";
            this.painel.ResumeLayout(false);
            this.painel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painel;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.Label lbY1;
        private System.Windows.Forms.Label lbX1;
        private System.Windows.Forms.PictureBox imagem;
        private System.Windows.Forms.Button btApagar;
        private System.Windows.Forms.Button btCor;
        private System.Windows.Forms.Button btDesenhar;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.ColorDialog cdlg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.Label lbY2;
        private System.Windows.Forms.Label lbX2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button Bresenham;
        private System.Windows.Forms.Label DescTrans;
        private System.Windows.Forms.Label DescRast;
        private System.Windows.Forms.Label DescRecorte;
        private System.Windows.Forms.Button CohenSutherland;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

