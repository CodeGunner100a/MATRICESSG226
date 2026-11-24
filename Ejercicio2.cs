  public void Ejercicio2()
        {
            int p, q, f1, c1, f2, c2;
            int frec1, frec2, aux;
            bool ban;

            for (p = 1; p <= 10; p++)
            {
                PosTriangular(p, out f1, out c1);

                for (q = p + 1; q <= 10; q++)
                {
                    PosTriangular(q, out f2, out c2);

                    frec1 = FrecTriangular(x[f1, c1]);
                    frec2 = FrecTriangular(x[f2, c2]);

                    ban = false;

                    if (frec1 < frec2)
                        ban = true;

                    if (frec1 == frec2 && x[f1, c1] > x[f2, c2])
                        ban = true;

                    if (ban)
                    {
                        aux = x[f1, c1];
                        x[f1, c1] = x[f2, c2];
                        x[f2, c2] = aux;
                    }
                }
            }
        }

        public void PosTriangular(int pos, out int fi, out int co)
        {
            int k;

            k = 0;
            fi = 0;
            co = 0;

            for (int j = 1; j < c; j++)
            {
                for (int i = f - j; i >= 1; i--)
                {
                    k++;

                    if (k == pos)
                    {
                        fi = i;
                        co = j;
                    }
                }
            }
        }

        public int FrecTriangular(int ele)
        {
            int cont = 0;

            for (int j = 1; j < c; j++)
            {
                for (int i = 1; i <= f - j; i++)
                {
                    if (x[i, j] == ele)
                        cont++;
                }
            }

            return cont;
        }
