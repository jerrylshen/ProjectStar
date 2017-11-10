using UnityEngine;
using System.Collections;

public class combatManager : MonoBehaviour {

    public Camera cam;
    public GameObject player;
    public float xOffset = -2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void enterCombat(GameObject gmObj)
    {
        lockCamera(gmObj);
        player.GetComponent<Movement>().canMove = false;
        player.GetComponent<Movement>().setIdleAnimation();
    }

    void lockCamera(GameObject enemy)
    {
        Debug.Log("Distance: " + Vector2.Distance(player.transform.position, enemy.transform.position));
        cam.transform.position = new Vector3(Vector2.Distance(player.transform.position, enemy.transform.position) / 2 + player.transform.position.x, 
            cam.transform.position.y, cam.transform.position.z);
    }
}
