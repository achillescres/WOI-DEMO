using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*This script is responsible for adding new events
 * Topic == Тема
 * EventObjects is a ready-made template for filling in the text
 * ScrollNumber is a index of EventObject
*/
public class ScrollContent : MonoBehaviour {
    //Objects templates for filling
    public GameObject[] EventObjects;
    //Names, dates, contacts, places, topics input; Names - 0 Dates - 1 Contacts - 2 Places - 3 Topics - 4
    public Text[] Input;
    private void Awake()
    {
        //Initialize ScrollNumber
        PlayerPrefs.SetInt("ScrollNumber", 0);
    }

    void OnMouseUp()
    {
        //Local index of temlate(EventObject)
        int Index = PlayerPrefs.GetInt("ScrollNumber");
        //EventObject name
        string ObjectName = EventObjects[Index].name;

        //Get texts from EventObject
        Text Name = GameObject.Find("/Canvas/Scroll View/Viewport/Content/GameObject/" + ObjectName+"/Name").GetComponent<Text>();

        Text Date = GameObject.Find("/Canvas/Scroll View/Viewport/Content/GameObject/" + ObjectName + "/Date").GetComponent<Text>();

        Text Topic = GameObject.Find("/Canvas/Scroll View/Viewport/Content/GameObject/" + ObjectName + "/Topic").GetComponent<Text>();

        Text Place = GameObject.Find("/Canvas/Scroll View/Viewport/Content/GameObject/" + ObjectName + "/Place").GetComponent<Text>();

        Text Contacts = GameObject.Find("/Canvas/Scroll View/Viewport/Content/GameObject/" + ObjectName + "/Contacts").GetComponent<Text>();

        //Fill texts from EventObject
        Name.text = Input[0].text;
        Date.text = Input[1].text;
        Topic.text = Input[2].text;
        Place.text = Input[3].text;
        Contacts.text = Input[4].text;

        //Encreases the index of EventObjects
        PlayerPrefs.SetInt("ScrollNumber", PlayerPrefs.GetInt("ScrollNumber") + 1);
    }
}