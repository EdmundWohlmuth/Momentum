using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // TESTING AS IF IM NOT IN UNITY
    float acceleration = 0.1f; // ??? getting applied every frame?
    Vector3 position; // in units
    Vector3 velocity; // in units/second

    // Start is called before the first frame update
    void Start()
    {
        //set position
        position.x = 0;
        position.y = 0;
        position.z = 0;

        // set velocity
        velocity.x = 0;
        velocity.y = 0;
        velocity.z = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        ///reading/processing inupt
        if (Input.GetKey(KeyCode.W))
        {
            velocity += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            velocity += Vector3.back;
        }
        if (Input.GetKey(KeyCode.A))
        {
            velocity += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            velocity += Vector3.right;
        }
        // apply friction
        //velocity *=  1f - (0.95f * Time.deltaTime);

        //apply velocity
        position += velocity * acceleration * Time.deltaTime;

        // only for unity --- .draw would already use ^
        gameObject.transform.position = position;
    }
}
