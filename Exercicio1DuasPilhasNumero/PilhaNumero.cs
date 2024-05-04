namespace Exercicio1DuasPilhasNumero
{
    internal class PilhaNumero
    {
        Numero? topo;

        public PilhaNumero()
        {
            this.topo = null;
        }

        public void Push(Numero aux)
        {
            if (IsEmpty())
            {
                this.topo = aux;
            }
            else
            {
                aux.setAnterior(topo);
                topo = aux;
            }
        }
        public Numero Pop()
        {
            if (!IsEmpty())
            {
                return topo;
            }
            return null;
        }

        public void RunOver()
        {
            Numero aux = topo;
            if (!IsEmpty())
            {
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.getAnterior();
                } while (aux != null);
            }
        }

        public void GetImpares()
        {
            Numero aux = topo;
            int quantidade = 0, valoresImpares;
            if (!IsEmpty())
            {
                Console.Write("Os valores ímpares são: ");
                do
                {
                    if (aux != null)
                    {
                        if (aux.getValorNumero() % 2 != 0 && topo != null)
                        {
                            valoresImpares = aux.getValorNumero();
                            quantidade++;
                            Console.Write(valoresImpares + " ");
                        }
                        aux = aux.getAnterior();
                    }
                } while (aux != null);
            }
        }

        public void GetPares()
        {
            Numero aux = topo;
            int quantidade = 0, valoresPares = 0;
            if (!IsEmpty())
            {
                Console.Write("Os valores pares são: ");
                do
                {
                    if (aux != null)
                    {
                        if (aux.getValorNumero() % 2 == 0)
                        {
                            quantidade++;
                            valoresPares = aux.getValorNumero();
                            Console.Write(valoresPares + " ");
                        }
                    }
                    aux = aux.getAnterior();
                } while (aux != null);
            }
        }
        public int VerificarTamanho()
        {
            Numero aux = topo;
            int tamanho = 0;
            if (!IsEmpty())
            {
                while (aux != null)
                {
                    aux = aux.getAnterior();
                    tamanho++;
                }
                return tamanho;
            }
            return 0;
        }

        public int VerificarMenor()
        {
            Numero aux = topo;
            int tamanho = 0;
            if (!IsEmpty())
            {
                while (aux != null)
                {
                    aux = aux.getAnterior();
                    tamanho++;
                }
                return tamanho;
            }
            return 0;
        }

        public int VerificarMaiorElementoPilha()
        {
            Numero aux = topo;
            int valor = 0, valorAux = 0;
            if (!IsEmpty())
            {
                valor = valorAux = aux.getValorNumero();
                do
                {
                    aux = aux.getAnterior();
                    if (aux != null)
                    {
                        valor = aux.getValorNumero();
                    }

                    if (valor > valorAux)
                    {
                        valorAux = valor;
                    }
                } while (aux != null);
                return valorAux;
            }
            return 0;
        }

        public int VerificarMenorElementoPilha()
        {
            Numero aux = topo;
            int valor = 0, valorAux = 0;
            if (!IsEmpty())
            {
                valor = valorAux = aux.getValorNumero();
                do
                {
                    aux = aux.getAnterior();
                    if (aux != null)
                    {
                        valor = aux.getValorNumero();
                    }

                    if (valor < valorAux)
                    {
                        valorAux = valor;
                    }
                } while (aux != null);
                return valorAux;
            }
            return 0;
        }


        public bool IsEmpty()
        {
            return this.topo == null;
        }
    }
}