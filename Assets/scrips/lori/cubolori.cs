using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubolori : MonoBehaviour
{
    public int da�o;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out lorienemigo vida))
        {
            vida.da�orecibido(da�o);
            Destroy(gameObject);
        }
        if (collision.TryGetComponent(out enemigos vidaa))
        {
            vidaa.da�orecibido(da�o);
            Destroy(gameObject);
        }
        if (collision.TryGetComponent(out athenaenemiga a))
        {
            a.da�orecibido(da�o);
            Destroy(gameObject);
        }
        if (collision.TryGetComponent(out baseenemigo aa))
        {
            aa.da�orecibido(da�o);
            Destroy(gameObject);
        }

    }
}
