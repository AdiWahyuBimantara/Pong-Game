using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    // Start is called before the first frame update
    
    public int speed = 30;

    public Rigidbody2D ball;
    
    // Start is called before the first frame update
    void Start()
    {
        ball.velocity = new Vector2(-1,-1)*speed;
    }
    void FixedUpdate()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
    	if(other.collider.name == "WallKanan" || other.collider.name == "WallKiri"){
    		GetComponent<Transform>().position = new Vector2(0,0);
    	}

    	
    }
}
