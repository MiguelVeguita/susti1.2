using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bolathena : dañodearmas
{
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
        if(collision.TryGetComponent(out lorienemigo vida))
        {
            vida.dañorecibido(daño);
            Destroy(gameObject);
        }
        if (collision.TryGetComponent(out athenaenemiga vidaa))
        {
            vidaa.dañorecibido(daño);
            Destroy(gameObject);
        }
        if (collision.TryGetComponent(out enemigos vidaaa))
        {
            vidaaa.dañorecibido(daño);
            Destroy(gameObject);
        }
        if (collision.TryGetComponent(out basealiada aa))
        {
            aa.dañorecibido(daño);
            Destroy(gameObject);
        }
    }
}
