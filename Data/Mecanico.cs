
using System.Collections.Generic;

namespace mantencion.Data{

    public class Mecanico{
        public int id {get; set;} 
        public string rut {get;set;}       
        public string nombre {get;set;}
        public List<Trabaja_en> Trabaja_Ens {get;set;}
    }
}