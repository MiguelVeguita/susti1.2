using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class lori : statidicasglobales
{
    public int stop;

    public Transform controldisparo;

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
        vida = 14;
        velocidad = 3;
        daño = 0;
        distancialinea = 0.5f;
        ann = GetComponent<Animator>();
        rig = GetComponent<Rigidbody2D>();
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
        rig.velocity= new Vector2(velocidad*stop, rig.velocity.y);
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
  
}
