using System;
using System.Collections.Generic;
using RealTimeEstrategy;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Nigromante nigro1 = new Nigromante(EFaccion.Horda,250,300, "Kel-thuzad", ERaza.muertoViviente, 10);
            Arquera arquera2 = new Arquera(EFaccion.Alianza, 250, 350,"Sylvanas", ERaza.elfo, 15);
            Grunt grunt3 = new Grunt(EFaccion.Horda, 600, 250, 5, "Garrosh", ERaza.orco);
            Druida druida4 = new Druida(400, 325, "Malfurion", ERaza.elfo, 8);
            Minionsito we = new Minionsito();

            List<Unidad> personajitos = new List<Unidad>();
            List<IRanged> aDistancia = new List<IRanged>(); //agrupo bichos a distancia
            IMelee unMelee = grunt3;

            personajitos.Add(nigro1); //ok
            personajitos.Add(arquera2); //ok
            aDistancia.Add(nigro1);
            aDistancia.Add(druida4);// implementa las dos entonces puedo hacer el Add 
            
          
          

            Console.WriteLine(nigro1.AtacarDistanca());
            Console.ReadKey();

            Console.WriteLine(arquera2.AtacarDistanca());
            Console.ReadKey();

            Console.WriteLine(grunt3.AtacarMelee());

            Console.ReadKey();
            Console.WriteLine("Tipo de dato IRanged");
            IRanged ranged = arquera2; //no puedo instanciar una interfaz pero si puedo asignarle un objeto que la implemente
            Console.WriteLine(ranged.AtacarDistanca());

            Console.ReadKey();
            Console.WriteLine(druida4.AtacarDistanca());
            Console.ReadKey();
            Console.WriteLine(druida4.AtacarMelee());
            ((IMelee)druida4).Morir(); //debo castear a la interfaz que vaya a utilizar para poder acceder al metodo
            

        }
    }
}
