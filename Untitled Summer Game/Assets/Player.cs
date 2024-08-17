using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    bool start = false;

    void Update ()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (!start)
            {
                rb.position = Vector2.zero;
                rb.rotation = 0;
                rb.bodyType = RigidbodyType2D.Dynamic;
                start = true;
            }
            else
            {
                rb.bodyType = RigidbodyType2D.Static;
                
                start = false;
            }
        }
    }
}
