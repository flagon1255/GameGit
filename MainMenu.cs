using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MainMenu : MonoBehaviour
{

    public TMP_InputField name;
  public void play()
    {

        NameHolderStatic.Name = name.text;

        SceneManager.LoadScene(1);

        
    }
}
