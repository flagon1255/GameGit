using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
   
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    public Transform player;
    // Update is called once per frame
    void FixedUpdate()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (Input.GetKey(KeyCode.W))
            transform.position += transform.forward;
        if (Input.GetKey(KeyCode.S))
            transform.position += transform.forward*-1;
        if (Input.GetKey(KeyCode.A))
            transform.position += transform.right * -1;
        if (Input.GetKey(KeyCode.D))
            transform.position += transform.right;
    }
}
