using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10.0f;
    private Rigidbody theRB;
    [SerializeField] private float jumpForce = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        theRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        theRB.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, theRB.velocity.y, Input.GetAxis("Vertical") * moveSpeed);

        if (Input.GetButtonDown("Jump")) 
        {
            theRB.velocity = new Vector3(theRB.velocity.x, jumpForce,theRB.velocity.z);
        }
    }
}
