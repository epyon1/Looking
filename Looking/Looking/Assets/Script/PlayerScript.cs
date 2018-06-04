using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{


    public GameObject target;
    public float speed = 3.0f;

    private void Start()
    {
    }

    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger) || Input.GetKey(KeyCode.Space))
        {
            float step = speed * Time.deltaTime;
            Vector3 before = transform.position;
            Vector3 after = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z);
            
            transform.position = Vector3.MoveTowards(before, after, step);
        }
        /*
        OVRInput.Update();
        */
    }

    void FixedUpdate()
    {
        /*
#if UNITY_ANDROID && !UNITY_STANDALONE_WIN


        
        //右手持ち決め打ちで実装
        Vector2 vector =  OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad, OVRInput.Controller.RTrackedRemote);
        float x = vector.x;
        float z = vector.y;

#else 
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

#endif
        Rigidbody rigidbody = GetComponent<Rigidbody>();

        // xとyにspeedを掛ける
        rigidbody.AddForce(x * speed, 0, z * speed);
        */

    }
}
