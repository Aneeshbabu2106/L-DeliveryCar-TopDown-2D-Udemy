using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camfollow : MonoBehaviour
{
    public GameObject tofollow;
    Vector3 pos;
    
    void FixedUpdate()
    {
        pos = tofollow.transform.position + new Vector3(0,0,-10);
        transform.position = pos;
    }
}
