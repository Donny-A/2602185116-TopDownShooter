using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    private Rigidbody2D rb2d;
    [SerializeField, Range(1, 10)]  private float speed;



    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        //rb2d.velocity = new Vector2(1, 1);
    }

    private void Update()
    {
       //transform.position += new Vector3(1, 1, 0) * Time.deltaTime;
        
    }
    public void SetDirection(float x, float y)
    {
        rb2d.velocity = new Vector2(x, y) * speed;
    }
}

    

    



