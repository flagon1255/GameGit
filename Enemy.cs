using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Enemy : MonoBehaviour
{
    GameObject enem;
    public EnemyData data;
 public Rigidbody a;
    public Material mat;
    public Renderer Object;
    float health;
    float speed;
    SpawnerEnemy spwn;



    void Start()
    {
        Debug.Log(NameHolderStatic.Name);
        health = data.health;
        enem = GameObject.Find("Spawner");
  
        spwn = enem.GetComponent<SpawnerEnemy>();
      
       
    }
    
  

    public void TakeDamage(float dmg)
    {
        health -= dmg;
        if(health<=0f)
        {
            a.constraints = RigidbodyConstraints.None;
            Object.material = mat;           
            Invoke("Die", 2);
        }
        Debug.Log(health);
    }

    void Die()
    {
        
        Destroy(gameObject);

        spwn.dead();
    }

  
}

