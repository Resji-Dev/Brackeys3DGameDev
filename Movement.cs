using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField]private float SideForce;
    [SerializeField]private int hp;
    [SerializeField]private Rigidbody rb;
    [SerializeField]private float forwardForce;
    // Start is called before the first frame update
    void Start()
    {
        //Another way to get rb = rigidbody
        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //disabled being able to choose your speed, just left and right now
        //if(Input.GetKey("w")){
            rb.AddForce(0,0,forwardForce * Time.deltaTime);
        //}
        //if(Input.GetKey("s")){
        //    rb.AddForce(0,0,-force*Time.deltaTime);
        //}
        //had to remove the going forward and backward at the same time.
        if(Input.GetKey("d")){
            rb.AddForce(SideForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(Input.GetKey("a")){
            rb.AddForce(-SideForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

    }

}
