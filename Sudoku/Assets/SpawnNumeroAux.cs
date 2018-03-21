using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNumeroAux : MonoBehaviour {

	private SpriteRenderer spr;
	private float scaleX=0.2f;
	private float scaleY=0.4f;
	private float posx=-0.3f;
	private float posy=0.3f;
	void Awake () {
		spr=transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame

	public void SpriteSpawn(int num){
		switch(num){
		case 1:
			spr.sprite=GameObject.FindGameObjectWithTag("base").GetComponent<Sprites>().sprites[num-1];
			spr.gameObject.transform.localScale=new Vector2(scaleX,scaleY);
			spr.gameObject.transform.localPosition=new Vector2(posx,posy);
			break;
		case 2:
			spr.sprite=GameObject.FindGameObjectWithTag("base").GetComponent<Sprites>().sprites[num-1];
			spr.gameObject.transform.localScale=new Vector2(scaleX,scaleY);
			spr.gameObject.transform.localPosition=new Vector2(posx,posy);
			break;
		case 3: 
			spr.sprite=GameObject.FindGameObjectWithTag("base").GetComponent<Sprites>().sprites[num-1];
			spr.gameObject.transform.localScale=new Vector2(scaleX,scaleY);
			spr.gameObject.transform.localPosition=new Vector2(posx,posy);
			break;
		case 4:
			spr.sprite=GameObject.FindGameObjectWithTag("base").GetComponent<Sprites>().sprites[num-1];
			spr.gameObject.transform.localScale=new Vector2(scaleX,scaleY);
			spr.gameObject.transform.localPosition=new Vector2(posx,posy);
			break;
		case 5:
			spr.sprite=GameObject.FindGameObjectWithTag("base").GetComponent<Sprites>().sprites[num-1];
			spr.gameObject.transform.localScale=new Vector2(scaleX,scaleY);
			spr.gameObject.transform.localPosition=new Vector2(posx,posy);
			break;
		case 6: 
			spr.sprite=GameObject.FindGameObjectWithTag("base").GetComponent<Sprites>().sprites[num-1];
			spr.gameObject.transform.localScale=new Vector2(scaleX,scaleY);
			spr.gameObject.transform.localPosition=new Vector2(posx,posy);
			break;
		case 7:
			spr.sprite=GameObject.FindGameObjectWithTag("base").GetComponent<Sprites>().sprites[num-1];
			spr.gameObject.transform.localScale=new Vector2(scaleX,scaleY);
			spr.gameObject.transform.localPosition=new Vector2(posx,posy);
			break;
		case 8:
			spr.sprite=GameObject.FindGameObjectWithTag("base").GetComponent<Sprites>().sprites[num-1];
			spr.gameObject.transform.localScale=new Vector2(scaleX,scaleY);
			spr.gameObject.transform.localPosition=new Vector2(posx,posy);
			break;
		case 9:
			spr.sprite=GameObject.FindGameObjectWithTag("base").GetComponent<Sprites>().sprites[num-1];
			spr.gameObject.transform.localScale=new Vector2(scaleX,scaleY);
			spr.gameObject.transform.localPosition=new Vector2(posx,posy);
			break;

		}
	}
}