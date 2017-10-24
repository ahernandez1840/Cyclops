using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laserz : MonoBehaviour
{
    public GameObject prefab;
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;

    public GameObject civil1;
    public GameObject civil2;
    public GameObject civil3;

   
    void Start()
    {
        prefab = Resources.Load("Laser") as GameObject;


    }

    // Update is called once per frame
    void Update()
    {

        Ray beam = Camera.main.ScreenPointToRay(Input.mousePosition);

        Debug.DrawRay(beam.origin, beam.direction * 1000f);


        RaycastHit beamHit = new RaycastHit();

        if (Input.GetMouseButtonDown(0))
        {

            GameObject Laser = Instantiate(prefab) as GameObject;
            Laser.transform.position = transform.position + Camera.main.transform.forward * 2;
            Rigidbody rb = Laser.GetComponent<Rigidbody>();
            rb.velocity = Camera.main.transform.forward * 40;



        }

    }
    
}


