using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class athenaenemiga : MonoBehaviour
{
    public Transform controldisparo;
    public int vidaa, daño,stop;
    public float velocidad,veli;
    public float distancialinea;

    public LayerMask enemilayer;

    public bool enemyrango;

    private Animator ann;

    public GameObject bola;
    public float tienpodeespera;

    public float tiempoentredisparo, tiempodeultimodisparo;
    private Rigidbody2D rig;
    private void Awake()
    {
        ann = GetComponent<Animator>();
        rig = GetComponent<Rigidbody2D>();
        veli = 1;
    }

    void Update()
    {
        enemyrango = Physics2D.Raycast(controldisparo.position, transform.right, distancialinea, enemilayer);

        if (enemyrango==true)
        {
            if (Time.time > tiempoentredisparo + tiempodeultimodisparo)
            {
                tiempodeultimodisparo = Time.time;
                Invoke(nameof(ata), tienpodeespera);
                ann.SetBool("atac", true);
                stop = 0;
            }     
        }
        else
        {
            ann.SetBool("atac", false);
            stop = 1;
        }
      

    }
    private void FixedUpdate()
    {
        rig.velocity = new Vector2((velocidad * stop)*veli, rig.velocity.y);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(controldisparo.position, controldisparo.position + transform.right * distancialinea);


    }
    public void ata()
    {
        Instantiate(bola,controldisparo.position,controldisparo.rotation);
        
    }
    public void dañorecibido(int daño)
    {
        vidaa = vidaa - daño;
        if (vidaa <= 0)
        {
            Destroy(gameObject);

        }
    }
    public void dañorecibido(int daño, float vel)
    {
        veli = vel;
        vidaa = vidaa - daño;
        if (vidaa <= 0)
        {
            Destroy(gameObject);

        }
    }


}
