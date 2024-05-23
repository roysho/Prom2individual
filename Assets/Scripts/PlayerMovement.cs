using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float speed;
    private Vector2 direction;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    private void Movimiento()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        rb.velocity= new Vector2(horizontal, vertical).normalized*speed;
     
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
        
    }
}
