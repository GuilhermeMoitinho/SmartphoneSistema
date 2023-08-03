using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SitesmaSmartPhone.Models
{
    public class Nokia : Smartphone
    {

        public Nokia(){}
        public Nokia(string modelo, string number, string imei, int memoria){
        Number = number;
        Modelo = modelo;
        Imei = imei;
        Memoria = memoria;  
        }

        public override void InstalarApp(string nome)
        {
            System.Console.WriteLine("Seu aplicativo sera instalado pela Apple Store!");;
        }
    }
}