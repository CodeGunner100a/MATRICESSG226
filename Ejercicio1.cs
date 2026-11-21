// Ejercicio 1 sg repechaje
  
   //PREGUNTA 1

      
        public void Ejercicio1()
        {
            int c1, c2, f1, aux;

            
            for (c1 = 1; c1 <= c; c1++)
            {
                x[f + 1, c1] = MayorFrecuencia(c1);
            }

            f++;

            
            for (c1 = 1; c1 < c; c1++)
            {
                for (c2 = c1 + 1; c2 <= c; c2++)
                {
                    if (x[f, c1] > x[f, c2])
                    {
                        for (f1 = 1; f1 <= f; f1++)
                        {
                            aux = x[f1, c1];
                            x[f1, c1] = x[f1, c2];
                            x[f1, c2] = aux;
                        }
                    }
                }
            }
        }

        
        private int MayorFrecuencia(int col)
        {
            int f1, f2, cont, mayor, elem;

            mayor = 0;
            elem = x[1, col];

            for (f1 = 1; f1 <= f; f1++)
            {
                cont = 0;

                for (f2 = 1; f2 <= f; f2++)
                {
                    if (x[f1, col] == x[f2, col])
                    {
                        cont++;
                    }
                }

                if (cont > mayor)
                {
                    mayor = cont;
                    elem = x[f1, col];
                }
            }

            return elem;
        }










