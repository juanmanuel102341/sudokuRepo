using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManejandoResaltado : MonoBehaviour {

	private CuadritoManager cuadrito;
	private Celda actual=null;
	private Celda anterior=null;
	void Awake () {
		cuadrito=GetComponent<CuadritoManager>();
	}
	
	// Update is called once per frame
	void Update () {
		Celda celda=CalcActivo();
		if(celda!=null){
			if(actual==null){
				actual=celda;
			}
			if(celda!=actual){
				print("cambio "+actual);
				anterior=actual;
				anterior.gameObject.GetComponent<Deteccion>().getActive=false;
				actual=celda;
				actual.gameObject.GetComponent<Deteccion>().getActive=true;
			}
		}
	
	}

	private Celda CalcActivo(){
		for(int i=0;i<9;i++){
			for(int i2=0;i2<9;i2++){
				if (cuadrito.getCuadritos[i,i2].GetComponent<Deteccion>().getActive&&cuadrito.getCuadritos[i,i2].GetComponent<Celda>()!=actual||actual==null){
					return cuadrito.getCuadritos[i,i2].GetComponent<Celda>();
				}
			}	
		}
		return null;
	}


}
