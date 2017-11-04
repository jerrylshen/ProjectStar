using UnityEngine;
using System.Collections;

public class cameraMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
        transform.position = new Vector3(transform.parent.transform.position.x,
            transform.parent.transform.position.y, -2);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
