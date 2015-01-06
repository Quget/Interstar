﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Bookdata : MonoBehaviour {

    public GameObject UserIDGameObject;
    public GameObject SessionIDGameObject;

    public GameObject bookCoverInfo;

    // Load the two buttons (Play and Quit)
    public Button toMainMenu;
    public Button toWindows;
    
    void Awake()
    {
        //Debug.Log("Startbook has been loaded");

        //Turn off the open-animation



    }
    // Use this for initialization
	void Start() 
    {
       
        
	}
	
	// Update is called once per frame
	void Update () 
    {
        
	}

    public void LoadFirstLevel()
    {
        
        
        bookCoverInfo.SetActive(false);
        //startBookAnimator.SetBool("hasPressedPlay", true);
        Application.LoadLevel("Level_00_MainMenu");
        if (UserIDGameObject.GetComponent<InputField>().text.Length > 0 && SessionIDGameObject.GetComponent<InputField>().text.Length > 0)
        {

            GameValues.USERID = UserIDGameObject.GetComponent<InputField>().text;
            GameValues.SESSIONID = SessionIDGameObject.GetComponent<InputField>().text;
        }
        //string _password = inputPassword.GetComponent<InputField>().text;
        //UserIDGameObject.GetComponent<InputField>().text;

        

        //Application.LoadLevel("Level_1");
    }
    
    public void quitToDesktop()
    {
        Application.Quit();
    }
}