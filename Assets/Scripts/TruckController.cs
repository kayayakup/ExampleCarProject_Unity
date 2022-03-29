using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckController : MonoBehaviour
{
    private float speed = 13.0f, turnSpeed = 50.0f;
    private bool Forward, Backward, TurnLeft, TurnRight;
    public GameObject[] Cameras;
    private int CameraCount;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < Cameras.Length; i++)
        {
            Cameras[i].SetActive(false);
        }
        Cameras[0].SetActive(true);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Forward = Input.GetKey(KeyCode.W);
        Backward = Input.GetKey(KeyCode.S);
        TurnRight = Input.GetKey(KeyCode.D);
        TurnLeft = Input.GetKey(KeyCode.A);

        if (Forward)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }

        if (Backward)
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }

        if (TurnRight)
        {
            transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * turnSpeed);
        }

        if (TurnLeft)
        {
            transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * -turnSpeed);
        }
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Cameras[CameraCount].SetActive(false);
            CameraCount++;
            if (CameraCount > Cameras.Length - 1)
            {
                CameraCount = 0;
            }
            Cameras[CameraCount].SetActive(true);
        }
    }
}
