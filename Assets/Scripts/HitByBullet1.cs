using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitByBullet1 : MonoBehaviour
{
    public Player2 Player2;
    public GameObject blood;
    public GameObject UIObject;
    public GameObject Restart_Button;
    public GameObject Ragdoll;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("bullet"))
        {
            
            Player2.TakeDamagePlayer2(20);
            Destroy(col.gameObject);

            //blood bullet prefab particle system
            Instantiate(blood, transform.position, Quaternion.identity);

            //heart destroying
            Destroy(GameObject.FindWithTag("Heart2"));

            Player2.healthbarPlayer2.SetHealth(Player2.currentHealthPlayer2);
            if (Player2.currentHealthPlayer2 <= 0)
            {
                Destroy(GameObject.FindWithTag("Player2"));
                Destroy(GameObject.FindWithTag("Healthbar2"));
                UIObject.SetActive(true);
                Ragdoll.SetActive(true);
                Restart_Button.SetActive(true);
                // Application.LoadLevel(Application.loadedLevel);
            }
        }
    }
}
