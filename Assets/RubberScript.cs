using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubberScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float bounceStrength;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            myRigidbody.velocity = Vector2.up * bounceStrength;
        }

        transform.Rotate(new Vector3(0, 0, 86));
        
    }
}
