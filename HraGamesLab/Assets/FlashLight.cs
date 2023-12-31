using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour

{
    
    public GameObject flashLight;
    public AudioSource turnOn;
    public AudioSource turnOff;

    public bool on;
    public bool off;
    // Start is called before the first frame update
    void Start()
    {
        off = true;
        FlashLighth.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (off && Input.GetButtonDown("F"))
        {
            flashLight.SetActive(true);
            turnOn.Play();
            off = false;
            on = true;
        }
        else if (on && Input.GetButtonDown("F"))
        {
            flashLight.SetActive(false);
            turnOn.Play();
            off = true;
            on = false;
        }

    }
}

