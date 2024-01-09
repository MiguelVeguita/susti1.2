using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class basealiada : MonoBehaviour
{
    public int vida,daño;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void dañorecibido(int daño)
    {
        vida = vida - daño;
        if (vida <= 0)
        {
            SceneManager.LoadScene("derrota");


        }
    }
}
