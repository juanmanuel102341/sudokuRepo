using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Id : MonoBehaviour {
	public delegate void ClickMe(string name);
	public event ClickMe onClickme;


	void OnMouseDown() {
		print("click "+gameObject.name);
		onClickme(gameObject.name);
	}
}
