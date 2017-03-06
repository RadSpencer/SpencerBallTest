using UnityEngine;
using System.Collections;

public class Camera_Rotation : MonoBehaviour {

    public float speed = 90.0f;
    public float gravity = 25.0f;
    public Camera cam;
    float rotate = 0.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        rotate += Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        cam.transform.rotation = Quaternion.Euler(90.0f, rotate, 0.0f);
	}

    void FixedUpdate() {

        Physics.gravity = cam.transform.up * -1.0f * gravity;

    }
}
