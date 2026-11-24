 // PREGUNTA 1 repecheje sb

        public void Ejercicio1(int fi, int ff, int ci, int cf)
        {
            bool ban = true;int f1, f2, inicioF2;
            for (int c1 = ci; c1 <= cf; c1++)
            {
                if (ban == false)
                {
                    for (f1 = fi; f1 <= ff; f1++)
                    {
                        for (int c2 = c1; c2 <= cf; c2++)
                        {
                            if (c2 == c1)
                                inicioF2 = f1;
                            else
                                inicioF2 = fi;

                            for (f2 = inicioF2; f2 <= ff; f2++)
                            {
                                if (x[f1, c1] > x[f2, c2])
                                    Intercambiar(f1, c1, f2, c2);
                            }
                        }
                    }
                }
                else
                {
                    for (f1 = ff; f1 >= fi; f1--)
                    {
                        for (int c2 = c1; c2 <= cf; c2++)
                        {
                            if (c2 == c1)
                                inicioF2 = f1;
                            else
                                inicioF2 = ff;

                            for (f2 = inicioF2; f2 >= fi; f2--)
                            {
                                if (x[f1, c1] > x[f2, c2])
                                    Intercambiar(f1, c1, f2, c2);
                            }
                        }
                    }
                }
                ban = !ban;
            }
        }

        public void Intercambiar(int f1, int c1, int f2, int c2)
        {
            int aux = x[f1, c1];
            x[f1, c1] = x[f2, c2];
            x[f2, c2] = aux;
        }







