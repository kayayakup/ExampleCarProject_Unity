using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset0=new Vector3(0,5,-10);
    private Vector3 offset1 = new Vector3(0, 2, 2.5f);
    private Vector3 offset2 = new Vector3(0, 5, -1);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "Camera0")
        {
            transform.position = player.transform.position + offset0;
        }

        if (gameObject.name == "Camera1")
        {
            transform.position = player.transform.position + offset1;
        }

        if (gameObject.name == "Camera2")
        {
            transform.position = player.transform.position + offset2;
        }


        if (gameObject.name == "Camera20")
        {
            transform.position = player.transform.position + offset0;
        }

        if (gameObject.name == "Camera21")
        {
            transform.position = player.transform.position + offset1;
        }

        if (gameObject.name == "Camera22")
        {
            transform.position = player.transform.position + offset2;
        }
    }
}
