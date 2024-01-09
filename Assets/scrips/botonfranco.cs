using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class botonfranco : MonoBehaviour
{
    public GameObject franco,lori,athena,soldado,respaw;
    public Text recurs;
    public float numrecurs;
    public GameObject cubofranfo, cubolori, cuboayhena, cubosoldado,athe;
    // Start is called before the first frame update
    void Start()
    {
        numrecurs = 0;
    }

    // Update is called once per frame
    void Update()
    {
        numrecurs = numrecurs + Time.deltaTime;
        recurs.text = ":"+numrecurs.ToString("f0");
        if (numrecurs >= 2)
        {
            cubosoldado.SetActive(false);
            if (numrecurs >= 5)
            {
                athe.SetActive(false);
                
                if (numrecurs >= 8)
                {
                   
                    cubolori.SetActive(false);
                    if (numrecurs >= 15)
                    {
                        cubofranfo.SetActive(false);
                    }
                }
            }
        }
         if (numrecurs < 15)
        {
            cubofranfo.SetActive(true);
            
            if (numrecurs < 8)
            {
                cubolori.SetActive(true);

                if (numrecurs < 5)
                {
                    athe.SetActive(true);
                    if (numrecurs < 2)
                    {
                        cubosoldado.SetActive(true);
                    }
                }
            }
        }
    }
    public void crearfranco()
    {
        numrecurs = numrecurs - 15;
        Instantiate(franco, respaw.transform.position,transform.rotation);
       
    }
    public void crearathena()
    {
        numrecurs = numrecurs - 5;
        Instantiate(athena, respaw.transform.position, transform.rotation);
      
    }
    public void crearlori()
    {
        numrecurs = numrecurs - 8;
        Instantiate(lori, respaw.transform.position, transform.rotation);
        
    }
    public void crearsoldado()
    {
        numrecurs = numrecurs - 2;
        Instantiate(soldado, respaw.transform.position, transform.rotation);
        
    }
    


}
