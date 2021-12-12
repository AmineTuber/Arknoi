using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouvement : MonoBehaviour
{
    public float speed = 120;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float a = Input.GetAxis("Horizontal");

        GetComponent<Rigidbody2D>().velocity = Vector2.right * a * speed;
    }
}
