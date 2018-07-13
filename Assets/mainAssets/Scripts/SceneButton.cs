using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//This sript for button that switch scenes
public class SceneButton : MonoBehaviour {

    void OnMouseUp()
    {
        //Switches the scenes or open the site with test, depending on the button
        //Button name using like number of the scene
        if ((Convert.ToInt32(gameObject.name[0]) - 48) == 2)
        {
            Application.OpenURL("http://zvzda.ru/tests/481efe32a4fb");
        }
        else
        {
            SceneManager.LoadScene((Convert.ToInt32(gameObject.name[0]))-48);
            //What ..-48..? My c # adds 48 when converting string to int
        }
    }
}
