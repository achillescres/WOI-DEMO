using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*This script is responsible for adding new Questionы-Answers
 * AnswerObjects is a ready-made template for filling in the text
 * AnswerNumber is a index of AnswerObject
*/
public class AnswerContent : MonoBehaviour
{
    //Objects templates for filling
    public GameObject[] EventObjects;
    //Names, dates, contacts, places, topics input; Names - 0 Dates - 1 Contacts - 2 Places - 3 Topics - 4
    public Text[] InputAnswerQuestion;
    private void Awake()
    {
        //Initialize AnswerNumber
        PlayerPrefs.SetInt("AnswerNumber", 0);
    }

    void OnMouseUp()
    {
        //Local index of temlate(EventObject)
        int Index = PlayerPrefs.GetInt("AnswerNumber");
        Debug.Log(Index);
        string ObjectName = EventObjects[Index].name;

        //Get texts from AnswerObject
        Text Name = GameObject.Find("/Canvas/Scroll View/Viewport/Content/GameObject/" + ObjectName + "/Name").GetComponent<Text>();

        Text Date = GameObject.Find("/Canvas/Scroll View/Viewport/Content/GameObject/" + ObjectName + "/Date").GetComponent<Text>();

        Text Contacts = GameObject.Find("/Canvas/Scroll View/Viewport/Content/GameObject/" + ObjectName + "/Contacts").GetComponent<Text>();

        Text Question = GameObject.Find("/Canvas/Scroll View/Viewport/Content/GameObject/" + ObjectName + "/Question").GetComponent<Text>();

        //Fill texts from AnswerObject
        Name.text = InputAnswerQuestion[0].text;
        Date.text = InputAnswerQuestion[1].text;
        Contacts.text = InputAnswerQuestion[2].text;
        Question.text = InputAnswerQuestion[2].text;

        //Encreases the index of AnswerObjects
        PlayerPrefs.SetInt("AnswerNumber", PlayerPrefs.GetInt("AnswerNumber") + 1);
    }
}