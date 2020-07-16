﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //간단한 싱글톤 패턴.
    public static GameManager Instance;

    public void Awake()
    {
        if (GameManager.Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void Start()
    {
        m_ScoreUI.text 
            = string.Format("SCORE : {0}", m_Score);
    }

    public bool m_IsGameOver = false;
    public GameObject m_GameOverUI;
    public UnityEngine.UI.Text m_ScoreUI;
    public int m_Score = 0;

    public void OnPlayerDead(){
        m_IsGameOver = true;
        m_GameOverUI.SetActive(true);
    }
    public void OnAddScore(){
        m_Score++;
        m_ScoreUI.text 
            = string.Format("SCORE : {0}", m_Score);
    }
}
