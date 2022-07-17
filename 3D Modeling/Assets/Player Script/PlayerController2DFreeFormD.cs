using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2DFreeFormD : MonoBehaviour
{
    private Animator animator;
    //private float         walkSpeed = 4.0f;
    //private float         runSpeed  = 8.0f;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }


    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");    //input left/right
        float vertical = Input.GetAxis("Vertical");        //input up  /down

        float offset = 0.5f + Input.GetAxis("Sprint") * 0.5f;

        animator.SetFloat("Horizontal", horizontal * offset);//horizontal animation

        animator.SetFloat("Vertical", vertical * offset);    //vertical animation


        //movementSpeed =   "walkSpeed"= normal walking speed    runSpeed= shift speed
        //float moveSpeed = Mathf.Lerp(walkSpeed, runSpeed, Input.GetAxis(Sprint));

        //actual movement
        //transform.position += new Vector3(horizontal, 0, vertical) * moveSpeed * Time.deltaTime;
    }
}
