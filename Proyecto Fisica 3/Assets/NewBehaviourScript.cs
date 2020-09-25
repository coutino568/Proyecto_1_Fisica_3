using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    //Physics.gravity = Vector3(0, -1.0, 0);

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            UnityEngine.Debug.Log(" cambie la gravedad");
            //rb.gravityScale *= -1;
        }
    }
}
