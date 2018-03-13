using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnaManager : MonoBehaviour {
	GameObject [,] columnas=new GameObject[9,9];
	private Manager manager;
	void Awake(){
		manager=GetComponent<Manager>();

	}
	void Start () {
		calc();
	//	Imprimir();
	}
	void calc(){
		for(int i=0;i<9;i++){
			for(int i2=0;i2<9;i2++){
				columnas[i,i2]=manager.getCeldas[i2].transform.GetChild(i).gameObject;
			}
		}
	}
	void Imprimir(){
		print("*************************imprimir*************************");
		for(int i=0;i<9;i++){
			print("fila ) "+i+1);
			for(int i2=0;i2<9;i2++){
				print("numero ) "+columnas[i,i2].GetComponent<Celda>().getNumero);

			}

		}	

	}
}
