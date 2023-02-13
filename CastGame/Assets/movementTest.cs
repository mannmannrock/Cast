using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementTest : MonoBehaviour
{
    // defining variables
    Rigidbody2D body;
    float hor;
    float vert;
    public static float movementSpeed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        // gets the rigidbody component from the object this script is on
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // sets direction values
        hor = Input.GetAxisRaw("Horizontal");
        vert = Input.GetAxisRaw("Vertical");
    }
    private void FixedUpdate()
    {
        // sets the velocity of the object
        body.velocity = new Vector2(hor * movementSpeed, vert * movementSpeed);
    }
}
