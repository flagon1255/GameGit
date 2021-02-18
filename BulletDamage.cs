using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    // Start is called before the first frame update
    public float damage=50f;

    void OnCollisionEnter(Collision col)
    {
        Health a;
        if (col.gameObject.tag == "Player")
        {
            a = col.gameObject.GetComponent<Health>();
            a.takedamage(damage);
        }

    }
}
