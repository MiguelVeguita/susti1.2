using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bolathena : da�odearmas
{
    void Start()
    {
        da�o = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out lorienemigo vida))
        {
            vida.da�orecibido(da�o);
            Destroy(gameObject);
        }
        if (collision.TryGetComponent(out athenaenemiga vidaa))
        {
            vidaa.da�orecibido(da�o);
            Destroy(gameObject);
        }
        if (collision.TryGetComponent(out enemigos vidaaa))
        {
            vidaaa.da�orecibido(da�o);
            Destroy(gameObject);
        }
        if (collision.TryGetComponent(out basealiada aa))
        {
            aa.da�orecibido(da�o);
            Destroy(gameObject);
        }
    }
}
