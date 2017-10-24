using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    int damageAmount = 5;
    float targetDistance;
    float allowedRange = 15f;


    // Use this for initialization
    void Start()
    {


    }


    // Update is called once per frame
    void Update()
    {
        RaycastHit shot;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out shot))
        {
            targetDistance = shot.distance;
            if (targetDistance < allowedRange)
            {
                shot.transform.SendMessage("DeductPoints", damageAmount);
            }

        }



    }
}
    
