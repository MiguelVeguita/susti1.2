using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class lorienemigo : MonoBehaviour
{
    public int vida,daño,velocidad,stop;

    public Transform controldisparo;

    public float distancialinea,veli;

    public LayerMask enemilayer;

    public bool enemyrango;

    private Animator ann;

    public GameObject rayito;
    public GameObject cubo;
    private Rigidbody2D rig;

    public float tienpodeespera;

    public float tiempoentredisparo, tiempodeultimodisparo;
    private void Awake()
    {
        ann = GetComponent<Animator>();
        rig = GetComponent<Rigidbody2D>();
        veli = 1;
    }

    void Update()
    {
        
        enemyrango = Physics2D.Raycast(controldisparo.position, transform.right, distancialinea, enemilayer);

        if (enemyrango == true)
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
        rig.velocity= new Vector2((velocidad*stop)*veli, rig.velocity.y);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(controldisparo.position, controldisparo.position + transform.right * distancialinea);


    }
    public void ata()
    {
        Instantiate(rayito, controldisparo.position, controldisparo.rotation);
        Instantiate(cubo, controldisparo.position, controldisparo.rotation);
    }
    public void dañorecibido(int daño)
    {
        vida = vida - daño;
        if (vida <= 0)
        {
            Destroy(gameObject);

        }
    }
    public void dañorecibido(int daño, float vel)
    {
        veli = vel;
        vida = vida - daño;
        if (vida <= 0)
        {
            Destroy(gameObject);

        }
    }
}
