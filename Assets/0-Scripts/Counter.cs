using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    /// <summary>
    /// We use this script for showing how many hidden objects
    /// </summary>
    public Text countTextData;
    public static int hiddenOrDestroyValue = 0;
   
   
    void Update()
    {
        countTextData.GetComponent<Text>().text = "" + hiddenOrDestroyValue;
    }
}
