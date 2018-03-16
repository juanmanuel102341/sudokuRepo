using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuadritoManager : MonoBehaviour {

	private GameObject[,] cuadritos=new GameObject[9,9];
	private int[,]contadorNumeros=new int[9,9];
	private int [,]contadorCeldasVacias=new int[9,1];
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
		//Calc3();
		//Control();
		//Imprimir();
	}
	public void Imprimir(){
		print("******************************imprimir***************************");
		for(int i=0;i<9;i++){
			print(i+1 +"**********************cuadradito*******************************");
				for(int i3=0;i3<9;i3++){
				//print("numero) "+cuadritos[i,i3].GetComponent<Celda>().getNumero);
			//	print("salio "+cuadritos[i,i3].GetComponent<Celda>().get_set_Salio);
				if(i==0){
					for(int i4=0;i4<9;i4++){
						if (!cuadritos[i,i3].GetComponent<Celda>().get_set_Salio){
							//print("celda "+cuadritos[i,i3].name);
							//print("array "+i4+ " "+cuadritos[i,i3].GetComponent<Celda>().getMyArraysBooleanos[i4])	;
					//		print("celda "+cuadritos[i,i3].name);
					//		print("num "+i4+"cantidad de numeros "+contadorNumeros[i,i4]);
						}	
					

					}
				}
			}

		}
	}
	public void Calc3(){
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
	public void Control(){
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
//	public GameObject[,]getCuadritos{
//		get{
//			return cuadritos;
//		}
//	}


	public void RegistrandoConteo(int _cuadrito,int num){

		switch(num){
		case 0:
			contadorNumeros[_cuadrito,num]+=1;
			break;
		case 1:
			contadorNumeros[_cuadrito,num]+=1;
			break;
		case 2:
			contadorNumeros[_cuadrito,num]+=1;
			break;
		case 3:
			contadorNumeros[_cuadrito,num]+=1;
			break;
		case 4:
			contadorNumeros[_cuadrito,num]+=1;
			break;
		case 5:
			contadorNumeros[_cuadrito,num]+=1;
			break;
		case 6:
			contadorNumeros[_cuadrito,num]+=1;
			break;
		case 7:
			contadorNumeros[_cuadrito,num]+=1;
			break;
		case 8:
			contadorNumeros[_cuadrito,num]+=1;
			break;
		


		}

	}
	private void ResetConteoContador(){
		for(int i=0;i<9;i++){
			for(int i2=0;i2<9;i2++){
				contadorNumeros[i,i2]=0;
			}
		} 
	}
	private void ResetConteoCeldasVacias(){
		for(int i=0;i<9;i++){
			contadorCeldasVacias[i,0]=0;	
		} 
	}
	public void RegistroNumerosConteo(){
		ResetConteoContador();
		ResetConteoCeldasVacias();
		for(int i=0;i<9;i++){

			for(int i2=0;i2<9;i2++){
				Celda celda=cuadritos[i,i2].GetComponent<Celda>();
				if(!celda.get_set_Salio){
					print("cuadrito "+i+1);
					print("celda vacia chequeando conteo "+celda.name);
					for(int i3=0;i3<9;i3++){
						//conteo celda individual de los booleanos
						if(celda.getMyArraysBooleanos[i3]){
							//si la celda vacia tiene dentro de su array alguno q es verdadero
							RegistrandoConteo(i,i3);
							print("num "+i3+"registrando conteo "+contadorNumeros[i,i3]);
						}						
					}
					contadorCeldasVacias[i,0]+=1;
				}
			}
		}
		ControlNumerosConteo();
	}
	public void ControlNumerosConteo(){
		for(int i=0;i<9;i++){
			for(int i2=0;i2<9;i2++){
				
				if(contadorNumeros[i,i2]==contadorCeldasVacias[i,0]-1){
					print("positivo!!!!!!!!!!!!!!!!!1 ");
					for(int i3=0;i3<9;i3++){
						Celda celda=cuadritos[i,i3].GetComponent<Celda>();
						if(!celda.get_set_Salio){

							if(celda.getMyArraysBooleanos[i2]==false){
								print("cambiando valor!!!!!!!!!!!!!!!!!");
								celda.get_set_Salio=true;
								celda.getNumero=i2+1;
								celda.SpriteSpawn(i2+1);
							}
						}
					}
				}	
			}
		}
	}
	public void Busqueda(){
		for(int i=0;i<9;i++){
			for(int i2=0;i2<9;i2++){
				Celda celda=cuadritos[i,i2].GetComponent<Celda>();
				if(!celda.get_set_Salio){
					if(celda.BooleanosCompleto()){
						int n=celda.SetNumero();
						celda.get_set_Salio=true;
						celda.getNumero=i2+1;
						celda.SpriteSpawn(i2+1);
						print("cuadrito "+i);
						print("CELDA "+celda.name);
						print("numero encontrado BUSQUEDA!!!!!!!! "+n);
					
					}
				}
			}
		}
	}

	public GameObject[,]getCuadritos{
		get{
			return cuadritos;
		}
	}
	}

