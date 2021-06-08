using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheckPlayerTwo : MonoBehaviour
{
    GameObject Player2;

    // Start is called before the first frame update
    void Start()
    {
        Player2 = gameObject.transform.parent.gameObject;

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            Player2.GetComponent<Player2>().isGroundedPlayerTwo = true;
            Debug.Log("Colliding Player2");

        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            Player2.GetComponent<Player2>().isGroundedPlayerTwo = false;
            Debug.Log("Grounded Player 2");
        }
    }
}
