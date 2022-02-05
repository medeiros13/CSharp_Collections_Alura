using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Collections.Models
{
    internal class Aula : IComparable
    {
        private string _titulo;
        private int _tempo;
        public string Titulo { get => _titulo; set => _titulo = value; }
        public int Tempo { get => _tempo; set => _tempo = value; }

        public Aula(string titulo, int tempo)
        {
            this._titulo = titulo;
            this._tempo = tempo;
        }
        public override string ToString()
        {
            return $"[título: {this._titulo}, tempo: {this._tempo} minutos]";
        }

        //O método CompareTo é o método chamado pelo Sort, aqui é onde definimos como nossos elementos da Lista devem ser ordenados
        //esse método recebe como parâmetro um objeto to tipo object, que é o mais genérico, portanto, se desejamos ordenar uma lista de Aulas,
        //precisamos tentar converter esse object em um objeto do tipo Aula
        public int CompareTo(object? obj)
        {
            //Aqui, estamos fazendo o cast de object para Aula
            Aula that = obj as Aula;
            //Aqui estamos utilizando o CompareTo da propriedade titulo, que é uma string, que já possui o CompareTo, portanto, comparamos um título com o outro
            return _titulo.CompareTo(that._titulo);
        }
    }
}
