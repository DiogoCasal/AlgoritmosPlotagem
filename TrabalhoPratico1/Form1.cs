﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TrabalhoPratico1
{
    public partial class tela : Form
    {

        Bitmap areaDesenho;
        Bitmap boxCohen;
        Bitmap boxLian;
        Bitmap assist;
        Color corPreenche;
        int x1, x2, y1, y2;
        bool inicio;
        List<int> retas;

        private Rectangle clipRectangle;
        public tela()
        {
            InitializeComponent();

            areaDesenho = new Bitmap(imagem.Size.Width,
            imagem.Size.Height);
            boxCohen = new Bitmap(pictureBox1.Size.Width,
            pictureBox1.Size.Height);
            boxLian = new Bitmap(pictureBox2.Size.Width,
            pictureBox2.Size.Height);
            assist = new Bitmap(imagem.Size.Width,
                imagem.Size.Height);
            corPreenche = Color.Black;


            x1 = x2 = y1 = y2 = 0;
            txtX1.Text = txtX2.Text = txtY1.Text = txtY2.Text = "0";
            retas = new List<int>();
            inicio = true;

            // Configura a área de recorte para o algoritmo (estes são apenas valores de exemplo)
            clipRectangle = new Rectangle(); // Você vai querer definir isso com base na lógica de sua aplicação
        }


        /// <summary>
        /// Legacy funtion to draw on canvas
        /// </summary>

        #region FuncoesPadrao
        private void btCor_Click(object sender, EventArgs e)
        {
            DialogResult result = cdlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                corPreenche = cdlg.Color;
            }
        }

        private void btApagar_Click(object sender, EventArgs e)
        {
            areaDesenho = new Bitmap(imagem.Size.Width,
            imagem.Size.Height);
            imagem.Image = areaDesenho;
            retas = new List<int>();
        }

        private void imagem_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int x = e.X;
                int y = e.Y;
                txtX1.Text = Convert.ToString(x);
                txtY1.Text = Convert.ToString(y);
                areaDesenho.SetPixel(x, y, corPreenche);
                imagem.Image = areaDesenho;
            }
        }

        private void imagem_MouseClick(object sender, MouseEventArgs e)
        {
            if (inicio)
            {
                x1 = e.X;
                y1 = e.Y;
                txtX1.Text = x1.ToString();
                txtY1.Text = y1.ToString();
                areaDesenho.SetPixel(x1, y1, Color.Red);
                imagem.Image = areaDesenho;
                inicio = false;
            }
            else
            {
                x2 = e.X;
                y2 = e.Y;
                txtX2.Text = x2.ToString();
                txtY2.Text = y2.ToString();
                areaDesenho.SetPixel(x2, y2, Color.Red);
                imagem.Image = areaDesenho;

                inicio = true;
            }
        }

        private void imagem_MouseRight(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                int x = e.X;
                int y = e.Y;
                txtX1.Text = Convert.ToString(x);
                txtY1.Text = Convert.ToString(y);
                areaDesenho.SetPixel(x, y, corPreenche);
                imagem.Image = areaDesenho;
            }
        }
        #endregion

        #region DDA
        private void bt_DDA(object sender, EventArgs e)
        {
            retas.Add(x1);
            retas.Add(y1);
            retas.Add(x2);
            retas.Add(y2);
            DDALineDraw(areaDesenho, imagem, x1, y1, x2, y2);
        }

        public void DDALineDraw(Bitmap bitmap, PictureBox picBox, int x1, int y1, int x2, int y2)
        {
            try
            {
                int deltaX, deltaY, passos, moduloDeltaX, moduloDeltaY;
                double x, y, xincrease, yincrease;

                //Aloca os pontos iniciais
                x = x1;
                y = y1;

                //Define o primeiro pixel
                bitmap.SetPixel((int)x, (int)y, corPreenche);
                picBox.Image = bitmap;

                // Cacula o delta
                deltaX = x2 - x1;
                deltaY = y2 - y1;

                //Ajuste para achar o módulo do delta
                if (deltaX < 0)
                    moduloDeltaX = deltaX * (-1);
                else
                    moduloDeltaX = deltaX;

                if (deltaY < 0)
                    moduloDeltaY = deltaY * (-1);
                else
                    moduloDeltaY = deltaY;

                //Pega a maior diferenca entre os Xs ou Ys e define como número de passos garantindo que serão preenchidos
                //todos os pontos entre os dois pontos
                if (moduloDeltaX > moduloDeltaY)
                    passos = moduloDeltaX;
                else
                    passos = moduloDeltaY;

                //Calculo os incrementos para realizar os avanços pelos eixos (Esses valores serão utilizados como constantes de aumento) 
                xincrease = calcularValorIncremento((double)deltaX, passos);
                yincrease = calcularValorIncremento((double)deltaY, passos);

                //realiza os incrementos posteriores repetitivamente
                for (int i = 1; i <= passos; i++)
                {
                    //Aumenta os valores do novo ponto baseado no valor de incremento calculado anterirormente
                    x += xincrease;
                    y += yincrease;
                    //Cria o ponto na tela
                    bitmap.SetPixel((int)x, (int)y, corPreenche);
                    picBox.Image = bitmap;
                }

            }
            catch (Exception ex)
            {
                //O plot continua a ocorrer mesmo violando o tamanho do canva
                Console.WriteLine("Saindo da tela, Erro:" + ex);
            }
        }
        #endregion

        #region transformacoes2d
        private void translacao(object sender, EventArgs e)
        {
            this.btApagar_Click(sender, e);

            int x1Translacao = x1 = x1 + 2;
            int y1Translacao = y1 = y1 + 2;
            int x2Translacao = x2 = x2 + 3;
            int y2Translacao = y2 = y2 + 3;

            DDALineDraw(areaDesenho, imagem, x1Translacao, y1Translacao, x2Translacao, y2Translacao);

        }
        private void escala(object sender, EventArgs e)
        {
            this.btApagar_Click(sender, e);

            var fatorEscala = 1.3;

            int xEscala1 = x1 = (int)(x1 * fatorEscala);
            int yEscala1 = y1 = (int)(y1 * fatorEscala);
            int xEscala2 = x2 = (int)(x2 * fatorEscala);
            int yEscala2 = y2 = (int)(y2 * fatorEscala);

            DDALineDraw(areaDesenho, imagem, xEscala1, yEscala1, xEscala2, yEscala2);
        }

        private void escalaDown(object sender, EventArgs e)
        {
            this.btApagar_Click(sender, e);

            var fatorEscala = 1.3;

            int xEscala1 = x1 = (int)(x1 / fatorEscala);
            int yEscala1 = y1 = (int)(y1 / fatorEscala);
            int xEscala2 = x2 = (int)(x2 / fatorEscala);
            int yEscala2 = y2 = (int)(y2 / fatorEscala);

            DDALineDraw(areaDesenho, imagem, xEscala1, yEscala1, xEscala2, yEscala2);
        }


        private void rotacao(object sender, EventArgs e)
        {
            this.btApagar_Click(sender, e);

            // Converte o ângulo para radianos (As funções do Math utilizam dessa forma)
            double ParaRadianos = 15 * (Math.PI / 180.0);

            //Pega um ponto Central para X e Y para fazer a rotação
            int PontoMedioX = (x1 + x2) / 2;
            int PontoMedioY = (y1 + y2) / 2;

            // rotaciona cada cordenada de acordo com o centro da rotação (PontoMedio X/Y)
            int xRotacionado1 = x1 = (int)((x1 - PontoMedioX) * Math.Cos(ParaRadianos) - (y1 - PontoMedioY) * Math.Sin(ParaRadianos) + PontoMedioX);
            int yRotacionado1 = y1 = (int)((x1 - PontoMedioX) * Math.Sin(ParaRadianos) + (y1 - PontoMedioY) * Math.Cos(ParaRadianos) + PontoMedioY);
            int xRotacionado2 = x2 = (int)((x2 - PontoMedioX) * Math.Cos(ParaRadianos) - (y2 - PontoMedioY) * Math.Sin(ParaRadianos) + PontoMedioX);
            int yRotacionado2 = y2 = (int)((x2 - PontoMedioX) * Math.Sin(ParaRadianos) + (y2 - PontoMedioY) * Math.Cos(ParaRadianos) + PontoMedioY);

            // Desenha a linha baseada nos novos pontos
            DDALineDraw(areaDesenho, imagem, xRotacionado1, yRotacionado1, xRotacionado2, yRotacionado2);

        }
        private void reflexao(object sender, EventArgs e)
        {
            //Reflexo horizontal
            this.btApagar_Click(sender, e);
            int xRefletido1 = x1 = -x1;
            int xRefletido2 = x2 = -x2;

            DDALineDraw(areaDesenho, imagem, xRefletido1, y1, xRefletido2, y2);
        }

        #endregion

        #region Bresenham
        private void bt_BresenhamLineDraw(object Sender, EventArgs e)
        {
            retas.Add(x1);
            retas.Add(y1);
            retas.Add(x2);
            retas.Add(y2);
            BresenhamLineDraw(x1, y1, x2, y2);
        }

        private void BresenhamLineDraw(int x1, int y1, int x2, int y2)
        {
            int deltaX = x2 - x1;
            int deltaY = y2 - y1;
            int x = x1, y = y1, xincremento, yincremento, c1, c2, p;

            if (deltaX > 0)
                xincremento = 1;
            else
            {
                xincremento = -1;
                deltaX = -deltaX;
            }


            if (deltaY > 0)
                yincremento = 1;
            else
            {
                yincremento = -1;
                deltaY = -deltaY;
            }

            areaDesenho.SetPixel(x, y, corPreenche);
            imagem.Image = areaDesenho;

            if (deltaX > deltaY) // 1 caso
            {
                p = 2 * deltaY - deltaX;
                c1 = 2 * deltaY;
                c2 = 2 * (deltaY - deltaX);

                for (int i = 0; i < deltaX; i++)
                {
                    x += xincremento;
                    if (p < 0)
                        p += c1;
                    else
                    {
                        p += c2;
                        y += yincremento;
                    }
                    areaDesenho.SetPixel(x, y, corPreenche);
                    imagem.Image = areaDesenho;
                }
            }
            else
            {
                p = 2 * deltaX - deltaY; c1 = 2 * deltaX; c2 = 2 * (deltaX - deltaY);
                for (int i = 0; i < deltaY; i++)
                {
                    y += yincremento;
                    if (p < 0)
                        p += c1;
                    else
                    {
                        p += c2;
                        x += xincremento;
                    }
                    areaDesenho.SetPixel(x, y, corPreenche);
                    imagem.Image = areaDesenho;
                }
            }


        }
        #endregion

        #region CirculoBresenham
        private void btCirculoBres(object Sender, EventArgs e)
        {
            int raio = (int)Math.Sqrt(((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)));
            FazerCirculo(x1, y1, raio);
        }

        private void FazerCirculo(int xc, int yc, int r)
        {

            void DrawCircle(int xt, int yt)
            {
                areaDesenho.SetPixel(xc + xt, yc + yt, corPreenche);
                areaDesenho.SetPixel(xc - xt, yc + yt, corPreenche);
                areaDesenho.SetPixel(xc + xt, yc - yt, corPreenche);
                areaDesenho.SetPixel(xc - xt, yc - yt, corPreenche);
                areaDesenho.SetPixel(xc + yt, yc + xt, corPreenche);
                areaDesenho.SetPixel(xc - yt, yc + xt, corPreenche);
                areaDesenho.SetPixel(xc + yt, yc - xt, corPreenche);
                areaDesenho.SetPixel(xc - yt, yc - xt, corPreenche);
            }

            int xo = 0, yo = r;
            int d = 3 - 2 * r;
            DrawCircle(xo, yo);

            while (yo >= xo)
            {
                xo++;

                if (d > 0)
                {
                    yo--;
                    d += 4 * (xo - yo) + 10;
                }
                else
                {
                    d += 4 * xo + 6;
                }
                DrawCircle(xo, yo);
            }
            imagem.Image = areaDesenho;
        }
        #endregion

        #region CohenSutherland
        private void btCohenSutherlandLineDraw(object sender, EventArgs e)
        {
            assist = new Bitmap(imagem.Size.Width,
            imagem.Size.Height);
            pictureBox1.Image = assist;

            // Calculo do retângulo de recorte
            int rectX = Math.Min(x1, x2);
            int rectY = Math.Min(y1, y2);
            int rectWidth = Math.Abs(x2 - x1);
            int rectHeight = Math.Abs(y2 - y1);

            rectWidth = Math.Max(1, rectWidth);
            rectHeight = Math.Max(1, rectHeight);

            // Cria um retângulo de recorte com base nos pontos aceitos
            clipRectangle = new Rectangle(rectX, rectY, rectWidth, rectHeight);

            // Cria um bitmap do tamanho da área de recorte
            Bitmap croppedImage = new Bitmap(clipRectangle.Width, clipRectangle.Height);

            CohenSutherlandLineClipAndDraw();

            pictureBox1.Image = RedimensionarBitmap(assist, boxCohen.Width, boxCohen.Height);

            
        }

        // Constantes para os códigos de região
        private const int INSIDE = 0; // 0000
        private const int LEFT = 1;   // 0001
        private const int RIGHT = 2;  // 0010
        private const int BOTTOM = 4; // 0100
        private const int TOP = 8;    // 1000

        // Calcula o código de região para um ponto (x, y)
        private int ComputeOutCode(int x, int y)
        {
            int code = INSIDE;

            if (x < clipRectangle.Left)           // à esquerda da área de recorte
                code = code + LEFT;
            else if (x > clipRectangle.Right)     // à direita da área de recorte
                code = code + RIGHT;
            else if (y > clipRectangle.Bottom)    // abaixo da área de recorte
                code = code + BOTTOM;
            if (y < clipRectangle.Top)            // acima da área de recorte
                code = code + TOP;

            return code;
        }

        private int bit(int cfora, int pos)
        {
            int num = 0;
            // Idenfiticar se o ponto fora está na esquerda
            if ((cfora == 1 && pos == 0) || (cfora == 5 && pos == 0) || (cfora == 9 && pos == 0))
            {
                num = 1;
            }
            // Idenfiticar se o ponto fora está na direita
            if ((cfora == 2 && pos == 1) || (cfora == 6 && pos == 1) || (cfora == 10 && pos == 1))
            {
                num = 1;
            }
            if ((cfora == 4 && pos == 2) || (cfora == 5 && pos == 2) || (cfora == 6 && pos == 2))
            {
                num = 1;
            }
            if ((cfora == 8 && pos == 3) || (cfora == 9 && pos == 3) || (cfora == 10 && pos == 3))
            {
                num = 1;
            }

            return num;
        }

        // Implementação do algoritmo Cohen-Sutherland
        public void CohenSutherlandLineClipAndDraw()
        {
            for (int a = 0; a < retas.Count; a += 4)
            {
                List<int> pontos = new List<int>();
                for (int j = a; j < a+4 && j < retas.Count; j++)
                {
                    pontos.Add(retas[j]);
                }
                int x1 = pontos[0], y1 = pontos[1], x2 = pontos[2], y2 = pontos[3];
                bool accept = false;
                bool done = false;

                while (!done)
                {
                    int c1 = ComputeOutCode(x1, y1);
                    int c2 = ComputeOutCode(x2, y2);
                    if (c1 == 0 && c2 == 0)
                    {
                        // Ambos os pontos estão dentro da área de recorte
                        accept = true;
                        done = true;
                    }
                    else if ((c1 & c2) != 0)
                    {
                        done = true;
                    }
                    else
                    {
                        // Calcular a interseção da linha com a área de recorte
                        int x, y;
                        int cfora = c1 != 0 ? c1 : c2;

                        // Encontra a interseção ponto; usa fórmulas y = y1 + slope * (x - x1), x = x1 + (1/slope) * (y - y1)
                        if (bit(cfora, 0) == 1)
                        {
                            y = y1 + (y2 - y1) * (clipRectangle.Left - x1) / (x2 - x1);
                            x = clipRectangle.Left;
                        }
                        else if (bit(cfora, 1) == 1)
                        {
                            y = y1 + (y2 - y1) * (clipRectangle.Right - x1) / (x2 - x1);
                            x = clipRectangle.Right;
                        }
                        else if (bit(cfora, 2) == 1)
                        {
                            x = x1 + (x2 - x1) * (clipRectangle.Bottom - y1) / (y2 - y1);
                            y = clipRectangle.Bottom;
                        }
                        else if (bit(cfora, 3) == 1)
                        {
                            x = x1 + (x2 - x1) * (clipRectangle.Top - y1) / (y2 - y1);
                            y = clipRectangle.Top;
                        }
                        else
                        {
                            x = y = 0;
                        }

                        // Substitui o ponto fora da área de recorte pelo ponto de interseção
                        if (cfora == c1)
                        {
                            x1 = x;
                            y1 = y;
                        }
                        else
                        {
                            x2 = x;
                            y2 = y;
                        }
                    }
                }
                if (accept)
                {
                    // Desenha a linha dentro do recorte
                    DDALineDraw(assist, pictureBox1,x1, y1, x2, y2);
                }
            }
        }
        #endregion

        #region LiangBarsky

        private void bt_LiangBarskyLineDraw(object sender, EventArgs e)
        {
            assist = new Bitmap(imagem.Size.Width,
            imagem.Size.Height);
            pictureBox2.Image = assist;

            // Calculo do retângulo de recorte
            int rectX = Math.Min(x1, x2);
            int rectY = Math.Min(y1, y2);
            int rectWidth = Math.Abs(x2 - x1);
            int rectHeight = Math.Abs(y2 - y1);

            rectWidth = Math.Max(1, rectWidth);
            rectHeight = Math.Max(1, rectHeight);

            // Cria um retângulo de recorte com base nos pontos aceitos
            clipRectangle = new Rectangle(rectX, rectY, rectWidth, rectHeight);

            // Cria um bitmap do tamanho da área de recorte
            Bitmap croppedImage = new Bitmap(clipRectangle.Width, clipRectangle.Height);

            LiangBarskyLineClipAndDraw();

            pictureBox2.Image = RedimensionarBitmap(assist, boxLian.Width, boxLian.Height);

        }

        
        private bool cliptest(float p, float q, float u1, float u2)
        {
            float r;
            bool result = true;

            if (p < 0.0)
            {
                r = q / p;
                if (r > u2)
                {
                    result = false;
                }
                else if (r > u1)
                {
                    u1 = r;
                }
            }
            else if (p > 0.0)
            {
                r = q / p;
                if (r < u1)
                {
                    result = false;
                }
                else if (r < u2)
                {
                    u2 = r;
                }
            }
            else if (q < 0.0)
            {
                result = false;
            }
            return result;
        }

        private float u1 = 0;
        private float u2 = 1;
        // Implementação do algoritmo Liang-Barsky
        public void LiangBarskyLineClipAndDraw()
        {
            for (int a = 0; a < retas.Count; a += 4)
            {
                List<int> pontos = new List<int>();
                for (int j = a; j < a + 4 && j < retas.Count; j++)
                {
                    pontos.Add(retas[j]);
                }
                float x1 = pontos[0], y1 = pontos[1], x2 = pontos[2], y2 = pontos[3];


                float dx = x2 - x1, dy = y2 - y1;
                u1 = 0;
                u2 = 1;
                if (cliptest(-dx, x1 - clipRectangle.Left, u1, u2)) // esq
                {
                    if (cliptest(dx, clipRectangle.Right - x1, u1, u2)) // dir
                    {
                        if (cliptest(-dy, y1 - clipRectangle.Top, u1, u2)) // inf
                        {
                            if (cliptest(dy, clipRectangle.Bottom - y1, u1, u2)) // sup
                            {
                                if (u2 < 1.0)
                                {
                                    x2 = x1 + u2 * dx;
                                    y2 = y1 + dy * u2;
                                }
                                if (u1 > 0)
                                {
                                    x1 += dx * u1;
                                    y1 += dy * u1;
                                }
                                // Desenha a linha dentro do recorte
                                DDALineDraw(assist, pictureBox2, (int)Math.Round(x1), (int)Math.Round(y1), (int)Math.Round(x2), (int)Math.Round(y2));
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region AuxMethods
        //Metodos auxiliares
        //Calcula e retorna o valor de incremento para o DDA
        private double calcularValorIncremento(double delta, int passos)
        {
            var retorno = (double)delta / passos;
            return retorno;
        }

        // Função para redimensionar um bitmap
        static Bitmap RedimensionarBitmap(Bitmap original, int largura, int altura)
        {
            Bitmap redimensionado = new Bitmap(largura, altura);
            using (Graphics g = Graphics.FromImage(redimensionado))
            {
                g.DrawImage(original, 0, 0, largura, altura);
            }
            return redimensionado;
        }
        #endregion
    }
}
