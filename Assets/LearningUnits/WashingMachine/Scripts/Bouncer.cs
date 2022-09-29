using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncer : MonoBehaviour
{
    Rigidbody rigidbody;
    Vector3 moveDirection;
    // Start is called before the first frame update
    //Ran out of time but wanted it to switch movedirection and add one force when it hits the ground.

    void Start()
    {
        moveDirection = new Vector3(0, 2400,0); // Don't change this!
        rigidbody = GetComponent<Rigidbody>();

        // Don't move this line or add any new values (such as coefficients)!
        GetComponent<Rigidbody>().AddForce(moveDirection, ForceMode.Force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
