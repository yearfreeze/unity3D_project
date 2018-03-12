using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contrlcube : MonoBehaviour {
    public GameObject cube1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        cube1.transform.Translate(Vector3.up*0.1f,Space.World);
	}

    public void OnMouseDown()
    {

    }
}
