using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OculusController : MonoBehaviour {

    //settings
    public float ForwardSpeed=1.0f ;

    //objects
    //private Controller Controller_ = new Controller();
    private Transform CameraLeft_;

    void Start()
    {
        CameraLeft_ = transform.Find("CameraLeft");
    }

    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            //camera position
            transform.position += CameraLeft_.forward * ForwardSpeed;
        }
        

    }
}
