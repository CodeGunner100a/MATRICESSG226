     //ejercicio 1 repe si miercoles
        public void Ejercicio1(int fi, int ff, int ci, int cf)
        {
            int f1, c1, f2, c2, i, j, n;

            n = (ff - fi + 1) * (cf - ci + 1);

            
            for (i = 1; i < n; i++)
            {
                f1 = fi;
                c1 = ci;

                for (j = 1; j <= n - i; j++)
                {
                    f2 = f1;
                    c2 = c1;

                    SiguienteSenoidal(ref f2, ref c2, fi, ff, ci, cf);

                    if (x[f1, c1] > x[f2, c2])
                    {
                        intercambiar(f1, c1, f2, c2);
                    }

                    f1 = f2;
                    c1 = c2;
                }
            }
        }

        private void SiguienteSenoidal(ref int fila, ref int col,
            int fi, int ff, int ci, int cf)
        {
            if ((fila - fi) % 2 == 0)
            {
                if (col < cf)
                {
                    col++;
                }
                else
                {
                    fila++;
                }
            }
            else
            {
                if (col > ci)
                {
                    col--;
                }
                else
                {
                    fila++;
                }
            }
        }

        private void intercambiar(int f1, int c1, int f2, int c2)
        {
            int aux;

            aux = x[f1, c1];
            x[f1, c1] = x[f2, c2];
            x[f2, c2] = aux;
        }
