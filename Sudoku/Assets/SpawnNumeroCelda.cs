using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNumeroCelda : MonoBehaviour {
	private SpriteRenderer spr;
	private Vector2 initialLocal;
	private Vector2 localScale;
	private Celda celda;
	// Use this for initialization
	void Awake () {
		spr=transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>();
		celda=GetComponent<Celda>();
			

		initialLocal=new Vector2(0.6f,1.09f);
		//localScale=spr.g
	}
	
	// Update is called once per frame
	private void Create(int _num){
		spr.sprite=GameObject.FindGameObjectWithTag("base").GetComponent<Sprites>().sprites[_num-1];
		spr.gameObject.transform.localPosition=new Vector2(0,0);
		spr.gameObject.transform.localScale=new Vector2(initialLocal.x,initialLocal.y);
		celda.get_set_Salio=true;//reseteo booleano parra q n sse pueda sobrescribir
		celda.getNumero=_num;//actualizo valor introducido

	}

	public void SpriteSpawn(int num){
		switch(num){
		case 1:
			Create(num);
			break;
		case 2:
			Create(num);
			break;
		case 3: 
			Create(num);
			break;
		case 4:
			Create(num);
			break;
		case 5:
			Create(num);
			break;
		case 6: 
			Create(num);
			break;
		case 7:
			Create(num);
			break;
		case 8:
			Create(num);
			break;
		case 9:
			Create(num);
			break;

		}
	}

}
