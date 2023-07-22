using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OOP : MonoBehaviour
{
    //int i = 1;
    // Start is called before the first frame update
     NewBehaviourScript tesOOP = new NewBehaviourScript();
    void Start()
    {
        Debug.Log("skrip pertama");

        //int i = 5;

        // membuat object di unity
       

        tesOOP.methodsaya();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(tesOOP.berjalan());
    }
}
