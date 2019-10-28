using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCreator : MonoBehaviour
{     //instatiate a gameObject for reference of the bullet
    //Must be public
    public GameObject bullet;
    //impulse variable
    float thrust = 5.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Fire when f key pressed
       // if (Input.GetKeyDown(KeyCode.F))
       if(Input.GetMouseButtonDown(0))
        {
            // The position of this gameobject to which this script is attached
            GameObject projectil = Instantiate(bullet, transform.position, Quaternion.identity);

            // Give an impulse force to the bullet          
            // only gun version: transform.forward
            projectil.GetComponent<Rigidbody>().AddForce(-transform.right * thrust, ForceMode.Impulse);

            // Destroy the projectile after 5 seconds
            Destroy(projectil, thrust);

        }
    }
}
