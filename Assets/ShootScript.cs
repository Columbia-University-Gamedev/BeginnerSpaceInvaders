using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public GameObject proj;
    public float moveSpeed = 10f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newObject = Instantiate(proj, transform.position, transform.rotation);

            Rigidbody2D body = newObject.GetComponent<Rigidbody2D>();

            if (body != null)
            {
                body.velocity = new Vector2(0, moveSpeed);
            }
            else
            {
                Debug.Log("I goofed");
            }
        }
    }
}
