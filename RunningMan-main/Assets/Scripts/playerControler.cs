using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControler : MonoBehaviour
{
    private int speed = 20;
    private float horizontal;
    private float vertical;
    private int rotationSpeed = 80;
  


    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        
        
        
       
        transform.Translate(Vector3.forward * Time.deltaTime * speed*vertical);
       
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed * horizontal);

    }


}
