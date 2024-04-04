using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float mouseSense = 3f;
    Vector2 look;
    [SerializeField] Transform cameraTransform;
    // Start is called before the first frame update
    void Start()
    {

        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        UpdateLook();
    }

    void UpdateLook()
    {
        look.x += Input.GetAxis("Mouse X") * mouseSense;
        look.y += Input.GetAxis("Mouse Y") * mouseSense;

        look.y = Mathf.Clamp(look.y, -89f, 89f);

        cameraTransform.localRotation = Quaternion.Euler(-look.y, 0, 0);
        transform.localRotation = Quaternion.Euler(0, look.x, 0);
    }
}
