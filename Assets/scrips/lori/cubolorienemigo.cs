using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubolorienemigo : da�odearmas
{
   
   
    void Start()
    {
        da�o = 3;
    }

    
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out lori vida))
        {
            vida.da�orecibido(da�o);
            Destroy(gameObject);
        }
        if (collision.TryGetComponent(out athena a))
        {
            a.da�orecibido(da�o);
            Destroy(gameObject);
        }
        if (collision.TryGetComponent(out basealiada aa))
        {
            aa.da�orecibido(da�o);
            Destroy(gameObject);
        }
    }
}
