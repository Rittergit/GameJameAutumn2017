﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public Transform target;
    public Transform target2;
    public Transform target3;
    public Transform target4;
    public Transform target5;
    public Transform target6;
    public float speed;
    public float rotationSpeed;
    private bool up;
    private bool left;
    private bool right;
    private Rigidbody rb;
    // Use this for initialization
    void Start () {
        // target.position = GameObject.Find("Spring1").transform.position;
        rb = this.GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        float step = speed * Time.deltaTime;
        float rotationStep = rotationSpeed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (left)
            {
                left = false;
                return;
            }
            right = true;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (right)
            {
                right = false;
                return;

            }
            left = true;
        }
        if (Input.GetKeyDown("space"))
        {
            up = !up;
           /* if(right)
            {
                right = false;
                left = true;
            }
            else if(left)
            {
                left = false;
                right = true;
            }*/
        }

        if (!up && right)
        {
            rb.transform.position = Vector3.MoveTowards(rb.transform.position, target3.position, step);
            rb.transform.rotation = Quaternion.Slerp(rb.transform.rotation, target3.transform.rotation,1.0f);
            //rb.transform.rotation = Quaternion.Slerp(rb.transform.rotation, new Quaternion(0,0,45,0), rotationStep);
        }
        else if (!up && left)
        {
            rb.transform.position = Vector3.MoveTowards(rb.transform.position, target4.position, step);
            rb.transform.rotation = Quaternion.Slerp(rb.transform.rotation, target4.transform.rotation, 1.0f);
        }
        else if (up && left)
        {
            rb.transform.position = Vector3.MoveTowards(rb.transform.position, target5.position, step);
            rb.transform.rotation = Quaternion.Slerp(rb.transform.rotation, target5.transform.rotation, 1.0f);
        }
        else if (up && right)
        {
            rb.transform.position = Vector3.MoveTowards(rb.transform.position, target6.position, step);
            rb.transform.rotation = Quaternion.Slerp(rb.transform.rotation, target6.transform.rotation, rotationStep);
        }
        else if(!up)
        {
            rb.transform.position = Vector3.MoveTowards(rb.transform.position, target2.position, step);
            rb.transform.rotation = Quaternion.Slerp(rb.transform.rotation, target2.transform.rotation, rotationStep);
        }
        else if (up)
        {
            rb.transform.position = Vector3.MoveTowards(rb.transform.position, target.position, step);
            rb.transform.rotation = Quaternion.Slerp(rb.transform.rotation, target.transform.rotation, rotationStep);
        }






    }

}
