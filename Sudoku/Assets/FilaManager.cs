using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FilaManager : MonoBehaviour {

	GameObject [,] filas=new GameObject[9,9];
	private Manager manager;
	void Awake () {
		manager=GetComponent<Manager>();
	}
	void Start(){
		//calc();
		//Control();
		//Imprimir();
	}

	public void calc(){
		for(int i=0;i<9;i++){
			for(int i2=0;i2<9;i2++){
				filas[i,i2]=manager.getCeldas[i].transform.GetChild(i2).gameObject;
			}
		}
	}
	public void Imprimir(){
		print("*************************imprimir fila manager*************************");
		for(int i=0;i<9;i++){
			//print("fila "+i+1);
			for(int i2=0;i2<9;i2++){
				//print("numero ) "+filas[i,i2].GetComponent<Celda>().getNumero);
				if(i==2){
					Celda auxVacia=filas[i,i2].GetComponent<Celda>();
					if(!auxVacia.get_set_Salio){
						for(int i3=0;i3<9;i3++){
						//imprimo booleanos	
							print("celda "+auxVacia.name);
							print("array) "+i3+""+auxVacia.getMyArraysBooleanos[i3]);
						
							}
						}

					}
				}
  			}	
		}
	public void Control(){
		for(int i=0;i<9;i++){
			for(int i2=0;i2<9;i2++){
				Celda auxNumero=filas[i,i2].GetComponent<Celda>();
				if(auxNumero.get_set_Salio){
					for(int i3=0;i3<9;i3++){
						Celda auxVacia=filas[i,i3].GetComponent<Celda>();
						if(!auxVacia.get_set_Salio){
							auxVacia.SetArrayBoleano(auxNumero.getNumero-1);

						}
					}
				}
			}
		}
	}

}
