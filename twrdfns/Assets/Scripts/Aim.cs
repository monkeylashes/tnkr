using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour {

    private Vector3 pos;
    private Camera cam;

    // Use this for initialization
    void Start () {
        pos = new Vector3();
        cam = Camera.main;
        CalcScreenToWorldPos(0f, 0f);        
	}
	
	// Update is called once per frame
	void Update () {        
        transform.LookAt(pos);	}

    private void OnGUI()
    {   
        Event e = Event.current;        
        CalcScreenToWorldPos(e.mousePosition.x, e.mousePosition.y);
    }

    private void CalcScreenToWorldPos(float x, float y)
    {
        if (cam == null)
        {
            cam = Camera.main;
        }

        pos = cam.ScreenToWorldPoint(new Vector3(x, y, 100f));
        pos.y = transform.position.y;

    }
}
