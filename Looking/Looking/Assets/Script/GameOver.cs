using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{

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

        text.text = "ゲームオーバーです(T_T)";
        yield return new WaitForSeconds(3);

        text.text = "これにてゲーム終了となります。";
        yield return new WaitForSeconds(3);

        text.text = "この後は感想戦タイムになります。";
        yield return new WaitForSeconds(2);

        text.text = "引き続きUTVポートフォリオで\nお楽しみ下さい。";
        yield return new WaitForSeconds(4);

        Debug.Log("ゲームを終了します");
        //gameMaster.GameExit();

    }

}

