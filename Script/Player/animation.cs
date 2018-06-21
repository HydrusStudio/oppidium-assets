using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour {
    public Animator anim;
    public Rigidbody rbody;

    private float inputH;
    private float inputV;

	// Use this for initialization
	void Start ()
    {
        anim = GetComponent<Animator>();
        rbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(Input.GetKeyDown("1"))
        {
            anim.Play("WAIT01",-1,0f);
        }
        if (Input.GetKeyDown("2"))
        {
            anim.Play("WAIT02", -1, 0f);
        }
        if (Input.GetKeyDown("3"))
        {
            anim.Play("WAIT03", -1, 0f);
        }
        if (Input.GetKeyDown("4"))
        {
            anim.Play("WAIT04", -1, 0f);
        }

        if(Input.GetMouseButtonDown(0))
        {
            int n = Random.Range(0, 2);
            if(n == 0)
            {
                anim.Play("DAMAGED00", -1, 0f);
            } else
            {
                anim.Play("DAMAGED01", -1, 0f);
            }
            
        }

        inputH = Input.GetAxis("Horizontal");
        inputV = Input.GetAxis("Vertical");

        anim.SetFloat("inputH", inputH);
        anim.SetFloat("inputV", inputV);

        float moveX = inputH * 20f * Time.deltaTime;
        float moveZ = inputV * 50f * Time.deltaTime;

        rbody.velocity = new Vector3(moveX, 0f, moveZ);
    }
}
