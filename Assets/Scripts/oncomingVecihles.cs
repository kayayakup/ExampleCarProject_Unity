using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oncomingVecihles : MonoBehaviour
{
    public GameObject[] Vehicles;
    private GameObject[] Vehicle;
    private float Xrange;
    private int nextCar=0;


    void Drive()
    {
        nextCar = Random.Range(0, Vehicles.Length);
        Xrange = Random.Range(-8, 8);
        Vehicle[nextCar] = Instantiate(Vehicles[nextCar], new Vector3(Xrange, 0, 175), Quaternion.Euler(new Vector3(0, 180, 0)));
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Drive", 0, 3.0f);
        
    }

    // Update is called once per frame

    void Update()
    {
        
    }
}
