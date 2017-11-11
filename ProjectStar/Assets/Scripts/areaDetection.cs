using UnityEngine;
using System.Collections;

public class areaDetection : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log(transform.parent.transform.position);
            GetComponentInParent<combatManager>().enterCombat(transform.parent.gameObject);
            //GetComponent<combatManager>().enterCombat(transform.parent.gameObject);
        }
    }
}
