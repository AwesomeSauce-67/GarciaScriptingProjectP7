using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    float cofTem = 85.0f;
    float hotLimTem = 70.0f;
    float colLimTem = 40.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        cofTem -= Time.deltaTime * 5f;
    }
    void TemperatureTest ()
    {
        // If the coffee's temperature is greater than the hottest drinking temperature...
        if(cofTem> hotLimTem)
        {
            //... do this
            print("Coffee is too cold.");
        }
        // If it isn't, but the coffee temperature is less than the coldest drinking temperature...
        else if(cofTem < colLimTem)
        {
            //...do this
            print("Coffee is too cold.");
        }
        //If it is neither of those then
        else
        {
            //... do this
            print("Coffee is just right.");
        }
    }
}
