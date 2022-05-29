using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

public class Service : IService
{
    public Respuesta DevolverMensaje(List<int> valores, int puntajeTotal, int cantidadRestante)
    {
        int[] vectorNumeros= new int[] {0,0,0,0,0,0};

        if (valores.Distinct().Count() == 5)
            if ((valores.Contains(1) && !valores.Contains(6)) || (valores.Contains(6) && !valores.Contains(1)))
            {
                return new Respuesta() { Mensaje = "Tira de nuevo los dados", Valores = valores, Puntos = puntajeTotal + 20, CantidadRestante = 5};
            }
            else
            {
                return new Respuesta() { Mensaje = "Perdiste", Valores = valores, Puntos = puntajeTotal - 20, CantidadRestante = 0 };
            }
        else
        {
            for (int i = 0; i < cantidadRestante; i++)
            {
                vectorNumeros[valores[i] - 1] += 1;
            }

            for (int i = 0; i < 6; i++)
            {
                if(vectorNumeros[i] > 1)
                {
                    puntajeTotal = puntajeTotal + ((i + 1) * vectorNumeros[i]);
                    while(true)
                    {
                        if (valores.Contains(i+1)==true)
                            valores.Remove(i + 1);
                        else
                            break;
                    }
                    
                }
                    
            }
            return valores.Count == 1 ? new Respuesta() { Mensaje = "Perdiste", Valores = valores, Puntos = puntajeTotal, CantidadRestante = 1 } : new Respuesta() { Mensaje = "Tira de nuevo los dados", Valores = valores, Puntos = puntajeTotal, CantidadRestante = valores.Count };
        }
    }
}
