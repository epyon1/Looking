using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Incorrect : MonoBehaviour {
    public Text text;
    public GameObject Object2;
    public GameObject IncorrerctLabelObject;

	
	// Update is called once per frame
	void Update ()
    {
        text.text = "";
        StartCoroutine(Sample());


    }

    IEnumerator Sample()
    {
        if (Object2 == null)
        {
            text.text = "Incorrect";

            yield return new WaitForSeconds(3f);
            text.text = "";

            //text.text = "Incorrect";
            //IncorrerctLabelObject.SetActive(true);
            //yield return new WaitForSeconds(3f);
            //IncorrerctLabelObject.SetActive(false);

        }


    }



    //void DelayMethod()
    //{
    //    text.text = " ";
    //}
}
