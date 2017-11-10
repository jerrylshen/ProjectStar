using UnityEngine;
using System.Collections;

public class combatManager : MonoBehaviour {

    public Camera cam;
    public GameObject player;
    public float xOffset = -2;
    private bool lockCameraBool = false;
    private GameObject e;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (lockCameraBool)
        {
            Vector2 desiredPos = new Vector3(Vector2.Distance(player.transform.position, e.transform.position) / 2 + player.transform.position.x,
            cam.transform.position.y, cam.transform.position.z);
            Vector3 smoothPos = Vector3.Lerp(cam.transform.position, desiredPos, Time.deltaTime);
            cam.transform.position = new Vector3(smoothPos.x, cam.transform.position.y, cam.transform.position.z);
        }
	}

    public void enterCombat(GameObject gmObj)
    {
        lockCamera(gmObj);
        player.GetComponent<Movement>().canMove = false;
        player.GetComponent<Movement>().setIdleAnimation();
    }

    void lockCamera(GameObject enemy)
    {
        lockCameraBool = true;
        e = enemy;
    }
}
