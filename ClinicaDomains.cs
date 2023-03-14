using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFramework;

namespace Prokect.Domains
{
    public class Persona
    {
        public string Name {get;set;}
    }
    public class  Medico : Persona
    {
        // public string Name {get;set;} heredado
        [Key]
        public int N_Matricula {get;set;}
        public string Especialidad {get;set;}
        
    }
    public class Paciente : Persona
    {
        // public string Name {get;set;} heredad
        [Key]
        public int H_Clinica {get;set;}
        public ICollection<Consulta> Consultas {get;set;}   //1 => many
        
    }

    public class Consulta
    {
        [Key]
        public int Consulta_id {get;set;}

        [ForeignKey("Medico")]
        public int Medico_Id   {get;set;}
        public DateTime Fecha {get;set;}
        public int Costo {get;set;}
        public int CostoMateriales {get;set;}   //float

        public string Descripcion {get;set;}
        
    }

}