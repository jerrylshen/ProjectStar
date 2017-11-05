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
            transform.position = new Vector3(speed * Time.deltaTime + transform.position.x, transform.position.y, transform.position.z);
            GetComponent<Animator>().SetBool("walkingRight", true);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            GetComponent<Animator>().SetBool("walkingRight", false);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, transform.position.z);
            GetComponent<Animator>().SetBool("walkingLeft", true);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            GetComponent<Animator>().SetBool("walkingLeft", false);
        }

    }
}
