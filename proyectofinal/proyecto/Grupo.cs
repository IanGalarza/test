
using System;
using System.Collections;
namespace proyecto
{
	public class Grupo
	{
		//atributos
		private ArrayList listaObreros;
		private int codigoDeObra = 0;
		private int numeroGrupo;
		// constructor
		public Grupo()
		{
			this.listaObreros = new ArrayList();
		}

		// metodos
		public void agregarObrero (Obrero obr){
			listaObreros.Add(obr);
		}
		public void eliminarObrero (Obrero obr){
			listaObreros.Remove(obr);
		}
		
		public bool existeObrero (Obrero obr){
			return listaObreros.Contains(obr);
		}
		
		public ArrayList miembrosGrupos(){
			return listaObreros;
			}
		
		public int cantidadObreros (){
			return listaObreros.Count;
		}
		
		public Obrero verObrero (int valor){
			return (Obrero)this.listaObreros[valor];
		}
		
		public int CodigoDeObra{
			set { codigoDeObra = value;
		}
			get {
				return codigoDeObra;}
			}
		
		public int NumeroGrupo{
			set{
				numeroGrupo = value;
			}
			get {
				return numeroGrupo;
			}
		}	
	}
}
