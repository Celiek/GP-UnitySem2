using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] float mouseSensitivity = 300f; //czu³oœæ myszy
    Transform playerBody; //refernecja do obrotu naszego gracza
    float xRotation =  0f; //obrot kamery wzgledem osi x kamery

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        playerBody = transform.parent;
    }

    // Update is called once per frame
    void Update()
    {
        CameraRotation();
    }

    void CameraRotation()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 80f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
