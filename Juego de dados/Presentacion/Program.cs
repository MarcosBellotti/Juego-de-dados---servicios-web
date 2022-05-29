using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebService.ServiceClient servicio= new WebService.ServiceClient();
            int cantidadDeNumeros = 5;
            int puntajeTotal = 0;


            while (true)
            {
                List<int> Valores = new List<int>();
                Random valorRandom = new Random();

                for (int i = 0; i < cantidadDeNumeros; i++)
                {
                    Valores.Add(valorRandom.Next(1, 6));
                }

                WebService.Respuesta respuesta = servicio.DevolverMensaje(Valores.ToArray(), puntajeTotal, cantidadDeNumeros);
                Console.WriteLine($"{respuesta.Mensaje} \n Suma puntos: {respuesta.Puntos} \n Dados restantes: {respuesta.CantidadRestante} \n Valores: {String.Join(", ", Valores)} \n Valores restantes: {String.Join(", ", respuesta.Valores)}");
                Console.ReadKey();

                if (respuesta.Mensaje=="Perdiste")
                    break;
                else
                {
                    cantidadDeNumeros = respuesta.CantidadRestante;
                    puntajeTotal=respuesta.Puntos;
                }
                    
            }
        }
    }
}
