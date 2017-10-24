using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{
    GameObject prefab;
    // Use this for initialization
    void Start()
    {

        prefab = Resources.Load("Laser") as GameObject;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            GameObject Laser = Instantiate(prefab) as GameObject;
            Laser.transform.position = transform.position + Camera.main.transform.forward * 2;
            Rigidbody rb = Laser.GetComponent<Rigidbody>();
            rb.velocity = Camera.main.transform.forward * 40;





        }




    }
}
