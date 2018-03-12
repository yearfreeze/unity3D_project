using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class produce_cube : MonoBehaviour {
    public GameObject go;
    private int colnum = 8;
    private int rownum = 5;
	// Use this for initialization
	void Start () {
        for (int i = 0; i < colnum; i++)
            for (int j = 0; j < rownum;j++ )
                Instantiate(go, new Vector3(i, 0.5f+j, 0), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
