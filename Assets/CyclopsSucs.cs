using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CyclopsSucs : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray beam = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit = new RaycastHit();

        if (Physics.Raycast(beam, out hit))
        {
            Debug.Log("ds");
        }

    }
}
