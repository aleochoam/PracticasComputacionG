using UnityEngine;
using System.Collections;

public class MasterController : MonoBehaviour {

    public static MasterController current;

    public GameObject panel;

    // Use this for initialization
    void Start () {
        MasterController.current = this;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void AbrirPanel()
    {

        panel.SetActive(true);
    }

    public void cerrar()
    {
        panel.SetActive(false);
    }
}
