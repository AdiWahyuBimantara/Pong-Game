﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    // Start is called before the first frame update
    
    public int speed = 30;

    public Rigidbody2D ball;

    public Animator animtr;
    
    // Start is called before the first frame update
    void Start()
    {
        ball.velocity = new Vector2(-1,-1)*speed;
        animtr.SetBool("IsMove", true);
    }
    void FixedUpdate()
    {
        if(ball.velocity.x > 0){ //bola bergerak ke kanan
            ball.GetComponent<Transform>().localScale = new Vector3(1,1,1);
        }else{
            ball.GetComponent<Transform>().localScale = new Vector3(-1,1,1);
            }
    }

    void OnCollisionEnter2D(Collision2D other) {
    	if(other.collider.name == "WallKanan" || other.collider.name == "WallKiri"){
    		StartCoroutine(jeda());
    		
    	}

    	
    }

    IEnumerator jeda(){
        ball.velocity = Vector2.zero;
        animtr.SetBool("IsMove", false);
        ball.GetComponent<Transform>().position = Vector2.zero;
        yield return new WaitForSeconds(1); 
        ball.velocity = new Vector2(-1,-1)*speed;
        animtr.SetBool("IsMove", true);
    }
}
