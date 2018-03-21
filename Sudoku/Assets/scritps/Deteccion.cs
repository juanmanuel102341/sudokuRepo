
using UnityEngine;

public class Deteccion : MonoBehaviour {
	private Celda celda;
	private bool active=false;
	private SpawnNumeroCelda spawnNumeroCelda;
	private SpawnNumeroAux spawnAux;
	//public bool resaltando=false;
	private KeyCode[] keys=new KeyCode[9];
	void Awake () {
		celda=GetComponent<Celda>();
		spawnNumeroCelda=GetComponent<SpawnNumeroCelda>();
		spawnAux=GetComponent<SpawnNumeroAux>();
		keys[0]=KeyCode.Alpha1;
		keys[1]=KeyCode.Alpha2;
		keys[2]=KeyCode.Alpha3;
		keys[3]=KeyCode.Alpha4;
		keys[4]=KeyCode.Alpha5;
		keys[5]=KeyCode.Alpha6;
		keys[6]=KeyCode.Alpha7;
		keys[7]=KeyCode.Alpha8;
		keys[8]=KeyCode.Alpha9;

	}
	void OnMouseDown() {
		if(!celda.get_set_Salio){
			print("click");
			active=true;
		}
	}
	void Update(){
		
		if(active){
			if(!celda.get_set_Salio){
				celda.Resaltar();
			}
			for(int i=0;i<9;i++){		
				if(Input.GetKeyDown(keys[i])){
					switch(keys[i]){
					case KeyCode.Alpha1:
						if(celda.getStateInput){
							spawnNumeroCelda.SpriteSpawn(i+1);
						}else{
							
							spawnAux.SpriteSpawn(i+1);

						}

						print("click numero 1");

						i=9;//salis del aray
					break;
					case KeyCode.Alpha2:
						
						print("click numero 2");
						if(celda.getStateInput){
							spawnNumeroCelda.SpriteSpawn(i+1);
						}else{
							spawnAux.SpriteSpawn(i+1);

						}

						i=9;//salis del aray
						break;
					case KeyCode.Alpha3:
						
						print("click numero 3");
						if(celda.getStateInput){
							spawnNumeroCelda.SpriteSpawn(i+1);
						}else{
							spawnAux.SpriteSpawn(i+1);

						}
						i=9;//salis del aray
						break;
					case KeyCode.Alpha4:
						print("click numero 4");
						if(celda.getStateInput){
							spawnNumeroCelda.SpriteSpawn(i+1);
						}else{
							spawnAux.SpriteSpawn(i+1);

						}
						i=9;//salis del aray
						break;
					case KeyCode.Alpha5:
						if(celda.getStateInput){
							spawnNumeroCelda.SpriteSpawn(i+1);
						}else{
							spawnAux.SpriteSpawn(i+1);

						}
						print("click numero 5");
						i=9;//salis del aray
						break;
					case KeyCode.Alpha6:
						if(celda.getStateInput){
							spawnNumeroCelda.SpriteSpawn(i+1);
						}else{
							spawnAux.SpriteSpawn(i+1);

						}
						print("click numero 6");
						i=9;//salis del aray
						break;
					case KeyCode.Alpha7:
						print("click numero 7");
						if(celda.getStateInput){
							spawnNumeroCelda.SpriteSpawn(i+1);
						}else{
							spawnAux.SpriteSpawn(i+1);

						}
						i=9;//salis del aray
						break;
					case KeyCode.Alpha8:
						print("click numero 8");
						if(celda.getStateInput){
							spawnNumeroCelda.SpriteSpawn(i+1);
						}else{
							spawnAux.SpriteSpawn(i+1);

						}
						i=9;//salis del aray
						break;
					case KeyCode.Alpha9:
						print("click numero 9");
						if(celda.getStateInput){
							spawnNumeroCelda.SpriteSpawn(i+1);
						}else{
							spawnAux.SpriteSpawn(i+1);

						}
						i=9;//salis del aray
						break;
										
					}
				}

			}

		}
	}
	public bool getActive{
		get{
			return active;
		}
		set{
			active=value;
		}
	}
}
