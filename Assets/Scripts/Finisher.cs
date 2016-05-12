using UnityEngine;
using System.Collections;

public class Finisher : MonoBehaviour {


	void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.name == "Bandera"){
            Debug.Log("Ha ganado el juego");
            MasterController.current.AbrirPanel();
        }
        //Debug.Log("Se ha colisionado con " + col.gameObject.name);
    }
}
