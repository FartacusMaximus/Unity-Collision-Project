using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{

    public Rigidbody2D rBody;

    //Move position sätter pos till annan pos
    // Move Rotation sätter rot till annan rot
    //velocity sätter hastighet
    //angular velocity snurr hastighet
    //Add  torqe snurrar saker
    //Add force puttar saker med kraft i en rikting på skärmen 
    //Add relative force puttar saker med kraft i en riktning relativt till sig själv
    // Use this for initialization
    void Start()
    {
        //rBody.AddForce(new Vector2(0, 20f), ForceMode2D.Impulse);
    }
    //fixed update är update fast 50x per sec
    //instant kraft någon annanstans där den ska göra med forcemode.impulse
    //fysik stuff goes here
    //konstant kraft fixed update
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("CollisionTest");
        }
        if (Input.GetKey(KeyCode.D))
        {
            rBody.AddForce(new Vector2(10f, 0f));
        }
        if (Input.GetKey(KeyCode.A))
        {
            rBody.AddForce(new Vector2(-10f, 0f));
        }
        if (Input.GetKey(KeyCode.W))
        {
            rBody.AddForce(new Vector2(0f, 10f));
        }
        if (Input.GetKey(KeyCode.S))
        {
            rBody.AddForce(new Vector2(0f, -10f));
        }
        //if (Input.GetKey(KeyCode.S) == false)
        //{
        //    rBody.AddForce(new Vector2(0f, 10f));
        //}
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        print("You've'ad Diededed");
        SceneManager.LoadScene("CollisionTest");
    }

}
//lööööööps Bröther änd fränder