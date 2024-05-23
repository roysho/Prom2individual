using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    [SerializeField] int life;



    public void CambioVida(int value)
    {

        life = life + value;

        if (life <= 0)
        {
            Destroy(gameObject);
        }

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("BulletBlanca"))
        {
            Destroy(collision.gameObject);
            CambioVida(-1);
        }
    }







    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
