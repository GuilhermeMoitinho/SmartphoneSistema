using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitesmaSmartPhone.Models
{
    public abstract class Smartphone
    {
        public string Number { get; set; }
        public string Modelo { get; set; }
        public string Imei { get; set; } = "000000-00-000000-0";
        public int Memoria { get; set; }

        public Smartphone() {}

        public Smartphone(string number, string modelo, string imei, int memoria){
            Number = number;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;  
        }

        public void Ligar(){
            System.Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao(){
            System.Console.WriteLine("Recebendo Ligacao...");
        }

        public abstract void InstalarApp(string nome);

        public override string ToString()
        {
            StringBuilder sr = new StringBuilder();
            sr.AppendLine("Seu Smartphone eh o: "+Modelo+", e seu numero eh: "+Number);
            sr.AppendLine("Seu Imei: "+Imei);
            sr.AppendLine("Seu Smartphone tem "+Memoria+", de memoria!");

            return sr.ToString();
        }

    }
}