using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameClearController : MonoBehaviour
{

    /*
     * EndControllerオブジェクトにアタッチしてください．
     * Endシーンの進行や必要な機能を実装してください．
     * 
     * [NOTE]
     * 各シーン共通の内容は，GameMasterに実装すること
     * 
     */

    //public GameController gameMaster;
    public Text text;

    void Start()
    {
        text.text = "";
        StartCoroutine(EndLecture());
    }

    IEnumerator EndLecture()
    {
        yield return new WaitForSeconds(3);

        text.text = "ゲームクリアです！！";
        yield return new WaitForSeconds(3);

        text.text = "これにてゲーム終了となります。";
        yield return new WaitForSeconds(3);

        text.text = "この後は感想戦タイムになります。";
        yield return new WaitForSeconds(2);

        text.text = "引き続きUTVポートフォリオでお楽しみ下さい。";
        yield return new WaitForSeconds(4);

        Debug.Log("ゲームを終了します");
        //gameMaster.GameExit();

    }

}
