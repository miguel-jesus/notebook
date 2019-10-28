using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveGun : MonoBehaviour
{
   //spedd of move and moveRotation
    float moveSpeed = 2;
    float moveRotate = 50;
   
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        // Edit->Project Settings->Input->Axes
        float hInput = Input.GetAxis("Horizontal");
        float hInput2 = Input.GetAxis("Vertical");
        Debug.Log(hInput);
        //time to move by meters / seconds per frame
        //vector is the axes
        transform.Translate(new Vector3(-hInput2, 0, hInput) * Time.deltaTime * moveSpeed);

        //  float yRotOffset = Random.Range(-90.0f, 90.0f);
     
        //rotation gun
        //  transform.Rotate(new Vector3(0, yRotOffset, 0));
        
        // transform.Rotate(new Vector3(0, 0, hInput)* Time.deltaTime * moveRotate);

    }
}
