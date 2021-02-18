using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float rate;
    public int ammosize;
    public int allammo;
    public float damage = 5f;
    public float range = 100f;
    public float force = 500f;
    public Camera cam;
    public ParticleSystem flash;
    public GameObject parent;
    bool shooting;
    int currentammo;
    int ammoreserve;
    public Animator animation;
    Vector3 curposition;
    Vector3 lastposition;

    void Start()
    {
        flash.playOnAwake = false;
        flash.playbackSpeed = 8;
      animation=animation.GetComponent<Animator>();
        
    }
    
    // Update is called once per frame
    void Update()
    {
       
        if(Input.GetButtonDown("Fire1"))
        {
            shoot();
        }
        curposition = parent.transform.position;
        if (curposition == lastposition)
            animation.SetBool("Walk", false);
        else
            animation.SetBool("Walk", true);
        lastposition = curposition;

    }

    void shoot()
    {
        
        flash.Play();
        RaycastHit hit;
        if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
        {
            Enemy enemy = hit.transform.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(damage);


            }
           
            
            if (hit.rigidbody != null)
                hit.rigidbody.AddForce(-hit.normal * force);
        }

       
   
    }
}
