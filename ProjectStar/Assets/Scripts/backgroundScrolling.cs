using UnityEngine;
using System.Collections;

public class backgroundScrolling : MonoBehaviour {

    public float smoothspeed = 1f;
    public Transform cam;
    private Vector3 previousCamPos;
    private float parallaxNum = -50;

    private void Awake()
    {
        cam = Camera.main.transform;
    }

    private void Update()
    {
        float parallax = (previousCamPos.x - cam.position.x) * parallaxNum;
        float backgroundTargetPosX = transform.position.x + parallax;

        Vector3 backgroundTargetPos = new Vector3(backgroundTargetPosX, transform.position.y,
        transform.position.z);

        transform.position = Vector3.Lerp(transform.position, backgroundTargetPos, smoothspeed * Time.deltaTime);
        

        previousCamPos = cam.position;
    }
}
