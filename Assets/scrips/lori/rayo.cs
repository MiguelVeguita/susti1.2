using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayo : MonoBehaviour
{
    public float nn;
   
    // Start is called before the first frame update
    void Start()
    {
       
        nn = 0;
    }

    // Update is called once per frame
    void Update()
    {
          nn = nn + Time.deltaTime;
        
        if (nn >= 0.8)
        {
            Destroy(gameObject);
        }
    }
    
}
