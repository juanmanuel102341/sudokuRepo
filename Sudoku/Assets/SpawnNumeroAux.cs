using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNumeroAux : MonoBehaviour {

	private SpriteRenderer spr;
	private float scaleX=0.2f;
	private float scaleY=0.4f;
	private float posx=-0.3f;
	private float posy=0.3f;
	private GameObject[] objs=new GameObject[9];
	private int index=0;
	private bool[] activo=new bool[9];
	void Awake () {
	//	spr=transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>();
		float px=-0.3f;
		float py=0.3f;
	
		for(int i=0;i<9;i++){
			activo[i]=false;
		}
	}
	
	// Update is called once per frame

	private void CreacionObjeto(int _num){
		objs[_num-1]=new GameObject();
		objs[_num-1].transform.SetParent(this.transform);
		objs[_num-1].AddComponent<SpriteRenderer>();
		objs[_num-1].GetComponent<SpriteRenderer>().sprite=GameObject.FindGameObjectWithTag("base").GetComponent<Sprites>().sprites[_num-1];
		objs[_num-1].transform.localPosition=new Vector2(posx,posy);
		objs[_num-1].transform.localScale=new Vector2(scaleX,scaleY);
		index++;
		if(index==3||index==6){
			posy-=0.3f;	
			posx=-0.3f;
		}else{
			posx+=0.3f;
		}
	}
	private void EstadoSpawn(int _num){
		if(activo[_num-1]){
			objs[_num-1].SetActive(false);
			activo[_num-1]=false;
		}else{
			objs[_num-1].SetActive(true);
			activo[_num-1]=true;
		}	
	}
	public void SpriteSpawn(int num){
		switch(num){
		case 1:
			if(objs[num-1]==null){
				CreacionObjeto(num);
				activo[num-1]=true;
			}else{
				print("OBJETO YA CREADO");
				EstadoSpawn(num);
			}
			break;
		case 2:
			if(objs[num-1]==null){
				CreacionObjeto(num);
				activo[num-1]=true;
			}else{
				EstadoSpawn(num);
			}
			break;
		case 3: 
			if(objs[num-1]==null){
				CreacionObjeto(num);
				activo[num-1]=true;
			}else{
				print("OBJETO YA CREADO");
				EstadoSpawn(num);
			}
			break;
		case 4:
			if(objs[num-1]==null){
				CreacionObjeto(num);
				activo[num-1]=true;
			}else{
				print("OBJETO YA CREADO");
				EstadoSpawn(num);
			}
			break;
		case 5:
			if(objs[num-1]==null){
				CreacionObjeto(num);
				activo[num-1]=true;
			}else{
				print("OBJETO YA CREADO");
				EstadoSpawn(num);
			}
			break;
		case 6: 
			if(objs[num-1]==null){
				CreacionObjeto(num);
				activo[num-1]=true;
			}else{
				EstadoSpawn(num);
			}
			break;
		case 7:
			if(objs[num-1]==null){
				CreacionObjeto(num);
				activo[num-1]=true;
			}else{
				print("OBJETO YA CREADO");
				EstadoSpawn(num);
			}
			break;
		case 8:
			if(objs[num-1]==null){
				CreacionObjeto(num);
				activo[num-1]=true;
			}else{
				print("OBJETO YA CREADO");
				EstadoSpawn(num);
			}
			break;
		case 9:
			if(objs[num-1]==null){
				CreacionObjeto(num);
				activo[num-1]=true;
			}else{
				print("OBJETO YA CREADO");
				EstadoSpawn(num);
			}
			break;

		}
	}
	public void EstadoNums(bool _state){

		for(int i=0;i<objs.Length;i++){
			if(objs[i]!=null)
			objs[i].SetActive(false);
		}
	}

}