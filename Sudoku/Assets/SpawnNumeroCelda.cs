using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNumeroCelda : MonoBehaviour {
	private SpriteRenderer spr;
	// Use this for initialization
	void Awake () {
		spr=transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame


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

}
