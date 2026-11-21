//Ejercicio 2 
   //PREGUNTA 2 
        public void Ejercicio2()
        {
            int f1, c1, f2, c2, i, j, n, aux;

            n = c * (c - 1) / 2;

            for (i = 1; i < n; i++)
            {
                f1 = 1;
                c1 = 2;

                for (j = 1; j <= n - i; j++)
                {
                    f2 = f1;
                    c2 = c1;

                    Siguiente(ref f2, ref c2);

                    if (Frecuencia(x[f1, c1]) < Frecuencia(x[f2, c2]))
                    {
                        aux = x[f1, c1];
                        x[f1, c1] = x[f2, c2];
                        x[f2, c2] = aux;
                    }

                    f1 = f2;
                    c1 = c2;
                }
            }
        }


        private int Frecuencia(int elem)
        {
            int f1, c1, cont;

            cont = 0;

            for (c1 = 2; c1 <= c; c1++)
            {
                for (f1 = 1; f1 < c1; f1++)
                {
                    if (x[f1, c1] == elem)
                    {
                        cont++;
                    }
                }
            }

            return cont;
        }

        
        private void Siguiente(ref int fila, ref int col)
        {
            if (fila > 1)
            {
                fila--;
            }
            else
            {
                col++;
                fila = col - 1;
            }
        }
