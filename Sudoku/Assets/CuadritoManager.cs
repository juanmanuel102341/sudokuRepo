using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuadritoManager : MonoBehaviour {

	GameObject[,] cuadritos=new GameObject[9,9];
	private Manager manager;
	void Awake () {
		manager=GetComponent<Manager>();
	}
	void Start(){
//		for(int i=0;i<manager.getCeldas.Length;i++){
//			print("tipos "+manager.getCeldas[i].name);	
//		}
		//Calc3();

	//	Imprimir();
	//	calc2(0,3,0,3);
		Calc3();
		Control();
		Imprimir();
	}
	void SetInitial(){
		
	}
	// Update is called once per frame
	void Update () {
		
	}
	void Imprimir(){
		print("******************************imprimir***************************");
		for(int i=0;i<9;i++){
			print(i+1 +"**********************cuadradito*******************************");
				for(int i3=0;i3<9;i3++){
				//print("numero) "+cuadritos[i,i3].GetComponent<Celda>().getNumero);
			//	print("salio "+cuadritos[i,i3].GetComponent<Celda>().get_set_Salio);
				if(i==0){
					for(int i4=0;i4<9;i4++){
						if (!cuadritos[i,i3].GetComponent<Celda>().get_set_Salio){
							print("celda "+cuadritos[i,i3].name);
							print("array "+i4+1+ " "+cuadritos[i,i3].GetComponent<Celda>().getMyArraysBooleanos[i4])	;
						}	
					}


				}
			}

		}
	}
	void Calc3(){
		int inicioFila=0;
		int finFila=3;
		int inicioColumna=0;
		int finColumna=3;
		int contador=0;//cuenta ciclos, utilizado para el indice del array multi
		for(int ifila=0;ifila<3;ifila++){
			inicioColumna=0;//reseteo valores de inicio
			finColumna=3;//idem columna
			//print("cuadradito "+inicioFila);
			for(int icolumna=0;icolumna<3;icolumna++){
				calc2(inicioFila,finFila,inicioColumna,finColumna,contador);//confeccion de un cuadradito
				inicioColumna+=3;//aumento 3 lugares a la derecho inicio
				finColumna+=3;//aumento 3 lugares a la derecha fin
				contador++;//aumento contador 
			}
			//completa 1er filas de cuadraditos
			inicioFila+=3;//aumento un piso inicio
			finFila+=3;//aumento techo
		}
		inicioFila+=3;
		finFila+=3;
	}
	void calc2(int _inicioFila,int _finFila,int _inicioColumna,int _finColumna,int contador){
		int indexColumna=0;
		for(int if1=_inicioFila;if1<_finFila;if1++){
		//	print("inicio fila "+if1);
		//	print("fila "+manager.getCeldas[if1].name);
		
			for(int ic1=_inicioColumna;ic1<_finColumna;ic1++)
			{
		//		print("index "+ic1);
				GameObject obj=manager.getCeldas[if1].transform.GetChild(ic1).gameObject;
				//print(" numero "+manager.getCeldas[if1].gameObject.transform.GetChild(ic1).gameObject.GetComponent<Celda>().getNumero);
				cuadritos[contador,indexColumna]=obj;
		//		print("obj "+obj.GetComponent<Celda>().getNumero);
				indexColumna++;
			}
		//	print("fin fila cuadradito");

			//indexColumna=0;
		}
	}
	void Control(){
		//setea booleanos adyacentes de celadas vacias
		for(int i1=0;i1<9;i1++){
			for(int i2=0;i2<9;i2++){
				Celda auxCeldaNumero=cuadritos[i1,i2].GetComponent<Celda>();
				if(auxCeldaNumero.get_set_Salio){
				//celda con numero
					for(int i3=0;i3<9;i3++){
						Celda auxCeldaVacia=cuadritos[i1,i3].GetComponent<Celda>();
						if(!auxCeldaVacia.get_set_Salio){
							//seteo el booleano de la celda vacia
							auxCeldaVacia.SetArrayBoleano(auxCeldaNumero.getNumero-1);//le paso en indice para q ponga true el array d numeros
						}
					}	
				}		
			
			}
		}


	}





	}

