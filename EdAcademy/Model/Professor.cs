using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdAcademy.Model
{
    public class Professor
    {
        public Int64 Id { get; set; }
        public int Nivel { get; set; } = 13;
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Formacao { get; set; }
        public string Email { get; set; }

        public ICollection<Curso> Cursos { get; set; }
        public ICollection<Aluno> Alunos { get; set; }

 
    }
}
