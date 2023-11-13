using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdAcademy.Model
{
    public class Curso
    {
        public Int64 Id { get; set; }
        public string NomeCurso { get; set; }
        public string DescricaoCurso { get; set; }
        public string NomeAula { get; set; }
        public string TituloAula { get; set; }
        public string DescricaoAula { get; set; }
        public string UrlVideo { get; set; }



        public Professor Professor { get; set; }
        public Int64 ProfessorId { get; set; }
        public ICollection<Aluno> Alunos { get; set; }


    }
}
