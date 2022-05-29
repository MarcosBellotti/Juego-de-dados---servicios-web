using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

[ServiceContract]
public interface IService
{
	[OperationContract]
	Respuesta DevolverMensaje(List<int> valor, int puntajeTotal, int cantidadRestante);
}

[DataContract]
public class Respuesta
{
	[DataMember]
	public List<int> Valores { get; set; }

	[DataMember]
	public int Puntos { get; set; }

	[DataMember]
	public int CantidadRestante { get; set; }

	[DataMember]
	public string Mensaje { get; set; }

}
