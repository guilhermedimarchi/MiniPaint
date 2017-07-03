using System;
using System.Collections;
using System.Text;
using System.Drawing;

namespace Paint
{
    public class Pintor
    {

        #region Implementar

        // Função que pinta a imagem
        public int Colorir(int x, int y, Color C1, Bitmap b)
        {
            /* Dicas: 
             *  - Pode-se colocar na fila x e y. ou pode-se colocar direto um ponto. Pode-se usar a classe Point para isso. Ex,: Point p = new Point(x,y)
             *  - Uma variável que armazena cor é do tipo Color. Ex.: Color cor_ponto
             *  - Para pegar uma cor de um ponto do Bitmap use: b.GetPixel(x,y)
             *  - Para gravar uma cor em um ponto do Bitmap use: b.SetPixel(x,y,cor)
             * - Uma cor é igual a outra se seus 3 canais (R, G e B) forem iguais
             * */
            int count = 0;
            Point P0 = new Point(x, y);
            Color C0 = b.GetPixel(P0.X, P0.Y);
            Fila F = new Fila((b.Width + b.Height) * 2);
            F.Insert(P0);


            while (!F.FilaVazia())
            {


                Point P = (Point)F.Remove();
                Point PN = new Point(P.X, P.Y - 1);

                if (PN.Y >= 0 && PN.Y < b.Height)
                {

                    Color CN = b.GetPixel(PN.X, PN.Y);
                    if ((CN.R == C0.R && CN.G == C0.G && CN.B == C0.B) && (CN.R != C1.R || CN.G != C1.G || CN.B != C1.B))
                    {
                        count++;
                        b.SetPixel(PN.X, PN.Y, C1);
                        F.Insert(PN);
                    }
                }


                Point PS = new Point(P.X, P.Y + 1);

                if (PS.Y >= 0 && PS.Y < b.Height)
                {

                    Color CS = b.GetPixel(PS.X, PS.Y);
                    if ((CS.R == C0.R && CS.G == C0.G && CS.B == C0.B) && (CS.R != C1.R || CS.G != C1.G || CS.B != C1.B))
                    {
                        count++;
                        b.SetPixel(PS.X, PS.Y, C1);
                        F.Insert(PS);
                    }
                }


                Point PO = new Point(P.X + 1, P.Y);

                if (PO.X >= 0 && PO.X < b.Width)
                {
                    Color CO = b.GetPixel(PO.X, PO.Y);
                    if ((CO.R == C0.R && CO.G == C0.G && CO.B == C0.B) && (CO.R != C1.R || CO.G != C1.G || CO.B != C1.B))
                    {
                        count++;
                        b.SetPixel(PO.X, PO.Y, C1);
                        F.Insert(PO);
                    }
                }


                Point PL = new Point(P.X - 1, P.Y);

                if (PL.X >= 0 && PL.X < b.Width)
                {
                    Color CL = b.GetPixel(PL.X, PL.Y);
                    if ((CL.R == C0.R && CL.G == C0.G && CL.B == C0.B) && (CL.R != C1.R || CL.G != C1.G || CL.B != C1.B))
                    {
                        count++;
                        b.SetPixel(PL.X, PL.Y, C1);
                        F.Insert(PL);
                    }
                }

            }

            return count;
        } 


        #endregion
        }
    
    }
