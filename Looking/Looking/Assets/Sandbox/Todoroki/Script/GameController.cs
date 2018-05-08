using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using System.Windows.Threading;

public class GameController : MonoBehaviour
{
    public GameObject Object1;
    public GameObject Object2;
    public GameObject Object3;
    public GameObject Object4;
    public GameObject Object5;
    public GameObject Object6;
    public GameObject Object7;
    public GameObject CorrerctLabelObject;
    public GameObject IncorrerctLabelObject;

    public Text text;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Object1 == null){
            text.text = "correct";
        }

    //    if (Object2 == null)
    //    {
    //        IncorrerctLabelObject.SetActive(true);
    //        Invoke("DelayMethod", 2f);
    //        //// 1秒後に処理を実行
    //        //DispatcherTimer timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
    //        //timer.Start();
    //        //timer.Tick += (s, args) =>
    //        //{
    //        //    // タイマーの停止
    //        //    timer.Stop();

    //        //    // 以下に待機後の処理を書く
    //        //    IncorrerctLabelObject.SetActive(false);
    //        //};
    //    }

    }
    //void DelayMethod()
    //{
    //    IncorrerctLabelObject.SetActive(false);
    //}
}
