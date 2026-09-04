using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherClass : MonoBehaviour
{
    public int apples;
    public int bananas;

    private int stapler;
    private int sellotape;


    // Start is called before the first frame update
    public void FruitMachine(int a, int b)
    {
        int answer = a + b;
        answer = a + b;
        Debug.Log("fruit total " + answer);
    }

    // Update is called once per frame
    private void OfficeSort(int a, int b)
    {
        int answer = a + b;
        answer = a + b;
        Debug.Log("Office supplies total " + answer);
    }
}
