using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool havepackage = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "package" && !havepackage)
        {
            havepackage = true;
            Destroy(collision.gameObject, .2f);
        }
        if(collision.tag == "delivery")
        {
            havepackage = false;
        }
    }
}
