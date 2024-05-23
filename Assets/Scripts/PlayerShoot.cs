using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    private Vector2 direction;
    private PlayerMovement playerMovement;
    private Rigidbody2D rb;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private GameObject bulletPrefab2;
    private float shootTimer;


    private void Awake()
    {
        rb  = GetComponent<Rigidbody2D>();
        playerMovement = GetComponent<PlayerMovement>();
    }


    void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject obj = Instantiate(bulletPrefab);
            obj.transform.position= transform.position;
            obj.GetComponent<BulletMovement>().SetDirection(direction);
            Destroy(obj, 5f);
        
        }
        else if (Input.GetMouseButtonDown(1))
        {
            GameObject obj = Instantiate(bulletPrefab2);
            obj.transform.position = transform.position;
            obj.GetComponent<BulletMovement>().SetDirection(direction);
            Destroy(obj, 5f);
        }



    }

    // Start is called before the first frame update
    void Start()
    {
        direction = Vector2.up;
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }
}
