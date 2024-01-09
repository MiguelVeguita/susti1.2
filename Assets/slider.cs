using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderrr : MonoBehaviour
{
    public Slider sliderr;
    public float slidervalue;


    // Start is called before the first frame update
    void Start()
    {
        sliderr.value = PlayerPrefs.GetFloat("volumenaudio", 0.5f);
        AudioListener.volume = sliderr.value;

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void sliderrrrr(float valor)
    {
        slidervalue = valor;
        PlayerPrefs.SetFloat("volumenaudio", slidervalue);
        AudioListener.volume = sliderr.value;

    }
}
