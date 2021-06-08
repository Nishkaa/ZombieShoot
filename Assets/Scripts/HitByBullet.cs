using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class HitByBullet : MonoBehaviour
{    // Start is called before the first frame update
    public GameObject UIObject;
    public GameObject Restart_Button;
    public Player1 Player1;
    public GameObject blood;
    float timeToLoadScene = 1;
    public GameObject Ragdoll;
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
            //Player takes 20 damage on impact
            Destroy(col.gameObject);
            Player1.TakeDamage(20);
           
           // Instantiate(blood, transform.position, Quaternion.identity);

            //Dying Hearts 
            Destroy(GameObject.FindWithTag("Heart"));

            Player1.healthbar.SetHealth(Player1.currentHealth);
            if (Player1.currentHealth <= 0)
            {

                Destroy(GameObject.FindWithTag("Player"));
                Destroy(GameObject.FindWithTag("HealthBar"));
                // SceneManager.LoadScene("Level01");
                UIObject.SetActive(true);
                Ragdoll.SetActive(true);
                Restart_Button.SetActive(true);
            }
            if (Player1.currentHealth == 0)
            {
                Destroy(GameObject.FindWithTag("Player"));
                Destroy(GameObject.FindWithTag("HealthBar"));
               // Application.LoadLevel(Application.loadedLevel);
            }
        }

    }
  
}