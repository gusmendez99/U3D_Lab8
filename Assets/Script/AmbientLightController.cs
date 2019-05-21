using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientLightController : MonoBehaviour
{
    // Start is called before the first frame update
    public Light light1;

    public float minTime = 2f;
    public float maxTime = 3.2f;

    private float timer;

    void Start()
    {

        light1 = GetComponent<Light>();
        timer = Random.Range(minTime, maxTime);
        if(light1 != null)
        {
            light1.enabled = false;
        }


    }


    void OnTriggerStay (Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                light1.enabled = !light1.enabled;

            }
        }
        

    }

    private void OnTriggerExit(Collider other)
    {
        light1.enabled = false;
    }
}
