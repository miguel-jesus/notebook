using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bookCollision : MonoBehaviour
{
    //instatiate a gameObject for reference of the book
   
    public GameObject book;
    //Collision object
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        //when the book or clone do the collision with the plane ,this script will destroy de book or clone and will generate a clone
        if (collision.gameObject.name == "DruidTome" || collision.gameObject.name == "DruidTome(Clone)")
        {
            Destroy(collision.gameObject);
            GameObject projectile = Instantiate(book);
        }
    }
}
