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
        public void Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Não pode remover nada de uma pilha vazia");
            }
            else
            {
                topo = topo.getAnterior();

            }
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
                Console.WriteLine("Fim da impressão");
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

        public void VerificarMaiorEMenor()
        {
            Numero aux = topo;
            int maior = aux.getValorNumero();

            if (!IsEmpty())
            {
                do
                {

                } while (aux != null);
            }

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
        public bool IsEmpty()
        {
            return this.topo == null;
        }
    }
}
