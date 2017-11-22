using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {

    
    public Rigidbody shell;
    public float speed = 20f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        		
	}

    private void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FireShell();
        }
    }

    void FireShell()
    {
        Rigidbody shellClone = (Rigidbody)Instantiate(shell, transform.position, transform.rotation);
        shellClone.velocity = transform.forward * speed;
    }
}
