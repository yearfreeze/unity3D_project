using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour {
    public GameObject shot_position;
    public float power = 2000;
    public GameObject ball_prefab;
    public int moving_speed = 5;
	// Use this for initialization
	void Start () {
		//no use
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject go = Instantiate(ball_prefab, shot_position.transform.position, Quaternion.identity);
            Rigidbody rb = go.GetComponent<Rigidbody>();
            rb.AddForce(power * shot_position.transform.forward);
        }
        float h = Input.GetAxis("Horizontal") * moving_speed*Time.deltaTime; //*deltaTime可以做到平滑过渡
        float v = Input.GetAxis("Vertical") * moving_speed*Time.deltaTime;
        shot_position.transform.Translate(h,v,0);
	}
}
