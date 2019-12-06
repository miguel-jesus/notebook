using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ChallengeMonday;


public class DropdownMenu : MonoBehaviour
{
    private DataAccessFilms dataAccess = new DataAccessFilms();
    public Dropdown select;
    public Text textField;
    public Toggle togleburron;
    List<string> listCategories = new List<string>();

    void Start()
    {
        select.options.Clear();
        togleburron.isOn = false;
        foreach (Category c in dataAccess.GetCategory())
        {
            listCategories.Add(c.Name);
        }
      //  Debug.Log(listCategories);
        select.AddOptions(listCategories);
        select.value = 1;
        select.value = 0;
       // Debug.Log(select.options[select.value].text);

       
    }
    public void changeFilm()
    {
        textField.text = "";
        foreach (Film f in dataAccess.GetFilm(select.options[select.value].text))
        {
            

            // listFilms.Add(f.Title);
          
            textField.text += f.Title + "\n";


        }
    }
    
}