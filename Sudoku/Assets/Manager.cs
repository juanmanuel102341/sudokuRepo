using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {
	private GameObject []aCeldas=new GameObject[9];
	private CuadritoManager cuadrito;

	private FilaManager fila;
	private ColumnaManager columna;
	void Awake () {
		cuadrito=GetComponent<CuadritoManager>();
		fila=GetComponent<FilaManager>();
		columna=GetComponent<ColumnaManager>();
	//	print("transfors childsn "+transform.childCount );
		for(int i=0;i<transform.childCount;i++){
			aCeldas[i]=transform.GetChild(i).gameObject;
			//print("celda "+aCeldas[i].name);
		}
	//	print("cantitdad de celdas array "+aCeldas.Length);

	}
	void Start(){
		Ciclo();
	}
	void Ciclo(){

		cuadrito.Calc3();
		fila.calc();
		columna.calc();
	
	//	cuadrito.Control();
	//	fila.Control();
	//	columna.Control();

	//	cuadrito.RegistroNumerosConteo();
	
		//fila.Imprimir();
		//cuadrito.Imprimir();
		
	}




	// Update is called once per frame
	void Update () {
		cuadrito.Control();
		fila.Control();
		columna.Control();

		cuadrito.RegistroNumerosConteo();
		//cuadrito.Busqueda();
	}
	public GameObject [] getCeldas{
		get{
			return aCeldas;
		}
	}
}
