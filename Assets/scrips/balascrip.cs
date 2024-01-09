using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balascrip : dañodearmas
{
    public int direc;
    public float vel;
    // Start is called before the first frame update
    void Start()
    {
        daño = 1;
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
            vida.dañorecibido(daño,vel);
            Destroy(gameObject);
        }
        if (collision.TryGetComponent(out lorienemigo vidaa))
        {
            vidaa.dañorecibido(daño,vel);
            Destroy(gameObject);
        }
        if (collision.TryGetComponent(out enemigos a))
        {
            a.dañorecibido(daño,vel);
            Destroy(gameObject);
        }
        if (collision.TryGetComponent(out baseenemigo aa))
        {
            aa.dañorecibido(daño);
            Destroy(gameObject);
        }

    }
}
