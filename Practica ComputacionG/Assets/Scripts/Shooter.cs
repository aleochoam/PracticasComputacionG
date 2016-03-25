using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

    public float fireRate = 0;
    //public float damege = 0;
    public LayerMask toHit;

    float timeToFire = 0;
    Transform PuntoDisparo;
    Transform BaseCanon;

	// Use this for initialization
	void Start () {
        PuntoDisparo = transform.FindChild("PuntoDisparo");
        BaseCanon = transform.FindChild("BaseCanon");
        if (PuntoDisparo == null || BaseCanon == null){
            Debug.LogError("No esta bien hecho");
        }
	
	}
	
	// Update is called once per frame
	void Update () {
        //Shoot();
        if (fireRate == 0){
            if (Input.GetKeyDown(KeyCode.Space)){
                Shoot();
            }
        }
	}

    void Shoot(){
        Debug.Log("Disparo pum piu");
        Vector2 posicionBase = BaseCanon.position;
        RaycastHit2D hit = Physics2D.Raycast(PuntoDisparo.position, PuntoDisparo.position - BaseCanon.position, 100, toHit);
        Effect()
        Debug.DrawLine(posicionBase, (PuntoDisparo.position - BaseCanon.position) *100 , Color.cyan );
        if (hit.collider != null){
            Debug.DrawLine(PuntoDisparo.position, hit.point, Color.red);
        }
    }

    void Effect()
    {

    }
}
