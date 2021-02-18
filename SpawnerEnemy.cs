using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpawnerEnemy : MonoBehaviour
{
    GameObject[] enemyc;
    GameObject enemy;
    public GameObject enemyobj;
    public int deadcount;
    public int score;

   TextMeshProUGUI TextPro;
    bool alldead = true;
    int c=1;
   
    void Start()
    {
        GameObject txt = GameObject.FindGameObjectWithTag("ui");
        TextPro = txt.GetComponent<TextMeshProUGUI>();
        score = 0;
    
    }

    // Update is called once per frame
    void Update()
    {
        TextPro.text = score.ToString();
        if (alldead == false)
        {
           
        }
        else
        {
            enemyc = GameObject.FindGameObjectsWithTag("Enemy");
            if (enemyc.Length < c)
                enemy = Instantiate(enemyobj, new Vector3(Random.Range(-700, -810), 1509, Random.Range(5000, 5400)), Quaternion.identity) as GameObject;
            else
                alldead = false;
        }

      
    }



    public void dead()
    {
        deadcount += 1;
        score++;
        if (deadcount == enemyc.Length)
        {
            Debug.Log("All dead");
            alldead =true;
            c = c * 2;
            deadcount = 0;

        }
    }
}
