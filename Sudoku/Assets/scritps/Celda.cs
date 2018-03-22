using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Celda :MonoBehaviour {

	private bool salio;
	private int numero=0;
	private bool []aNums=new bool[9];
	private Sprite sprite=null;
	private Deteccion deteccion;
	private GameObject objResaltado;
	private GameObject objAux;
	private GameObject objInput;
	private BoxCollider2D box;
	private Vector2 initialLocalScale;
	private bool stateInput=true;
	private SpawnNumeroAux spawnNumAuxs;
	private bool res=false;
	void Awake () {
		spawnNumAuxs=GetComponent<SpawnNumeroAux>();
		box=GetComponent<BoxCollider2D>();
		initialLocalScale=transform.localScale;
		initialLocalScale=new Vector2(initialLocalScale.x+box.offset.x,initialLocalScale.y+box.offset.y);
		deteccion=GetComponent<Deteccion>();
		ResetBooleans();
	
		sprite=transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite;
	//	print("sprite "+sprite);
		Initial();
	//	print("sprite manual "+GameObject.FindGameObjectWithTag("base").GetComponent<Sprites>().sprites[0]);
//		if(sprite==null){
//			spr.sprite=GameObject.FindGameObjectWithTag("base").GetComponent<Sprites>().sprites[0];
//		}
	}
	public void Events(){
		objInput.GetComponent<Id>().onClickme+=OnStateCambio;
		objAux.GetComponent<Id>().onClickme+=OnStateCambio;
	}
	void Start(){

	}
	private void OnStateCambio(string _state){
		
		if(_state=="SquareInput"){
			if(deteccion.getActive){
			spawnNumAuxs.EstadoNums(false);
			}
			stateInput=true;
			print("estado input cambio"+stateInput);
		}else{
			spawnNumAuxs.EstadoNums(true);
			stateInput=false;
			print("estado input cambio"+stateInput);
		}
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

	public void Resaltar(){
		Sprites aux=GameObject.FindGameObjectWithTag("base").GetComponent<Sprites>();
		//aux.spriteClick.SetActive(true);
		objResaltado.SetActive(true);
		res=true;
		PosicionarResaltado();
		if(stateInput){
		spawnNumAuxs.EstadoNums(false);
		}
		}
	private void PosicionarResaltado(){
		
		Vector2 sizeBox=box.size;
//		print("pos initial "+initialLocalScale);
		//objResaltado.transform.localScale=new Vector2(initialLocalScale.x,initialLocalScale.y);

//		print("pos obj vacio antes "+transform.position);
		objResaltado.transform.localScale=new Vector2(transform.localScale.x*sizeBox.x,transform.localScale.y*sizeBox.y);
		objResaltado.transform.position=new Vector2(transform.position.x+box.offset.x,transform.position.y+box.offset.y);
//		print("pos bj resaltado "+objResaltado.transform.position);
	//	print("offset "+box.offset.x);
	
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
	public GameObject setObjReslatado{
		set{
			objResaltado=value;	
		}
		get{
			return objResaltado;
		}
	}
	public GameObject setObjAux{
		set{
			objAux=value;
		}
	}
	public bool getStateInput{
		set{
			stateInput=value;
		}
		get{
			return stateInput;
		}
	}

	public GameObject setObjInput{
		set{
			objInput=value;
		}
	}
	public bool setBooleanoResaltar{
		set{
			res=value;
		}
	}

}
