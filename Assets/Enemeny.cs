using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemeny : MonoBehaviour
{
    public GameObject ufo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, ufo.transform.position, 0.1f);
    }
}
