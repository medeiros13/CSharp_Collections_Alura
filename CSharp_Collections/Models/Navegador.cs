namespace CSharp_Collections.Models
{
    internal class Navegador
    {
        //Inicializamos uma Pilha (Stack) da seguinte forma:
        private readonly Stack<string> historicoAnterior = new Stack<string>();
        private readonly Stack<string> historicoProximo = new Stack<string>();
        private string atual = "vazia";
        public Navegador()
        {
            Console.WriteLine($"Página atual: {atual}");
        }
        internal void NavegarPara(string url)
        {
            //Para adicionarmos em uma Stack, utilizamos o método Push();
            historicoAnterior.Push(atual);
            atual = url;
            Console.WriteLine($"Página atual: {atual}");
        }
        internal void Anterior()
        {
            //Para voltarmos para o elemento anterior na Stack, utilizamos o método Pop();
            //Porém, o método Pop() remove da pilha o elemento atual e vai para o anterior,
            //caso não tenha mair elemento anterior, o Pop irá lançar uma exceção
            //Portanto, vamo fazer uma verificação se existe elementos na Stack ainda, para isso,
            //Iremos utilizar o método Any():
            if (historicoAnterior.Any())
            {
                historicoProximo.Push(atual);
                atual = historicoAnterior.Pop();
                Console.WriteLine($"Página atual: {atual}");
            }
        }
        internal void Proximo()
        {
            if (historicoProximo.Any())
            {
                historicoAnterior.Push(atual);
                atual = historicoProximo.Pop();
                Console.WriteLine($"Página atual: {atual}");
            }
        }
    }
}