using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
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
       
        rb.velocity = direction.normalized * speed;

    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();

    }







    // Start is called before the first frame update
    void Start()
    {
        direction = Vector2.down;
    }

   
}
