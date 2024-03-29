using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Animator anim;
    
    float forwa;
    public float movespeed;

    public CharacterController cha;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
        
        anim.SetFloat("Movement",move.z);

        cha.Move(move *movespeed);

        anim.SetInteger("Idle 3",Random.Range(1, 5));

        if (Input.GetKeyUp(KeyCode.W))
        {
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
