using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Creating an integer variable

   public int myInt = 67;
    // Start is called before the first frame update
    void Start()
    {
        //running my int variable through the fuinction 
        myInt=MultiplyByTwo(myInt);
        //displaying the results on the console
        Debug.Log(myInt);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int MultiplyByTwo(int number)
    {
        int result;
        result = number * 2;
        return result;
    }
}
