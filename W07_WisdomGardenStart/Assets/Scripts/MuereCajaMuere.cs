using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuereCajaMuere : MonoBehaviour
{
    // Start is called before the first frame update

    private GameObject gameManagerObject;
    private GameManager gameManager;
    private int contador = 0;
    private GameObject box;
    public Image health;
    private int vida = 100;
    public Text canvasText;
    



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Projectile(Clone)")
        {
            vida -= 20;
           
            health.rectTransform.localScale = new Vector2(health.rectTransform.localScale.x -1.5f, health.rectTransform.localScale.y);

            canvasText.text = vida + "/100";

            Debug.Log("me cago en la puTA");
            contador++;
            if (contador == 5)
            {
                gameManager.AddToScore(1);
                Destroy(gameObject);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        gameManagerObject = GameObject.Find("Game Manager");
        gameManager = gameManagerObject.GetComponent<GameManager>();
       
      
    }

    // Update is called once per frame
    void Update()
    {

    }
}
