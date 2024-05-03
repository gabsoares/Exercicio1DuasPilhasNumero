namespace Exercicio1DuasPilhasNumero
{
    internal class Numero
    {
        int valorNumero;
        Numero? anterior;

        public Numero(int n)
        {
            this.valorNumero = n;
            this.anterior = null;
        }

        public void setNumero(int valorNumero)
        {
            this.valorNumero = valorNumero;
        }

        public int getValorNumero()
        {
            return this.valorNumero;
        }

        public void setAnterior(Numero anterior)
        {
            this.anterior = anterior;
        }

        public Numero getAnterior()
        {
            return this.anterior;
        }

        public override string? ToString()
        {
            return "Número: "+valorNumero;
        }
    }
}
