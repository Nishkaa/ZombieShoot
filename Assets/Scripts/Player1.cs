using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player1 : MonoBehaviour
{
    public float jumpHeight = 10f;
    public bool isGrounded = false;
    
    public int maxHealth = 100;
    public int currentHealth;

    Animator myAnimator;
    const string PRESS_ANIM = "Press";

    public Healthbar healthbar;
    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
    }
  
    // Update is called once per frame
    void Update()
    {
        TouchMove();
    }
  public void TakeDamage(int damage)
    {
        currentHealth -= damage;
  
    }
    public void TouchMove()
    {
        if (Input.touchCount >0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition  = Camera.main.ScreenToWorldPoint(touch.position);
             if (touchPosition.x < -1)
            {
                //left
                Jump();
                
            }
            else if (touchPosition.x > 1)
            {
                //right
               // Jump();
            }
        }
    }
    public void Jump()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && isGrounded == true)
        {
            myAnimator.SetTrigger(PRESS_ANIM);
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpHeight), ForceMode2D.Impulse);
        }
    }
}
  

