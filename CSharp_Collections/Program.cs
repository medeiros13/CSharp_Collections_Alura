using CSharp_Collections.Models;

namespace CSharp_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Introdução às Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";

            ExemploArrays();
            ExemploList();
            ExemploListDeObjetos();
            ExemploListReadOnly();
            ExemploSets();
        }
        private static void ExemploArrays()
        {
            Console.WriteLine();
            Console.WriteLine("Início do exemplo com Arrays: ");
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
            ImprimirIndicesArray(aulasExplicito);
            Console.WriteLine();
            Console.WriteLine("Aulas Implícito:");
            ImprimirIndicesArray(aulasImplicito);
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
            ImprimirIndicesArray(aulasImplicito);
            //isso acontece porquê o array não armazena a variável, e sim copia o valor desta variável, portanto, o índice do array, e a variável, são coisas diferentes
            //Para alterarmos o valor de algum índice do array precisamos atribuir esse valor diretamente para o índice:
            Console.WriteLine();
            Console.WriteLine("Tentando alterar o valor do índice 0 do array aulasImplicito:");
            aulasImplicito[0] = "Trabalhando com Arrays";
            ImprimirIndicesArray(aulasImplicito);

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
            ImprimirIndicesArray(aulasImplicito);
            Console.WriteLine();
            Console.WriteLine("Usando o Reverse para voltar o array para a ordem natural:");
            Array.Reverse(aulasImplicito);
            ImprimirIndicesArray(aulasImplicito);

            //Se desejamos redimensionar o tamanho do nosso array, por exemplo, se ele é de tamanho 3 e eu quero transformar em tamanho 2,
            //Utilizamos o método Resize da classe Array, passando por parâmetro o array que desejamos redimensionar (passamos esse array por referência), e o novo tamanho para esse array
            Console.WriteLine();
            Console.WriteLine("Usando o Resize reduzir o tamanho do array para 2 índices:");
            Array.Resize(ref aulasImplicito, 2);
            ImprimirIndicesArray(aulasImplicito);

            //Se desejamos aumentar o tamanho do array, para 3 índices novamente, vamos usar o Resize de novo
            //Observe que a última posição foi preenchida com null, pois não passamos um valor para ela
            Console.WriteLine();
            Console.WriteLine("Usando o Resize voltar o array para o tamanho original:");
            Array.Resize(ref aulasImplicito, 3);
            ImprimirIndicesArray(aulasImplicito);

            //Portanto, para preenchermos a última posição de um array na qual não sabemos o tamanho exato, utilizamos o índice [<nomeDoArray>.Length -1]
            //Pois ele irá sempre pegar o tamanho do array -1 que é o equivalente a última posição do array
            Console.WriteLine();
            Console.WriteLine("Usando o [aulasImplicito.Length -1] para atribuir o valor 'Conclusão' na última posição do array:");
            aulasImplicito[aulasImplicito.Length - 1] = "Conclusão";
            ImprimirIndicesArray(aulasImplicito);

            //Se desejamos ordenar o nosso array por ordem alfabética, devemos utilizar o método estático Sort da classe Array
            Console.WriteLine();
            Console.WriteLine("Usando o método Sort para ordenar os nosso valores em ordem alfabética:");
            Array.Sort(aulasImplicito);
            ImprimirIndicesArray(aulasImplicito);

            //Se desejamos copiar um array, utilizamos o método estático Copy da classe Array
            //passando por parâmetro o array original que desejamos copiar, a posição do array original que iniciaremos a cópia,
            //o array cópia, a posição inicial do array cópia, e o tamanho de índices que vão ser copiados
            Console.WriteLine();
            Console.WriteLine("Utilizando o método Copy para copiar as 2 últimas posições do array:");
            string[] copia = new string[2];
            Array.Copy(aulasImplicito, 1, copia, 0, 2);
            ImprimirIndicesArray(copia);

            //Se desejamos clonar um array, utilizaremos o método Clone do nosso array, convertendo ele para um array de strings:
            Console.WriteLine();
            Console.WriteLine("Utilizando o método Clone para clonar o nosso array:");
            string[] clone = aulasImplicito.Clone() as string[];
            ImprimirIndicesArray(clone);

            //Se desejamos limpar os 2 últimos elementos do nosso array, utilizamos o método estático Clear da classe Array, passando o nome do array,
            //a posição inicial da limpeza, e a quantidade de posições que desejamos limpar
            Array.Clear(clone, 1, 2);
            ImprimirIndicesArray(clone);
        }
        private static void ExemploList()
        {
            Console.WriteLine();
            Console.WriteLine("Início do exemplo com List:");

            string aulaIntro = "Introdução às Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";

            //Existem 2 formas de declarar uma List:
            //1) de maneira explícita, quando sabemos quais serão os valores iniciais da nossa lista, dessa forma,
            //declaramos ela passando os valores iniciais dentro das chaves "{}"
            List<string> aulasExplicito = new List<string>()
            {
                aulaIntro,
                aulaModelando,
                aulaSets
            };

            //2) de maneira implícita, quando não sabemos quais serão os valores iniciais da nossa lista, dessa forma,
            //declaramos ela apenas com o "new List<tipo>();"
            List<string> aulasImplicito = new List<string>();

            //Se tentarmos dar um Console.WriteLine passando apenas o nome da List, o que será printado na tela, será o tipo da List
            Console.WriteLine("Tentando dar um Console.WriteLine passando o nome das listas como parâmetro:");
            Console.WriteLine(aulasExplicito);
            Console.WriteLine(aulasImplicito);

            //Se desejamos mostrar todos os elementos da List na tela, devemos percorrer ela:
            ImprimirElementosList(aulasExplicito);

            //Para adicionarmos elementos na nossa List, utilizamos o método Add:
            aulasImplicito.Add(aulaIntro);
            aulasImplicito.Add(aulaModelando);
            aulasImplicito.Add(aulaSets);

            //Para buscarmos o elemento de uma posição específica de uma list, podemos utilizar a mesma lógica do Array:
            Console.WriteLine($"A primeira aula é: {aulasExplicito[0]}");
            Console.WriteLine($"A última aula é: {aulasExplicito[aulasExplicito.Count - 1]}");

            //Também podemos acessar utilizando os métodos First (para o primeiro elemento), e o método Last (para o último elemento)
            Console.WriteLine($"A primeira aula é: {aulasExplicito.First()}");
            Console.WriteLine($"A última aula é: {aulasExplicito.Last()}");

            //Podemos alterar o valor de um elemento de uma posição em específico, podemos utilizar a mesma lógica do Array:
            aulasExplicito[0] = "Trabalhando com listas";
            Console.WriteLine("Aulas após alterar a primeira posição:");
            ImprimirElementosList(aulasExplicito);

            //Se desejamos buscar o primeiro elemento cujo seu valor contenha a palavra "Trabalhando",
            //utilizamos o método First, passando uma expressão Lambda como parâmetro
            Console.WriteLine($"A primeira aula 'Trabalhando' é: {aulasExplicito.First(aula => aula.Contains("Trabalhando"))}");
            //Para pegarmos o último, trocamos o First, pelo Last
            Console.WriteLine($"A última aula 'Trabalhando' é: {aulasExplicito.Last(aula => aula.Contains("Trabalhando"))}");
            //Se desejamos buscar um elemento, na qual não sabemos se o valor existe na List, podemos utilizar os métodos <nome>OrDefault,
            //Como o FirstOrDefault, para buscar o primeiro, caso ele não encontre o valor, ele irá retornar o valor default para aquele tipo,
            //no caso das strings, o valor defaul é null
            Console.WriteLine($"A primeira aula 'Conclusão' é: {aulasExplicito.FirstOrDefault(aula => aula.Contains("Conclusão"))}");

            //Se desejamos revertar a ordem da nossa List (o primeiro vai ser o último, o último vai ser o primeiro, e assim por diante),
            //utilizamos o método Reverse
            aulasExplicito.Reverse();
            Console.WriteLine("Depois de usar o Reverse:");
            ImprimirElementosList(aulasExplicito);
            //Podemos utilizar o Reverse novamente para voltar a ordem original:
            aulasExplicito.Reverse();
            Console.WriteLine("Usando o Reverse novamente para voltar a ordem anterior:");
            ImprimirElementosList(aulasExplicito);

            //Se desejamos remover o último elemento, utilizamos o método Remove:
            aulasExplicito.RemoveAt(aulasExplicito.Count - 1);
            Console.WriteLine("Usando o RemoveAt para remover o último elemento da List:");
            ImprimirElementosList(aulasExplicito);

            //Adicionando um novo elemento
            aulasExplicito.Add("Conclusão");
            Console.WriteLine("Usando o Add para adicionar a aula 'Conclusão'");
            ImprimirElementosList(aulasExplicito);

            //Se desejamos ordenar nossos elementos em ordem alfabética, utilizamos o método Sort
            aulasExplicito.Sort();
            Console.WriteLine("Depois de utilizar o método Sort para colocar em ordem alfabética:");
            ImprimirElementosList(aulasExplicito);

            //Se desejamos copiar certos elementos de uma List, utilizaremos o método GetRange,
            //passando por parâmetro a partir qual posição desejamos iniciar a cópia, e depois quantas posições queremos copiar
            List<string> copia = aulasExplicito.GetRange(aulasExplicito.Count - 2, 2);
            Console.WriteLine("Depois de utilziar o GetRange para pegar as duas últimas posições, e atribuir para a copia:");
            ImprimirElementosList(copia);

            //Se desejamos clonar a nossa List, podemos utilizar o construtor que recebe por parâmetro uma List:
            List<string> clone = new List<string>(aulasExplicito);
            Console.WriteLine("Depois de utilizar o construtor passando uma List por parâmetro para criar um clone:");
            ImprimirElementosList(clone);

            //Se desejamos remover os 2 últimos elementos de nossa List, podemos utilizar o RemoveRange,
            //passando por parâmetro a posição inicial da remoção, e quantos elementos desejamos remover
            clone.RemoveRange(clone.Count - 2, 2);
            Console.WriteLine("Depois de utilizar o RemoveRange para remover os dois últimos elementos da nossa List:");
            ImprimirElementosList(clone);
        }
        private static void ExemploListDeObjetos()
        {
            Console.WriteLine();
            Console.WriteLine("Início do exemplo com List de Objetos: ");
            var aulaIntro = new Aula("Introdução às Coleções", 20);
            var aulaModelando = new Aula("Modelando a Classe Aula", 18);
            var aulaSets = new Aula("Trabalhando com Conjuntos", 16);

            List<Aula> aulas = new List<Aula>()
            {
                aulaIntro,
                aulaModelando,
                aulaSets
            };
            ImprimirElementosListDeObjetos(aulas);

            //Iremos utilizar o método Sort para ordenar a nossa List de Aulas
            //Se tentarmos dar um Sort em algum tipo que não implementa a interface IComparable, o sistema irá lançar uma exceção,
            //Portanto, precisamos implementar essa interface em nossa classe Aula
            aulas.Sort();
            ImprimirElementosListDeObjetos(aulas);

            //Podemos também sobrescrever o CompareTo definido na classe Aula, para alterarmos a forma como nossa List será ordenada,
            //Para isso, iremos passar uma expressão Lambda por parâmetro para o método Sort
            //neste caso, estamos comparando a propriedade Tempo, a List será ordenada por essa propriedade
            aulas.Sort((este, outro) => este.Tempo.CompareTo(outro.Tempo));
            Console.WriteLine("Depois de utilizar o Sort passando uma comparação por parâmetro para ordenar por tempo:");
            ImprimirElementosListDeObjetos(aulas);
        }
        private static void ExemploListReadOnly()
        {
            Console.WriteLine();
            Console.WriteLine("Início do ExemploListReadOnly:");
            var csharpColecoes = new Curso("C# Collections", "Marcelo Oliveira");
            csharpColecoes.AdicionaAula(new Aula("Trabalhando com Listas", 21));
            Console.WriteLine();
            Console.WriteLine("Depois de adicionar uma aula:");
            ImprimirElementosListReadOnly(csharpColecoes.Aulas);
            //Adicionaremos 2 aulas
            csharpColecoes.AdicionaAula(new Aula("Criando uma Aula", 20));
            csharpColecoes.AdicionaAula(new Aula("Modelando com Coleções", 19));
            //Imprimir
            Console.WriteLine();
            Console.WriteLine("Depois de adicionar 2 aulas:");
            ImprimirElementosListReadOnly(csharpColecoes.Aulas);

            //Copiar a lista para outra lista
            var aulasCopiadas = new List<Aula>(csharpColecoes.Aulas);

            //Ordenar a cópia
            aulasCopiadas.Sort();

            //Imprimir
            Console.WriteLine();
            Console.WriteLine("Depois de copiar as Aulas e ordenar a cópia:");
            ImprimirElementosListReadOnly(aulasCopiadas);

            //Totalizar o tempo do curso
            Console.WriteLine();
            Console.WriteLine("Depois de calcular o tempo total do curso:");
            Console.WriteLine(csharpColecoes.TempoTotal);

            //Imprimir os detalhes do curso
            Console.WriteLine();
            Console.WriteLine("Imprimindo os detalhes do curso:");
            Console.WriteLine(csharpColecoes);
        }

        private static void ExemploSets()
        {
            Console.WriteLine();
            Console.WriteLine("Início ExemploSets");
            //SETS = CONJUNTOS
            //Duas propriedades do Set:
            //1) Não permite duplicidade
            //2) Os elementos não são mantidos em uma ordem específica

            //declarando set de alunos
            ISet<string> alunos = new HashSet<string>();

            //adicionando: vanessa, ana e rafael:
            alunos.Add("Vanessa");
            alunos.Add("Ana");
            alunos.Add("Rafael");

            //Imprimindo
            Console.WriteLine("Imprimindo os elementos do Set de Alunos separados por vírgula utilizando o string.Join:");
            Console.WriteLine(string.Join(", ", alunos));

            //Adicionando: Priscila, Rollo e Fábio
            alunos.Add("Priscilla");
            alunos.Add("Rollo");
            alunos.Add("Fábio");
            Console.WriteLine("Depois de adicionar mais 3 alunos:");
            Console.WriteLine(string.Join(", ", alunos));
            //Qual a diferença de um Set para uma List?
            //O conjunto não garante qual posição o elemento adicionado vai ocupar
            //Por exemplo, se você remover um aluno, e adicionar outro, nas Lists, o aluno adicionado ficaria na última posição
            //Mas nos Sets, esse aluno irá ocupar a posição do aluno que foi removido anteriormente, como no exemplo abaixo:
            //Removendo Ana e adicionando Marcelo
            alunos.Remove("Ana");
            alunos.Add("Marcelo");

            //Imprimindo de novo
            Console.WriteLine("Depois de remover a Ana e adicionar o Marcelo:");
            Console.WriteLine(string.Join(", ", alunos));

            //Adicionar um aluno que já existe
            alunos.Add("Fábio");
            Console.WriteLine("Depois de adicionar o Fábio uma segunda vez:");
            Console.WriteLine(string.Join(", ", alunos));

            //Qual a vantagem de utilizar o Set e não uma Lista?
            //O Set é mais rápido que uma lista quando queremos buscar elementos dentro deles,
            //Na List, quanto mais elementos existirem dentro dela, maior será o tempo de busca,
            //Enquanto que nos conjuntos, esse tempo não varia tanto
            //desempenho Set x List: o Set possui uma grande escalabilidade, enquanto que a List consome menos memória que o Set

            //Quando precisamos ordenar os elementos do Set, temos que copiar os elementos dele para uma List, pois ele não possui o método Sort
            var alunosEmLista = new List<string>(alunos);
            alunosEmLista.Sort();
            Console.WriteLine("Depois de copiar os valores do Set para uma List, e ordenar a List em Ordem Alfabética:");
            Console.WriteLine(string.Join(", ", alunosEmLista));
        }
        private static void ImprimirElementosListDeObjetos(List<Aula> aulas)
        {
            //Se tentarmos imprimir a nossa List de objetos da forma como era feito com List de string, o console vai mostrar o tipo de Objeto
            //Isso acontece porquê o Console.WriteLine chama o método ToString da classe, e como o ToString default é para mostrar o tipo de Objeto,
            //Precisamos sobrescrever o ToString dentro da classe Aula
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }
        private static void ImprimirIndicesArray(string[] aulas)
        {
            //Se queremos imprimir os valores de cada índice do array, precisamos percorrer ele e printar cada índice:
            //Podemos percorrer o array com forEach:
            Console.WriteLine();
            Console.WriteLine("Início ImprimirIndicesArray:");
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
        private static void ImprimirElementosList(List<string> aulas)
        {
            Console.WriteLine();
            Console.WriteLine("Início ImprimirElementosList");
            Console.WriteLine("Foreach:");
            //As Lists contém internamente um array, também podem ser chamados de Arrays dinâmicos
            //Se queremos imprimir os valores de cada elemento da List, precisamos percorrer ele e printar cada elemento:
            //Podemos percorrer a List com forEach:
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
            //Com For:
            Console.WriteLine("For:");
            for (int i = 0; i < aulas.Count; i++)
            {
                Console.WriteLine(aulas[i]);
            }

            //Com o método Foreach da própria List
            //o método ForEach, recebe como parâmetro uma Action, que nada mais é do que um método anônimo:
            Console.WriteLine("método ForEach da List:");
            aulas.ForEach(aula =>
            {
                Console.WriteLine(aula);
            });
        }
        private static void ImprimirElementosListReadOnly(IList<Aula> aulas)
        {
            Console.WriteLine();
            Console.WriteLine("Início ImprimirElementosListReadOnly");
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }
    }
}