using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaMantul : MonoBehaviour
{
    // Start is called before the first frame update
	public int speed=20;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(2,2) * speed;
    }

    // Update is called once per frame
    void FixidUpdate()
    {
     	   
    }
}
