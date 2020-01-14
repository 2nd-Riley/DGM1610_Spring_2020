using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Var1 : MonoBehaviour
{

    // Variables
    string notSeven = "7";
    float seven = 6.5f;
    int child = 2;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(child + seven + notSeven);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
