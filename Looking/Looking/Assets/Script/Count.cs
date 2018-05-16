using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Count : MonoBehaviour
{
    public UnityEngine.UI.Text scoreLabel;
    public GameObject IncorrerctLabelObject;
    public Text text;

    public void Update()
    {
        int count = GameObject.FindGameObjectsWithTag("Item").Length;
        count = count- 3;
        scoreLabel.text ="残り"+count;

        if (count == 0)
        {
            text.text = "Incorrect";
            StartCoroutine(Sample2());
        }
       
    }

    IEnumerator Sample2()
    {
        
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Failure");

    }
    }
