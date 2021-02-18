using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreShow : MonoBehaviour
{

    TextMeshProUGUI TextPro;
    GameObject txt;
    void Awake()
    {
        Cursor.lockState=CursorLockMode.None;
        Cursor.visible = true;
        GameObject txt = GameObject.FindGameObjectWithTag("scoretext");
        Debug.Log(txt);

      

        TextPro = txt.GetComponent<TextMeshProUGUI>();


        if (txt == null)
            Debug.Log("could not find txt");
        else
        {


            foreach (Hiscores hs in ListHolder.returnList())
            {

                TextPro.text += hs.getname() + " " + hs.getpoints().ToString() +"\n";

            }
        }
    }

}

   

