using UnityEngine;
using System.Collections;

public class cameraRot : MonoBehaviour
{

    Vector3 startPos;
    Quaternion startRot;

    void Awake()
    {
        startPos = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
        startRot = new Quaternion(this.transform.rotation.x, this.transform.rotation.y, this.transform.rotation.z, this.transform.rotation.w);
    }

    void Update()
    {
        CameraZoom();
        rotateObject();
        resetPosition();
    }

    void resetPosition()
    {
        if (Input.GetKey(KeyCode.R))
        {
            this.transform.position = startPos;
            this.transform.rotation = startRot;
        }

    }

    void CameraZoom()
    {

        float mouseScrollValue = Input.GetAxis("Mouse ScrollWheel") * 100f;
        float mouseScroll = Mathf.Clamp((int)mouseScrollValue, -10, 20);


        float mouseX = Input.mousePosition.x / 5;
        float mouseY = transform.position.y;
        float mouseZ = Input.mousePosition.y / 5;
        Vector3 thePos = new Vector3(mouseX, mouseY, mouseZ);




        if (Input.GetKey(KeyCode.Z))
        { //Set Camera/Mouse Position to active
            transform.position = thePos;
            Camera.main.transform.position -= new Vector3(0f, mouseScroll, 0f);


        }
    }

    void rotateObject()
    {
        float moveAxisX = Input.GetAxis("Mouse X");
        float moveAxisY = Input.GetAxis("Mouse Y");

        if (Input.GetKey(KeyCode.X))
        {
            //nogood
            Camera.main.transform.Rotate(-moveAxisY, moveAxisX, 0f);

        }
    }
}