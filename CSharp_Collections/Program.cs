namespace CSharp_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Introdução às Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";

            //Existem duas formas de se declarar um array:
            //1) de maneira explícita, quando já sabemos todos os valores iniciais que esse array deve conter
            //declaramos o array da forma abaixo, passando dentro das chaves "{}" os valores de cada índice do array separados por vírgulas
            string[] aulasExplicito = new string[]
            {
                aulaIntro,
                aulaModelando,
                aulaSets
            };

            //2) de maneira implícita, quando não sabemos quais valores iniciais o array vai conter, mas sabemos o tamanho de índices que esse array deve conter
            //declaramos o array passando o número de índices que ele irá conter dentro dos colchetes "[]"
            //e depois para adicionarmos os valores, precisamos específicar qual índice irá receber esse valor
            string[] aulasImplicito = new string[3];
            aulasImplicito[0] = aulaIntro;
            aulasImplicito[1] = aulaModelando;
            aulasImplicito[2] = aulaSets;

            //Se colocarmos para imprimir o array, ele irá mostrar o tipo de array, e não os valores de seus índices:
            Console.WriteLine(aulasExplicito);
            Console.WriteLine(aulasImplicito);

            Console.WriteLine();
            Console.WriteLine("Aulas Explícito:");
            ImprimirIndices(aulasExplicito);
            Console.WriteLine();
            Console.WriteLine("Aulas Implícito:");
            ImprimirIndices(aulasImplicito);
            Console.WriteLine();
            Console.WriteLine("Imprimindo o primeiro elemento do array:");
            Console.WriteLine(aulasImplicito[0]);
            Console.WriteLine("Imprimindo o último elemento do array:");
            Console.WriteLine(aulasImplicito[aulasImplicito.Length - 1]);

            //Se tentarmos alterar o valor de alguma variável que foi atribuída para algum índice do array,
            //o valor do índice não será alterado:
            aulaIntro = "Trabalhando com Arrays";
            Console.WriteLine();
            Console.WriteLine("Tentando alterar o valor da variável aulaIntro:");
            ImprimirIndices(aulasImplicito);
            //isso acontece porquê o array não armazena a variável, e sim copia o valor desta variável, portanto, o índice do array, e a variável, são coisas diferentes
            //Para alterarmos o valor de algum índice do array precisamos atribuir esse valor diretamente para o índice:
            Console.WriteLine();
            Console.WriteLine("Tentando alterar o valor do índice 0 do array aulasImplicito:");
            aulasImplicito[0] = "Trabalhando com Arrays";
            ImprimirIndices(aulasImplicito);
        }

        private static void ImprimirIndices(string[] aulas)
        {
            //Se queremos imprimir os valores de cada índice do array, precisamos percorrer ele e printar cada índice:
            //Podemos percorrer o array com forEach:
            Console.WriteLine();
            Console.WriteLine("Foreach:");
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
            //Ou com For:
            Console.WriteLine("For:");
            for (int i = 0; i < aulas.Length; i++)
            {
                Console.WriteLine(aulas[i]);
            }
        }
    }
}