// Ejercicio 1 si
   public void Ejercicio1()
        {
            int f1, f2, c1, aux;
            for (f1 = 1; f1 <= f; f1++)
            {
                x[f1, c + 1] = MayorFrecuencia(f1);
            }
            c++;  
            for (f1 = 1; f1 < f; f1++)
            {
                for (f2 = f1 + 1; f2 <= f; f2++)
                {
                    if (x[f1, c] > x[f2, c])
                    {
                        for (c1 = 1; c1 <= c; c1++)
                        {
                            aux = x[f1, c1];
                            x[f1, c1] = x[f2, c1];
                            x[f2, c1] = aux;
                        }
                    }
                }
            }
        }

        private int MayorFrecuencia(int fila)
        {
            int c1, c2, cont, mayor, elem; mayor = 0; elem = x[fila, 1];
            for (c1 = 1; c1 <= c; c1++)
            {
                cont = 0;
                for (c2 = 1; c2 <= c; c2++)
                {
                    if (x[fila, c1] == x[fila, c2])
                    {
                        cont++;
                    }
                }
                if (cont > mayor)
                {
                    mayor = cont;
                    elem = x[fila, c1];
                }
            }
            return elem;
        }

       
