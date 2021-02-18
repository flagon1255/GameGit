using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{

    float health = 100f;

    public Rigidbody rb;
    [SerializeField]
    List<Hiscores> hs = new List<Hiscores>();
    TextMeshProUGUI TextPro;

    AsyncOperation asyncLoadLevel;

    public void takedamage(float dmg)
    {
        health -= dmg;
        if (health <= 0)
            die();
        else
            Debug.Log(health);
    }

    public void die()
    {

        
        GameObject txt = GameObject.FindGameObjectWithTag("ui");
        TextPro = txt.GetComponent<TextMeshProUGUI>();
        rb.constraints = RigidbodyConstraints.None;

        if (File.Exists("hiscores.txt"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open("hiscores.txt", FileMode.Open);
            List<Hiscores> hs = (List<Hiscores>)bf.Deserialize(file);
            hs.Add(new Hiscores(NameHolderStatic.Name, int.Parse(TextPro.text)));
            file.Close();
            ListHolder.setlist(hs);

            FileStream fss = new FileStream("hiscores.txt", FileMode.Create);
            bf.Serialize(fss, hs);
            fss.Close();

          

        }
        else
        {

            hs.Add(new Hiscores(NameHolderStatic.Name, int.Parse(TextPro.text)));
            ListHolder.setlist(hs);
            FileStream fs = new FileStream("hiscores.txt", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, hs);
            fs.Close();
           
        }
        screen();
    }

 
    IEnumerator diescreen()
    {
        asyncLoadLevel = SceneManager.LoadSceneAsync(2, LoadSceneMode.Additive);
        yield return new WaitForSeconds(10);
        while (!asyncLoadLevel.isDone)
        {
            print("Loading the Scene");
            yield return null;
        }
        


    }

    void screen()
    {
        SceneManager.LoadScene(2);
    }
}
