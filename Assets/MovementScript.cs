using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public float speed = 10;

    private bool canLeft = true;
    private bool canRight = true;

    private bool rmove = false;
    private bool lmove = false; 

    void Update()
    {
        if (Input.GetKey(KeyCode.D) && canRight) 
        {
            rmove = true;
            lmove = false;
        }
        else
        {
            rmove = false;
        }
        if (Input.GetKey(KeyCode.A) && canLeft) 
        {
            lmove = true;
            rmove = false;
        }
        else
        {
            lmove = false;
        }
    }

    private void FixedUpdate() 
    {
        if (rmove)
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (lmove)
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == "lbound")
        {
            canLeft = false;
            lmove = false;
        }  
        if (other.gameObject.tag == "rbound")
        {
            canRight = false;
            rmove = false;
        }    
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        {
        if (other.gameObject.tag == "lbound")
        {
            canLeft = true; 
        }  
        if (other.gameObject.tag == "rbound")
        {
            canRight = true;
        }    
        } 
    }
}
