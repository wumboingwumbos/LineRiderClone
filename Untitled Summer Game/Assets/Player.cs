using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    bool start = false;
    Vector2 spawn;
    private Vector2 velocity;
    public float spawnx = 0f;
    public float spawny = 0f;
    private void Start()
    {
        spawn = new Vector2(spawnx, spawny);
    }
    void Update ()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (!start)
            {
                rb.bodyType = RigidbodyType2D.Dynamic;
                if (velocity != null)
                {
                    rb.velocity = velocity;
                }
                start = true;
            }
            else
            {
                velocity = rb.velocity;
                rb.bodyType = RigidbodyType2D.Static;
                start = false;
            }
        }
        if(Input.GetKeyDown("r"))
        {
            Reset();
        }
    }
    public void Reset()
    {
        if (rb.bodyType == RigidbodyType2D.Dynamic)
            rb.velocity = Vector2.zero;
        rb.position = spawn;
        rb.rotation = 0;
        
        
       
       
    }
}
