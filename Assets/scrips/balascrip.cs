using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balascrip : da�odearmas
{
    public int direc;
    public float vel;
    // Start is called before the first frame update
    void Start()
    {
        da�o = 1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + direc * Time.deltaTime, transform.position.y, transform.position.z);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out athenaenemiga vida))
        {
            vida.da�orecibido(da�o,vel);
            Destroy(gameObject);
        }
        if (collision.TryGetComponent(out lorienemigo vidaa))
        {
            vidaa.da�orecibido(da�o,vel);
            Destroy(gameObject);
        }
        if (collision.TryGetComponent(out enemigos a))
        {
            a.da�orecibido(da�o,vel);
            Destroy(gameObject);
        }
        if (collision.TryGetComponent(out baseenemigo aa))
        {
            aa.da�orecibido(da�o);
            Destroy(gameObject);
        }

    }
}
