using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicSyntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //this line is there to tell me the x position of my object
        Debug.Log(transform.position.x);
    }

    // Update is called once per frame
    void Update()
    {
        // If our gameobject's y value is below 5 we want to show a message on the console
        if (transform.position.y <= 5F);
        {
            Debug.Log("I'm about to hit the ground!");
        }
    }
}
