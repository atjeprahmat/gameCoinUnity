using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript
{
    //int i = 10; // gak dipakai untuk demo this...

    public float speed = 5f;

    public void methodsaya()
    {
        Debug.Log("memanggil method saya");
    }

    public Vector3 berjalan()
    {
        // mwndapatkan input horizontal dan vertikal
        float horizontalinput = Input.GetAxis("Horizontal");
        float verticalinput = Input.GetAxis("Vertical");

        //menghitung vektor gerakan
        Vector3 movement= new 
            Vector3 (horizontalinput, 0f, verticalinput)* //sumbu X,Y,Z
            speed*Time.deltaTime;
       
        return movement;
    }
    
}
