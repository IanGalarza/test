
using System;
using System.Collections;

namespace proyecto
{

	public class Obrero
	{
		private string nombre, apellido, cargo;
		private int dni, legajo, codigoGrupo;
		
		/*constructor*/
	
		public Obrero()	{}
		
		public Obrero (string nombre, string apellido,string cargo, int dni, int legajo, int codigoGrupo){
			this.nombre = nombre;
			this.apellido = apellido;
			this.cargo = cargo;
			this.dni = dni;
			this.legajo = legajo;
			this.codigoGrupo = codigoGrupo;
			}
		
		/*propiedades*/
		public string Nombre{
			set {
				nombre = value;
			}
			get {
				return nombre;
			}
		}
		
		public string Apellido{
			set {
				apellido = value;
			}
			get {
				return apellido;
			}
		}
		
		public string Cargo{
			set {
				cargo = value;
			}
			get {
				return cargo;
			}
		}
		public int Dni{
			set {
				dni = value;
			}
			get {
				return dni;
			}
		}
		
		public int Legajo{
			set {
				legajo = value;
			}
			get {
				return legajo;
			}
		}
		
		public int CodigoGrupo{
			set{
				codigoGrupo = value;
			}
			get {
				return codigoGrupo;
			}
		}
		
	}
}
