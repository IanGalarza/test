
using System;

namespace proyecto
{
	public class Obra
	{
		//atributos
		private double avance = 0;
		private string tipoDeObra;
		private string tiempoEstimado;
		private int gruposTrabajando;
		private int costo;
		private string nombrePropietario;
		private int dniPropietario;
		private int codigoInterno;
		public static int codigoSistema = 0;
		
		//constructores
		public Obra(){}
		public Obra (double avance, string tipoDeObra, string tiempoEstimado, int gruposTrabajando, int costo, string nombrePropietario, int dniPropietario, int codigoInterno){
			this.avance = avance;
			this.tipoDeObra = tipoDeObra;
			this.tiempoEstimado = tiempoEstimado;
			this.gruposTrabajando = gruposTrabajando;
			this.costo = costo;
			this.nombrePropietario = nombrePropietario;
			this.dniPropietario = dniPropietario;
			this.codigoInterno = codigoInterno;
		}
		
		//propiedades
		
		public string TipoDeObra{
			set{ tipoDeObra = value;}
			get{ return tipoDeObra;}
		}
		
		public string TiempoEstimado{
			set{ tiempoEstimado = value;}
			get { return tiempoEstimado;}
		}
		
		public int Costo{
			set { costo = value;}
			get { return costo;}
		}
		
		public string NombrePropietario{
			set {nombrePropietario = value;}
			get {return nombrePropietario;}
		}
		
		public int DniPropietario{
			set {dniPropietario = value;}
			get {return dniPropietario;}
		}
		
		public int GruposTrabajando{
			set {gruposTrabajando = value;}
			get {return gruposTrabajando;}
		}
		
		public int CodigoInterno{
			set {codigoInterno = value;}
			get {return codigoInterno;}
		}
		
		public double Avance {
			set{avance = value;}
			get {return avance;}
		}
	}
}
