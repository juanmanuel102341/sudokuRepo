using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprites : MonoBehaviour {
	public Sprite [] sprites=new Sprite[9];
	public GameObject spriteClick;
	void Awake () {
		
	}
	void Start(){
		spriteClick.SetActive(false);
	}

}
