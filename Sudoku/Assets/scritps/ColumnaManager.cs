﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnaManager : MonoBehaviour {
	GameObject [,] columnas=new GameObject[9,9];
	private Manager manager;
	void Awake(){
		manager=GetComponent<Manager>();

	}
	void Start () {
		//calc();
		///Control();
		//Imprimir();
	}
	public void calc(){
		for(int i=0;i<9;i++){
			for(int i2=0;i2<9;i2++){
				columnas[i,i2]=manager.getCeldas[i2].transform.GetChild(i).gameObject;
			}
		}
	}
	public void Imprimir(){
	print("*************************imprimir columna*************************");
		for(int i=0;i<9;i++){
		//	print("fila ) "+i+1);
			for(int i2=0;i2<9;i2++){
		//		print("numero ) "+columnas[i,i2].GetComponent<Celda>().getNumero);
				if(i==0){
					Celda auxVacia=columnas[i,i2].GetComponent<Celda>();
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
				Celda auxNumero=columnas[i,i2].GetComponent<Celda>();
				if(auxNumero.get_set_Salio){
					for(int i3=0;i3<9;i3++){
						Celda auxVacia=columnas[i,i3].GetComponent<Celda>();
						if(!auxVacia.get_set_Salio){
							auxVacia.SetArrayBoleano(auxNumero.getNumero-1);
						
						}
					}
				}
			}
		}
	}

}
