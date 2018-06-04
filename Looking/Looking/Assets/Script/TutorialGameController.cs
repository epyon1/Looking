using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//using System.Windows.Threading;

public class TutorialGameController : MonoBehaviour
{
    public GameObject Object1;
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
        StartCoroutine(Sample());
    }
    IEnumerator Sample()
    {
        if (Object1 == null)
        {
            text.text = "correct";

            yield return new WaitForSeconds(3f);
            SceneManager.LoadScene("Main");
        }
    }
}