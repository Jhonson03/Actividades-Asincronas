using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsincronaS2.Entidades;

namespace AsincronaS2.Negocio
{
    public class ClsDatos
    {
        public String Comparacion(Datos dat){
            if(dat.dat1 > dat.dat2){
                return $"\n numero {dat.dat1} es mayor que el numero {dat.dat2}";
            }
            else if(dat.dat2 > dat.dat1){
                return $"\nEl numero {dat.dat2} es mayor que el numero {dat.dat1}";
            }
            else{
                return "\nLos números ingresados son iguales";
            }
        }
    }
}