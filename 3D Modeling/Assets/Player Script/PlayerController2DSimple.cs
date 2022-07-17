using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2DSimple : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");    //input left/right
        float vertical = Input.GetAxis("Vertical");        //input up  /down


        animator.SetFloat("Horizontal", horizontal);//horizontal animation

        animator.SetFloat("Vertical", vertical);    //vertical animation
    
    
    //movement speed
    //float moveSpeed = 5.0f;
    //actual movement
    //transform.position += new Vector3(horizontal, 0, vertical) * moveSpeed * Time.deltaTime;
    }

}
