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

            //Para descobrirmos em qual índice está o nosso valor, utilizamos a método estático IndexOf da classe Array, passando por parâmetro em qual array devemos buscar o valor, e o valor a ser buscado
            Console.WriteLine();
            Console.WriteLine("Usando o IndexOf para buscar o índice da aulaModelando:");
            Console.WriteLine($"A aula modelando está no índice {Array.IndexOf(aulasImplicito, aulaModelando)}");

            //Se desejamos achar a última ocorrência do nosso valor no array, utilizamos o método LastIndexOf da classe Array, passando por parâmetro em qual array devemos buscar o valor, e o valor a ser buscado
            Console.WriteLine();
            Console.WriteLine("Usando o LastIndexOf para buscar a última ocorrência de aulaModelando no nosso array:");
            Console.WriteLine($"A aula modelando está no índice {Array.LastIndexOf(aulasImplicito, aulaModelando)}");

            //Se desejamos trocar a ordem do nosso Array, onde o último seria o primeiro, e assim sucessivamente, utilizamos o método Reverso da classe Array, passando por parâmetro qual array desejamos trocar a ordem
            Console.WriteLine();
            Console.WriteLine("Usando o Reverse para trocarmos a ordem dos índices do array:");
            Array.Reverse(aulasImplicito);
            ImprimirIndices(aulasImplicito);
            Console.WriteLine();
            Console.WriteLine("Usando o Reverse para voltar o array para a ordem natural:");
            Array.Reverse(aulasImplicito);
            ImprimirIndices(aulasImplicito);

            //Se desejamos redimensionar o tamanho do nosso array, por exemplo, se ele é de tamanho 3 e eu quero transformar em tamanho 2,
            //Utilizamos o método Resize da classe Array, passando por parâmetro o array que desejamos redimensionar (passamos esse array por referência), e o novo tamanho para esse array
            Console.WriteLine();
            Console.WriteLine("Usando o Resize reduzir o tamanho do array para 2 índices:");
            Array.Resize(ref aulasImplicito, 2);
            ImprimirIndices(aulasImplicito);

            //Se desejamos aumentar o tamanho do array, para 3 índices novamente, vamos usar o Resize de novo
            //Observe que a última posição foi preenchida com null, pois não passamos um valor para ela
            Console.WriteLine();
            Console.WriteLine("Usando o Resize voltar o array para o tamanho original:");
            Array.Resize(ref aulasImplicito, 3);
            ImprimirIndices(aulasImplicito);

            //Portanto, para preenchermos a última posição de um array na qual não sabemos o tamanho exato, utilizamos o índice [<nomeDoArray>.Length -1]
            //Pois ele irá sempre pegar o tamanho do array -1 que é o equivalente a última posição do array
            Console.WriteLine();
            Console.WriteLine("Usando o [aulasImplicito.Length -1] para atribuir o valor 'Conclusão' na última posição do array:");
            aulasImplicito[aulasImplicito.Length - 1] = "Conclusão";
            ImprimirIndices(aulasImplicito);

            //Se desejamos ordenar o nosso array por ordem alfabética, devemos utilizar o método estático Sort da classe Array
            Console.WriteLine();
            Console.WriteLine("Usando o método Sort para ordenar os nosso valores em ordem alfabética:");
            Array.Sort(aulasImplicito);
            ImprimirIndices(aulasImplicito);

            //Se desejamos copiar um array, utilizamos o método estático Copy da classe Array
            //passando por parâmetro o array original que desejamos copiar, a posição do array original que iniciaremos a cópia,
            //o array cópia, a posição inicial do array cópia, e o tamanho de índices que vão ser copiados
            Console.WriteLine();
            Console.WriteLine("Utilizando o método Copy para copiar as 2 últimas posições do array:");
            string[] copia = new string[2];
            Array.Copy(aulasImplicito, 1, copia, 0, 2);
            ImprimirIndices(copia);

            //Se desejamos clonar um array, utilizaremos o método Clone do nosso array, convertendo ele para um array de strings:
            Console.WriteLine();
            Console.WriteLine("Utilizando o método Clone para clonar o nosso array:");
            string[] clone = aulasImplicito.Clone() as string[];
            ImprimirIndices(clone);

            //Se desejamos limpar os 2 últimos elementos do nosso array, utilizamos o método estático Clear da classe Array, passando o nome do array,
            //a posição inicial da limpeza, e a quantidade de posições que desejamos limpar
            Array.Clear(clone, 1, 2);
            ImprimirIndices(clone);
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