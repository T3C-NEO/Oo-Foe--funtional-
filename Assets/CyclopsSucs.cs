using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CyclopsSucs : MonoBehaviour
{

    // Start is called before the first frame update

    public GameObject prefab;

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
            if (Input.GetMouseButton(0))
            {
                if (hit.rigidbody != null)
                {
                    Debug.Log("ds");
                    hit.rigidbody.AddExplosionForce(100, hit.point, 5f);
                }
            }

            if (Input.GetMouseButtonDown(1))
            {
                Instantiate(prefab, hit.point, Quaternion.identity);
            }
        }

    }
}
