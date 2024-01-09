using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class inicio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void nuevaparty()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void tutorial()
    {
        SceneManager.LoadScene("tutorial");
    }
}
