using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Collections.Models
{
    internal class Aluno
    {
        private string _nome;
        private int _numeroMatricula;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public int NumeroMatricula
        {
            get { return _numeroMatricula; }
            set { _numeroMatricula = value; }
        }

        public Aluno(string nome, int numeroMatricula)
        {
            _nome = nome;
            _numeroMatricula = numeroMatricula;
        }

        public override string ToString()
        {
            return $"[Nome: {_nome}, Matrícula: {_numeroMatricula}]";
        }

        //O método Equals serve para compararmos se um objeto é igual a outro.
        //o Equals é um método da classe object,
        //e possui uma implementação default que compara se a instância (objeto na memória) de um objeto é igual a outra.
        //Porém, nós podemos sobrescrevê-lo, como fizemos com o ToString, dessa forma,
        //nós podemos determinar o que deve ser comparado para determinar se um objeto é igual ao outro
        //No caso da nossa sobrescrita,
        //estamos dizendo que um aluno é igual ao outro quando contém o mesmo nome e mesmo número de matrícula,
        //Caso o objeto que estamos comparando com o objeto Aluno não seja do tipo Aluno, o Equals já retorna false
        public override bool Equals(object? obj)
        {
            return obj is Aluno aluno &&
                   _nome == aluno._nome &&
                   _numeroMatricula == aluno._numeroMatricula;
        }

        //Sempre que sobrescrevemos o Equals, precisamos obrigatóriamente sobrescrever também o método GetHashCode.
        //Por padrão, a sobrescrita do método GetHashCode segue a ideia da sobrescrita do Equals,
        //Então, se por exemplo,
        //no nosso Equals nós estamos dizendo que pra dois alunos serem iguais eles precisam conter o mesmo nome e o mesmo número de matrícula
        //No nosso GetHashCode, nós iremos considerar que o HashCode do Aluno é a combinação do HashCode do nome do aluno e do HashCode da matrícula do aluno
        public override int GetHashCode()
        {
            return HashCode.Combine(_nome, _numeroMatricula);
        }
        //IMPORTANTE!
        //A rapidez da busca depende que o GetHashCode funcione corretamente,
        //portanto, como uma boa prática, a lógica que utilizamos no Equals deve ser semelhante a lógica que utilizamos no GetHashCode
        //IMPORTANTE2!
        //Dois objetos que são iguais possuem o mesmo HashCode,
        //PORÉM, o contrário não é verdadeiro:
        //Dois objetos com o mesmo HashCode não são necessáriamente iguais!
    }
}
