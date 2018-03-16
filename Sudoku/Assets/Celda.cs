using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Celda :MonoBehaviour {

	private bool salio;
	private int numero=0;
	private bool []aNums=new bool[9];
	private Sprite sprite=null;
	private SpriteRenderer spr;
	void Awake () {
		ResetBooleans();
		spr=transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>();
		sprite=transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite;
	//	print("sprite "+sprite);
		Initial();
	//	print("sprite manual "+GameObject.FindGameObjectWithTag("base").GetComponent<Sprites>().sprites[0]);
//		if(sprite==null){
//			spr.sprite=GameObject.FindGameObjectWithTag("base").GetComponent<Sprites>().sprites[0];
//		}
	}
	private void ResetBooleans(){
		for(int i=0;i<9;i++){
			aNums[i]=false;
		}
	}
	private void Initial(){
		if(sprite!=null){
			//print("my sprite "+sprite.name);
			salio=true;
			numero=ObtenerNumero(sprite.name);

			//print(gameObject.name +" numrer q salio "+numero);
		//	print("salio "+salio+"sprite "+sprite.name);
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
//		if(BooleanosCompleto()){
//			numero=SetNumero();
//			salio=true;
//			print("array completo!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! "+numero);
//			SpriteSpawn(numero);
//		}
	}
	public bool BooleanosCompleto(){
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
	public void SpriteSpawn(int num){
		switch(num){
		case 1:
			spr.sprite=GameObject.FindGameObjectWithTag("base").GetComponent<Sprites>().sprites[num-1];
			break;
		case 2:
			spr.sprite=GameObject.FindGameObjectWithTag("base").GetComponent<Sprites>().sprites[num-1];
			break;
		case 3: 
			spr.sprite=GameObject.FindGameObjectWithTag("base").GetComponent<Sprites>().sprites[num-1];
			break;
		case 4:
			spr.sprite=GameObject.FindGameObjectWithTag("base").GetComponent<Sprites>().sprites[num-1];
			break;
		case 5:
			spr.sprite=GameObject.FindGameObjectWithTag("base").GetComponent<Sprites>().sprites[num-1];
			break;
		case 6: 
			spr.sprite=GameObject.FindGameObjectWithTag("base").GetComponent<Sprites>().sprites[num-1];
			break;
		case 7:
			spr.sprite=GameObject.FindGameObjectWithTag("base").GetComponent<Sprites>().sprites[num-1];
			break;
		case 8:
			spr.sprite=GameObject.FindGameObjectWithTag("base").GetComponent<Sprites>().sprites[num-1];
			break;
		case 9:
				spr.sprite=GameObject.FindGameObjectWithTag("base").GetComponent<Sprites>().sprites[num-1];
			break;
					
		}
	}
	public void Resaltar(){
		Sprites aux=GameObject.FindGameObjectWithTag("base").GetComponent<Sprites>();
		aux.spriteClick.SetActive(true);

		aux.spriteClick.transform.position=new Vector2(transform.position.x+0.1f,transform.position.y);
	} 
	public int SetNumero(){
		for(int i=0;i<aNums.Length;i++){
			if(!aNums[i]){
				return i+1;
			}
		}
		return 0;
	}
	public int getNumero{
		get{
			return numero;
		}
		set{
			numero=value;
		}
	}
	public bool get_set_Salio{
		get{
			return salio;
		}
		set{
			salio=value;
		}
	}
	public bool[] getMyArraysBooleanos{
		get{
			return aNums; 
		}
	}

}
