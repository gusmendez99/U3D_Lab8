using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightController : MonoBehaviour

{
    bool flashlightState;
    AudioSource audioSource;
    public AudioClip flashlightStateSound;

    // Start is called before the first frame update
    void Start()
    {
        flashlightState = true;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))            
        {
            // show
            // renderer.enabled = true;
            Debug.Log("Pressed primary button.");
            flashlightState = !flashlightState;
            gameObject.GetComponent<Light>().enabled = flashlightState;
            if(audioSource != null && flashlightStateSound != null)
            {
                audioSource.PlayOneShot(flashlightStateSound);
            }
        }

        
    }
}
