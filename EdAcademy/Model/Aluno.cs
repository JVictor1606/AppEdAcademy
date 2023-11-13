using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdAcademy.Model
{
    public class Aluno
    {
        [PrimaryKey, AutoIncrement]
        public Int64 Id { get; set; }
        public bool Incrito { get; set; }
        public int Nivel { set; get; } = 1;
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string EscolaFaculdade { get; set; }
        public string Formacao { get; set; }
        


        public Curso Curso { get; set; }
        public Int64 CursoId { get;set; }
    }
}
