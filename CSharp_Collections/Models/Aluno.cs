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
    }
}
