﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenuControl : MonoBehaviour
{
    public Button Resume_btn, Reset_btn, Exit_btn;
    public Rigidbody rigid;

    void Start()
    {
        Resume_btn.onClick.AddListener(Resume_Clicked);
        Reset_btn.onClick.AddListener(Restart_Clicked);
        Exit_btn.onClick.AddListener(Exit_Clicked);
    }

    void Resume_Clicked()
    {
        
    }
    void Restart_Clicked()
    {
        //rigid.GetComponent<Timer>().Start();
        SceneManager.LoadScene("GameScene", LoadSceneMode.Single);
    }
    void Exit_Clicked()
    {
        Debug.Log("Loading MainMenu");
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);

    }
}