using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Animator anim;
    
    float forwa;
    public float movespeed;
    private Vector3 velocity;
    public float gravity = -10f;
    public float jumpHeight = 3f;

    bool jumping = false;

    public CharacterController cha;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");


        Vector3 move = transform.right * x + transform.forward * z;
        //Vector3 move = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));

        //anim.SetFloat("Movement",move.z);

        //if (anim.GetInteger("Jump") < 3)
        //{
            cha.Move(move *movespeed);
        //}

        velocity.y += gravity * Time.deltaTime;

        anim.SetInteger("Idle 3",Random.Range(1, 5));
        if (cha.isGrounded)
        {
            Debug.Log("waa");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (cha.isGrounded)
            {
                anim.SetInteger("Jump", 2);
                velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
                jumping = true;
            }
            
        }

        cha.Move(velocity * Time.deltaTime);

        if (jumping == true)
        {
            if (cha.isGrounded)
            {
                anim.SetInteger("Jump", Random.Range(3,5));
                jumping = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetFloat("Movement", 1);
        }


        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetFloat("Movement", 0);
            anim.SetBool("run",false);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            if (anim.GetBool("run") == false)
            {
                anim.SetBool("run",true);
                movespeed *= 2;
            } else
            {
                anim.SetBool("run",false);
                movespeed /= 2;

            }
            
        }
    }
}
