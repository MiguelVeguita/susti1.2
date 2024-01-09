using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bolathenaenemiga : dañodearmas
{
   
    // Start is called before the first frame update
    void Start()
    {
        daño = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out athena vida))
        {
            vida.dañorecibido(daño);
            Destroy(gameObject);
        }
        if (collision.TryGetComponent(out lori vidaa))
        {
            vidaa.dañorecibido(daño);
            Destroy(gameObject);
        }
        if (collision.TryGetComponent(out basealiada a))
        {
            a.dañorecibido(daño);
            Destroy(gameObject);
        }
    }
}
