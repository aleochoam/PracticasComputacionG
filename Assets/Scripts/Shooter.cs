using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

    public float damege = 0;
    public float timeToFire = 0;
    public float fireRate = 0;
    public float deltaTamano = 0.1f;

    public LayerMask toHit;
    public GameObject Bala;
   
    Transform PuntoDisparo;
    Transform BaseCanon;
    AudioSource audio;

	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
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
                //Shoot(1000);
                audio.Play();
                Effect(1000);
            }
        }
	}

    void Shoot(float fuerza){
        
        Vector2 posicionBase = BaseCanon.position;
        RaycastHit2D hit = Physics2D.Raycast(PuntoDisparo.position, PuntoDisparo.position - BaseCanon.position, fuerza, toHit);
        
        Debug.DrawLine(posicionBase, (PuntoDisparo.position - BaseCanon.position) *100 , Color.cyan );
        if (hit.collider != null){
            Debug.DrawLine(PuntoDisparo.position, hit.point, Color.red);
            Debug.Log("Se ha colizionado con" + hit.collider.name);
        }
        Effect(fuerza);
    }

    void Effect(float fuerza){
        GameObject shot = Instantiate(Bala, PuntoDisparo.position, PuntoDisparo.rotation) as GameObject;
        shot.GetComponent<Rigidbody2D>().AddForce(PuntoDisparo.right * -fuerza);
        shot.GetComponent<Rigidbody2D>().transform.localScale -= new Vector3(deltaTamano, deltaTamano, 0);
        deltaTamano -= 0.1f;
    }
}
