using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class athena : statidicasglobales
{
    public Transform controldisparo;
    public int vidaa,stop;
    
    public float distancialineaa;

    public LayerMask enemilayer;

    public bool enemyrango;

    private Animator ann;

    public GameObject bola;
    public float tienpodeespera;

    public float tiempoentredisparo, tiempodeultimodisparo;
    private Rigidbody2D rig;
    

    
    private void Awake()
    {
        daño = 0;
        velocidad = 1.5f;
        ann = GetComponent<Animator>();
        rig = GetComponent<Rigidbody2D>();
       
       
    }
    private void Start()
    {
       
    }

    void Update()
    {
        enemyrango = Physics2D.Raycast(controldisparo.position, transform.right, distancialineaa, enemilayer);

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
        rig.velocity = new Vector2(velocidad * stop, rig.velocity.y);
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

   

}
