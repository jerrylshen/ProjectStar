using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Shop : MonoBehaviour {

    private Text interactText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

    private void OnTriggerStay2D(Collider2D collision)
    {
        // Camera zooms in on player and merchant (not done)
        if (Input.GetKeyDown(KeyCode.E))
        {
            collision.gameObject.transform.GetChild(0).GetComponent<Camera>().orthographicSize -= .5f;
            
        }
    }
}
