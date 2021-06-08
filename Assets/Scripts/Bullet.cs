using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public Player1 Player1;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void onTriggerEnter2D(Collider2D hitInfo)
    {
            if (hitInfo.transform.name == "Player2")
              {
             Destroy(gameObject);
                }
     if (hitInfo.transform.name == "Player")
        {
            Debug.Log(hitInfo.name);
            Destroy(gameObject);
       }
    }
}
