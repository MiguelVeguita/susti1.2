using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubolorienemigo : dañodearmas
{
   
   
    void Start()
    {
        daño = 3;
    }

    
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out lori vida))
        {
            vida.dañorecibido(daño);
            Destroy(gameObject);
        }
        if (collision.TryGetComponent(out athena a))
        {
            a.dañorecibido(daño);
            Destroy(gameObject);
        }
        if (collision.TryGetComponent(out basealiada aa))
        {
            aa.dañorecibido(daño);
            Destroy(gameObject);
        }
    }
}
