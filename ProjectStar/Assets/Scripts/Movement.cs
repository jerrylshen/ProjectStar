using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    public float speed = .5f;

	// Use this for initialization
	void Start () {
        
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = new Vector2(speed * Time.deltaTime + transform.position.x, transform.position.y);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        }

    }
}
