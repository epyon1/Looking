using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treasure1 : MonoBehaviour {
    RaycastHit hit;
    public SteamVR_TrackedObject trackedObject;
    GameObject pointingObj;
    GameObject targetObj = null;

    // Use this for initialization
    void Start () {
        trackedObject = GetComponent<SteamVR_TrackedObject>();
    }

    // Update is called once per frame
    void Update() {
        Ray ray = new Ray(transform.position, transform.forward);
        var device = SteamVR_Controller.Input((int)trackedObject.index);

        if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
        {
            if (Physics.Raycast(ray, out hit))
            {
                pointingObj = hit.transform.gameObject;
                grabObject(pointingObj);
            }
        }

        if (device.GetPressUp(SteamVR_Controller.ButtonMask.Trigger))
        {
            releaseObject();
        }

    }
    void grabObject(GameObject obj)
    {
        targetObj = obj;
        FixedJoint fj = gameObject.GetComponent<FixedJoint>();
        fj.connectedBody = targetObj.GetComponent<Rigidbody>();
    }

    void releaseObject()
    {
        FixedJoint fj = gameObject.GetComponent<FixedJoint>();
        if (fj != null)
        {
            fj.connectedBody = null;
        }
        targetObj = null;
    }
}


//    void OnCollisionStay(Collision other)
//    {
//        if (other.gameObject.tag == "sample")
//        {
//            Destroy(other.gameObject);
//        }
//    }
//}
