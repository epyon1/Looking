//using system.collections;
//using system.collections.generic;
//using unityengine;

//public class treasure1 : monobehaviour
//{
//    raycasthit hit;
//    public steamvr_trackedobject trackedobject;
//    gameobject pointingobj;
//    gameobject targetobj = null;

//    use this for initialization

//   void start () {

//       trackedobject = getcomponent<steamvr_trackedobject>();
//    }

//    update is called once per frame
//    void update()
//    {
//        ray ray = new ray(transform.position, transform.forward);
//        var device = steamvr_controller.input((int)trackedobject.index);

//        if (device.getpressdown(steamvr_controller.buttonmask.trigger))
//        {
//            if (physics.raycast(ray, out hit))
//            {
//                pointingobj = hit.transform.gameobject;
//                grabobject(pointingobj);
//            }
//        }

//        if (device.getpressup(steamvr_controller.buttonmask.trigger))
//        {
//            releaseobject();
//        }

//    }
//    void grabobject(gameobject obj)
//    {
//        targetobj = obj;
//        fixedjoint fj = gameobject.getcomponent<fixedjoint>();
//        fj.connectedbody = targetobj.getcomponent<rigidbody>();
//    }

//    void releaseobject()
//    {
//        fixedjoint fj = gameobject.getcomponent<fixedjoint>();
//        if (fj != null)
//        {
//            fj.connectedbody = null;
//        }
//        targetobj = null;
//    }
//}


//    void OnCollisionStay(Collision other)
//    {
//        if (other.gameObject.tag == "sample")
//        {
//            Destroy(other.gameObject);
//        }
//    }
//}
