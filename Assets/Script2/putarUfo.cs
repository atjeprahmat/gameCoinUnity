using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class putarUfo : MonoBehaviour
{
    public float KecepatanPutar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0, 0, KecepatanPutar);
    }
}