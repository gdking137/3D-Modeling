using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1D : MonoBehaviour
{
    private Animator animator;
    //private float walkSpeed = 4.0f;
    //private float runSpeed = 8.0;

    private void Awake()
    {
       animator = GetComponent<Animator>();
    }

    private void Update()
    {
        float vertical = Input.GetAxis("Vertical");   //up/down key input
        //normal speed = 0.5
        //Shift speed  = 1.0

        float offset = 0.5f + Input.GetAxis("Sprint") * 0.5f;
        //use absolute value so there won't be negative value

        float moveParameter = Mathf.Abs(vertical * offset);
        
        animator.SetFloat("moveSpeed", moveParameter);
        //moveParameter decides the animation


        //movement speed = walkspeed , 
        //save the values insidee the variables
        //float moveSpeed = Mathf.Lerp(walkSpeed, runSpeed, Input.GetAxis("Sprint"));


        //actual movement
        //transform.position += new Vector3(vertical, 0, 0) * moveSpeed * Time.deltaTime;


    }
}
