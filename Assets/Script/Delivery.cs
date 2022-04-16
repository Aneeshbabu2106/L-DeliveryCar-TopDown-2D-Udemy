using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    public Color32 oldColor;
    public Color32 newColor;
    bool havepackage = false;
    SpriteRenderer SR;
    private void Start()
    {
        SR = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "package" && !havepackage)
        {
            havepackage = true;
            Destroy(collision.gameObject, .2f);
            SR.color = newColor;
        }
        if(collision.tag == "delivery")
        {
            havepackage = false;
            SR.color = oldColor;
        }
    }
}
