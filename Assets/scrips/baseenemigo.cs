using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class baseenemigo : MonoBehaviour
{
    public int vida,da�o;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void da�orecibido(int da�o)
    {
        vida = vida - da�o;
        if (vida <= 0)
        {
            SceneManager.LoadScene("victoria");


        }
    }
}
