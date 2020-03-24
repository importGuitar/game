
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class People: MonoBehaviour
{
    public float MoveSpeed ;
 
    void Start()
    {
        MoveSpeed = 2.0f;
    }
 
    void Update()
    {
        if (Input.GetKey(KeyCode.I))
        {
          transform.Translate(Vector3.up*Time.deltaTime*MoveSpeed);
        }
        if (Input.GetKey(KeyCode.J))
        {
            transform.Translate(Vector3.left * Time.deltaTime * MoveSpeed);
        }
        if (Input.GetKey(KeyCode.K))
        {
            transform.Translate(Vector3.down * Time.deltaTime * MoveSpeed);
        }
        if (Input.GetKey(KeyCode.L))
        {
            transform.Translate(Vector3.right * Time.deltaTime * MoveSpeed);
        }
       
    }
 
 
 
}
