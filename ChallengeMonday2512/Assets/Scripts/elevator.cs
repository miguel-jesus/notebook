using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class elevator : MonoBehaviour
{
    [SerializeField]
    private Canvas sakilaCanvas;

    private float speed =0.5f;
    private bool up = false;
    private bool down = false;
    void Start(){ }
    
     
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "FPSController")
        {
            up = true;
        }
       
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "FPSController")
        {
            up = false;
        }
    }
   
    public void retunGame()
    {
        Time.timeScale = 1;
        GameObject.Find("FPSController").GetComponent<FirstPersonController>().enabled = true;
        
        Cursor.visible = false;
        GameObject.Find("BulletCreator").GetComponent<BulletCreator>().enabled = true;
        sakilaCanvas.enabled = false;
    }
    void Update() 
        {
        if (up == true){

            if( transform.position.y < 3.63f){

            transform.Translate(Vector3.up * speed * Time.deltaTime);
                
            }
           
            if(transform.position.y >= 3.63f && Input.GetKeyDown(KeyCode.K)){
                sakilaCanvas.enabled =true;

                Debug.Log(sakilaCanvas);
                Time.timeScale = 0;
                GameObject.Find("FPSController").GetComponent<FirstPersonController>().enabled = false;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                GameObject.Find("BulletCreator").GetComponent<BulletCreator>().enabled = false;
               
            }
           
        }
        if(up == false)
        {
            if (transform.position.y > 0.63f)
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime);
            }
        }

        





    }
    
}
