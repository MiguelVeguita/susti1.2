using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bolathenaenemiga : da�odearmas
{
   
    // Start is called before the first frame update
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
        if(collision.TryGetComponent(out athena vida))
        {
            vida.da�orecibido(da�o);
            Destroy(gameObject);
        }
        if (collision.TryGetComponent(out lori vidaa))
        {
            vidaa.da�orecibido(da�o);
            Destroy(gameObject);
        }
        if (collision.TryGetComponent(out basealiada a))
        {
            a.da�orecibido(da�o);
            Destroy(gameObject);
        }
    }
}
