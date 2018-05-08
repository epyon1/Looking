//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class PlayerScript : MonoBehaviour
//{

//    float accel = 100.0f;


//    // Use this for initialization
//    void Start()
//    {

//    }

//    // Update is called once per frame
//    void Update()
//    {
//        GetComponent<Rigidbody>().AddForce(transform.right * Input.GetAxisRaw("Horizontal") * accel, ForceMode.Impulse);
//        GetComponent<Rigidbody>().AddForce(transform.forward * Input.GetAxisRaw("Vertical") * accel, ForceMode.Impulse);

//    }
//}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // speedを制御する
    public float speed;

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Rigidbody rigidbody = GetComponent<Rigidbody>();

        // xとyにspeedを掛ける
        rigidbody.AddForce(x * speed, 0, z * speed);
    }
}

