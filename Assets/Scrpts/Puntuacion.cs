using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Puntuacion : MonoBehaviour {

	private int puntaje = 0;
	public Text marcador;
	public GameObject pantallaVictoria;

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter().AddObserver(this, "IncrementarPuntos");
		ActualizarMarcador();
		pantallaVictoria.gameObject.SetActive (false);
	}

	void IncrementarPuntos(Notification notificacion){
		int puntosAIncrementar = (int)notificacion.data;

		puntaje+=puntosAIncrementar;
		ActualizarMarcador();
	}

	void ActualizarMarcador(){
		marcador.text = puntaje.ToString();
	}

	void FixedUpdate () {
		if(puntaje >=800){
			pantallaVictoria.SetActive (true);
		} else{
			pantallaVictoria.SetActive (false);
		}
	}
			
}
