using UnityEngine;
using System.Collections;

public class Lantern : MonoBehaviour {
    private float t = 0;


	// Use this for initialization
	void Start () {
	   
	}
	
	// Update is called once per frame
	void Update () {
        t += Time.deltaTime;

        if (t > .1f)
        {
            t = 0;
            GetComponent<Light>().intensity = Random.Range(.5f, 1f);
        }
     
	}
}
