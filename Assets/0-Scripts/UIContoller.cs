using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIContoller : MonoBehaviour
{
    public Button restartButton,addButton;
    public InputField addInput;
    public static UIContoller uIContoller;
    public int MaxBodies = 100;

    /// <summary>
    /// using ui controller
    /// </summary>
    private void Awake()
    {
        if (uIContoller == null)
        {
            uIContoller = this;
        }
        if (uIContoller != this) {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(UIContoller.uIContoller.gameObject);
    }

    /// <summary>
    /// what to do when the button is pressed
    /// </summary>
    void Start()
    {
       
        //btn = GameObject.Find("Button").GetComponent<Button>();
        //input = GameObject.Find("InputField").GetComponent<InputField>();
        restartButton.onClick.AddListener(StartAgain);
        addButton.onClick.AddListener(AddObject);
    }

    /// <summary>
    /// Restrart button Method 
    /// </summary>
    public void StartAgain()
    {
        //Debug.Log("Changed " + reInput.text);
        //MaxBodies= Int32.Parse(reInput.text);
        
        //For reaload scene and create object with entering value
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);

        //Add object amount in Run Time
       
    }

    /// <summary>
    /// Add button Method
    /// </summary>
    public void AddObject()
    {
        Debug.Log("Changed " + addInput.text);
        MaxBodies = Int32.Parse(addInput.text);

        //Get a size value and do this for instantiating
        GameObject.FindGameObjectWithTag("Generator").GetComponent<DemoScript>().InstantiateObj(MaxBodies);//MaxBodies
    }
   
}
