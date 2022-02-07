using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Collections.Models
{
    internal class Curso
    {
        //_alunos deve ser um ISet. Alunos deve retornar ReadOnlyCollection
        private ISet<Aluno> _alunos = new HashSet<Aluno>();
        public IList<Aluno> Alunos
        {
            get
            {
                return new ReadOnlyCollection<Aluno>(_alunos.ToList());
            }
        }

        private IList<Aula> _aulas;
        private string _nome;
        private string _instrutor;
        public IList<Aula> Aulas
        {
            get { return new ReadOnlyCollection<Aula>(_aulas); }
        }
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public string Instrutor
        {
            get { return _instrutor; }
            set { _instrutor = value; }
        }
        public int TempoTotal
        {
            get
            {
                //LINQ = Language Integrated Query
                //Consulta Integrada à Linguagem

                return _aulas.Sum(aula => aula.Tempo);
            }
        }
        public Curso(string nome, string instrutor)
        {
            _nome = nome;
            _instrutor = instrutor;
            _aulas = new List<Aula>();
        }
        internal void AdicionaAula(Aula aula)
        {
            this._aulas.Add(aula);
        }
        public override string ToString()
        {
            return $"Curso: {_nome}, Tempo: {TempoTotal}, Aulas: {string.Join(",", _aulas)}";
        }

        internal void Matricula(Aluno aluno)
        {
            _alunos.Add(aluno);
        }
    }
}
