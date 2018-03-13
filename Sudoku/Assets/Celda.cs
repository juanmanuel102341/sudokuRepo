using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Celda :MonoBehaviour {

	private bool salio;
	private int numero=0;
	private bool []aNums=new bool[9];
	private Sprite sprite;
	void Awake () {
		sprite=transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite;
		Initial();
	}
	private void Initial(){
		if(sprite!=null){
			//print("my sprite "+sprite.name);
			salio=true;
			numero=ObtenerNumero(sprite.name);
			//print(gameObject.name +" numrer q salio "+numero);
		}else{
			//print( gameObject.name+" objeto nulo");
		}
	}

	private int ObtenerNumero(string id){
		switch(id){
		case "numsSheet_0":
			return 1;
		
		case "numsSheet_1":
			return 2;
		case "numsSheet_2":
			return 3;
		case "numsSheet_3":
			return 4;
		case "numsSheet_4":
			return 5;
		case "numsSheet_5":
			return 6;
		case "numsSheet_6":
			return 7;
		case "numsSheet_7":
			return 8;
		case "numsSheet_8":
			return 9;
		}
		return 0;
		}
	public void SetArrayBoleano(int index){
		aNums[index]=true;
		if(BooleanosCompleto()){
			numero=SetNumero();
		}
	}
	private bool BooleanosCompleto(){
		int auxContador=0;
		for(int i=0;i<aNums.Length;i++){
			if(aNums[i]){
				auxContador++;	
			}
		}
		if(auxContador==aNums.Length-1){
			return true;
		}else{
			return false;
		}
	}

	private int SetNumero(){
		for(int i=0;i<aNums.Length;i++){
			if(aNums[i]){
				return i+1;
			}
		}
		return 0;
	}
	public int getNumero{
		get{
			return numero;
		}
	}
}
