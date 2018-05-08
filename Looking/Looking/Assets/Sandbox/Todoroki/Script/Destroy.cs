using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

    //トリガーとの接触時に呼ばれるコールバック
    void OnTriggerEnter(Collider hit)
    {
        //接触対象はPlayerタグですか？
        if (hit.CompareTag("Player"))
        {
            //このコンポーネントを持つオブジェクトを破棄する
            Destroy(gameObject);

        }

        ////トリガーとの接触時に呼ばれるコールバック
        //void OnTriggerEnter(Collider hit)
        //{
        //    //接触対象はPlayerタグですか？
        //    if (hit.CompareTag("Player"))
        //    {
        //        //このコンポーネントを持つオブジェクトを破棄する
        //        Destroy(gameObject);

        //    }
    }


 //   // Use this for initialization
 //   void Start () {
		
	//}
	
	//// Update is called once per frame
	//void Update () {
		
	//}
}
