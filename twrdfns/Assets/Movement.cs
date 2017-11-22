using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {    
    public float rotationSpeed = 25f;
    public float forceAmp = 20f;
    private Rigidbody body;
	// Use this for initialization
	void Start () {
        body = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        

        if (Input.GetKey(KeyCode.W))
        {
            body.AddForce(transform.forward * forceAmp * Time.deltaTime, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, -baseSpeed * Time.deltaTime, transform.rotation.eulerAngles.z);
            transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            body.AddForce(-transform.forward * forceAmp * 0.8f * Time.deltaTime, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, baseSpeed * Time.deltaTime, transform.rotation.eulerAngles.z);
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }        
    }
}
