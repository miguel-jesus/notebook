using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SensorStatue : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject statue;
    private void Start()
    {
        statue = GameObject.Find("Durga_Free_Standing");
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "FPSController")
        {
            
            statue.transform.Rotate(00,00,20);
        }
       
    }
}
