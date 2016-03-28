using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

    public float damege = 0;
    public float timeToFire = 0;
    public float fireRate = 0;

    public LayerMask toHit;
    public Transform Bala;
   
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
        //Shoot(100);
        if (fireRate == 0){
            if (Input.GetKeyDown(KeyCode.Space)){
                float fuerza = 0;
                /*while (Input.GetKeyDown(KeyCode.Space)) {
                    fuerza+=10;

                }*/
                Shoot(100);
            }
        }
	}

    void Shoot(float fuerza){
        Vector2 posicionBase = BaseCanon.position;
        RaycastHit2D hit = Physics2D.Raycast(PuntoDisparo.position, PuntoDisparo.position - BaseCanon.position, fuerza, toHit);
        Effect();
        Debug.DrawLine(posicionBase, (PuntoDisparo.position - BaseCanon.position) *100 , Color.cyan );
        if (hit.collider != null){
            Debug.DrawLine(PuntoDisparo.position, hit.point, Color.red);
        }
    }

    void Effect(){
        GameObject shot = Instantiate(Bala, PuntoDisparo.position, PuntoDisparo.rotation) as GameObject;
        //shot.AddForce(new Vector3(10,0,0));
        shot.transform.localScale += new Vector3(2, 2, 2);

    }
}
