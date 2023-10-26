using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Level_Editor.Editor.Util;
using Level_Editor.Runtime;
using Sirenix.Utilities;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0, 24), ForceMode2D.Impulse);
        }
        
        
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-10, rb.velocity.y);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(10, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
    }

    public void A()
    {
        
    }
}
