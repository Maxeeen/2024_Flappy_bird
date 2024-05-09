using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_Controler : MonoBehaviour
{

    public float JumpForce;
    public Rigidbody2D Rb2D;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("Jump");
            //in this case transform 
            Rb2D.AddForce(transform.up * JumpForce, ForceMode2D.Impulse);
        }
    }
}
