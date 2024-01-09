using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawenemigos : MonoBehaviour
{
    public GameObject lorienemigo, athenaenemigo, soldadoenemigo, francoenemigo;
    public float l, a, s, f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        l = l + Time.deltaTime;
        a = a + Time.deltaTime;
        s = s + Time.deltaTime;
        f = f + Time.deltaTime;

        if (l>=10)
        {
            crearlorien();
        }
        if (a >= 20)
        {
            Instantiate(athenaenemigo, this.transform.position, transform.rotation);
            a = a - 20;
        }
        if (s >= 11)
        {
            Instantiate(soldadoenemigo, this.transform.position, transform.rotation);
            s = s - 11;
        }
        if (f >= 50)
        {
            Instantiate(francoenemigo, this.transform.position, transform.rotation);
            f = f - 50;
        }
    }
    public void crearlorien()
    {
        l = l - 10;
        Instantiate(lorienemigo, this.transform.position, transform.rotation);
       
    }
    




}
