using UnityEngine;
using System.Collections;

public class changeScene : MonoBehaviour {

    private void Start()
    {
     
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("something has happened");
        if (collision.gameObject.CompareTag("Player"))
        {
            GetComponent<Animator>().SetBool("isPlayerNearby", true);
            gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        GetComponent<Animator>().SetBool("isPlayerNearby", false);
    }

}
