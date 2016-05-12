using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

    float deltaRotation = 30f;
    //float deltaMovement = 10f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Rotate();
	}

    void Rotate() {
        if (Input.GetKey(KeyCode.UpArrow)){
            transform.Rotate(new Vector3(0, 0, -deltaRotation) * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.DownArrow)){
            transform.Rotate(new Vector3(0, 0, +deltaRotation) * Time.deltaTime);
        }
        
    }
}
