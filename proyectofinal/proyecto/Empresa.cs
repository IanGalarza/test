
using System;
using System.Collections;
namespace proyecto
{
	public class Empresa
	{	
		// atributos
		private string nombre;
		private ArrayList listaObras;
		private ArrayList listaGrupos;
		private ArrayList listaObrasFinalizadas;
		
		//constructor
		public Empresa()
		{
			listaObras = new ArrayList();
			listaGrupos = new ArrayList();
			listaObrasFinalizadas = new ArrayList ();
		}
		
		// metodos basicos relacionados con obras
		
		public void agregarObra (Obra proyecto){
			listaObras.Add(proyecto);
		}
		
		public void eliminarObra (Obra proyecto){
			listaObras.Remove(proyecto);
		}
		
		public int cantidadObras (){
			return listaObras.Count;
		}
		
		public ArrayList todasObras (){
			return listaObras;
		}
		
		public bool existeObra (Obra proyecto){
			return listaObras.Contains(proyecto);
		}
		
		public Obra verObra (int valor){
			return (Obra)this.listaObras[valor];
		}
		
	
		//metodos basicos relacionados con grupos
		
		public void agregarGrupo (Grupo equip){
			listaGrupos.Add(equip);
		}
		
		public void eliminarGrupo (Grupo equip){
			listaGrupos.Remove(equip);
		}
		
		public bool existeGrupo (Grupo equip){
			return listaGrupos.Contains(equip);
		}
		
		public int cantidadGrupos (){
			return listaGrupos.Count;
		}
		
		public ArrayList gruposIntegrados (){
			return listaGrupos;
		}
		
		public Grupo verGrupo (int valor){
			return (Grupo)this.listaGrupos[valor];
		}
		
		//metodos basicos relacionados con obras finalizadas
		
				public void agregarObraFinalizada (Obra proyecto){
			listaObrasFinalizadas.Add(proyecto);
		}
		
		public void eliminarObraFinalizada (Obra proyecto){
			listaObrasFinalizadas.Remove(proyecto);
		}
		
		public int cantidadObrasFinalizadas (){
			return listaObrasFinalizadas.Count;
		}
		
		public ArrayList todasObrasFinalizadas (){
			return listaObrasFinalizadas;
		}
		
		public bool existeObraFinalizada (Obra proyecto){
			return listaObrasFinalizadas.Contains(proyecto);
		}
		
		public Obra verObraFinalizada (int valor){
			return (Obra)this.listaObrasFinalizadas[valor];
		}
		
		//propiedades
		
		public string Nombre {
			set {nombre = value;}
			get {return nombre;}
		}
	}
}
