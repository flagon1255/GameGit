using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Transform cam;
    // Update is called once per frame
    void FixedUpdate()
    {
       Vector3 pos=GameObject.Find("PlayerModel").transform.position;
       
        Vector3 offset = new Vector3(0, 0.5f);
        cam.position=pos+offset;
    }
}
