using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float speed = 5f;

    private Rigidbody2D mybody;
    private Animator myanimator;

    
    void Awake()
    {
        mybody = GetComponent<Rigidbody2D>();
        myanimator = GetComponent<Animator>();
    }

   
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        PlayerWalk();
    }


    void PlayerWalk()
    {
        float h = Input.GetAxisRaw("Horizontal");

        if (h > 0)
        {
            myanimator.SetFloat("speed", h);
            mybody.velocity = new Vector2(speed, mybody.velocity.y);
        }
        else if (h < 0)
        {
            
            mybody.velocity = new Vector2(-speed, mybody.velocity.y);
            myanimator.SetFloat("speed", h*-1);
        }
        else
        {
            myanimator.SetFloat("speed", 0);
            mybody.velocity = new Vector2(0f, mybody.velocity.y);
        }


        float k = Input.GetAxisRaw("Vertical");

        if (k > 0)
        {
            mybody.velocity = new Vector2(mybody.velocity.x, speed);
        }
        else if (k < 0)
        {
            mybody.velocity = new Vector2(mybody.velocity.x, -speed);
        }
        else
        {
            mybody.velocity = new Vector2(mybody.velocity.x,0f);
        }
    }
}
