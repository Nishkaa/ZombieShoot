using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float jumpHeightPlayer2 = 10f;
    public bool isGroundedPlayerTwo = false;
    public int maxHealthPlayer2 = 100;
    public int currentHealthPlayer2;

    Animator myAnimator2;
    const string PRESS_ANIM2 = "Press2";

    public Healthbar healthbarPlayer2;
    
    // Start is called before the first frame update
    void Start()
    {
        myAnimator2 = GetComponent<Animator>();
        currentHealthPlayer2 = maxHealthPlayer2;
        healthbarPlayer2.SetMaxHealth(maxHealthPlayer2);
    }

    // Update is called once per frame
    void Update()
    {
        PlayerTwoTouchMove();
    }

    public void TakeDamagePlayer2(int damage)
    {
        currentHealthPlayer2 -= damage;
    }

    public void PlayerTwoTouchMove()
    {
        if (Input.touchCount > 0)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

           if (mousePos.x > 1)
            {
                //right
                PlayerTwoJump();
            }
        }
    }

    public void PlayerTwoJump()
    {
        if (Input.touchCount > 0  && isGroundedPlayerTwo == true)
        {
            myAnimator2.SetTrigger(PRESS_ANIM2);
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpHeightPlayer2), ForceMode2D.Impulse);
        }
    }
}