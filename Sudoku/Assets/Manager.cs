using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {
	private GameObject []aCeldas=new GameObject[9];
	void Awake () {
	//	print("transfors childsn "+transform.childCount );
		for(int i=0;i<transform.childCount;i++){
			aCeldas[i]=transform.GetChild(i).gameObject;
			//print("celda "+aCeldas[i].name);
		}
	//	print("cantitdad de celdas array "+aCeldas.Length);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public GameObject [] getCeldas{
		get{
			return aCeldas;
		}
	}
}
