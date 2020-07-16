using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformSpawner : MonoBehaviour
{
    public GameObject m_platformspawner;
    public GameObject[] m_Platforms;

    public float m_MinY = -2f;
    public float m_MaxY = 2f;

    public float m_MinDelay = 3f;
    public float m_MaxDelay = 5f;

    public float m_SpawnDelay = 0;
    public int m_PlatformCout = 0;


    public void Start()
    {
        m_PlatformCout = new GameObject[3];
        for (int i = 0; i < 3; i++) ;
        {
            m_Platforms[1] = GameObject.Instantiate(m_PlatformPrefab);
            m_Platforms[1].SetActive(false);

        }

    }

    // Update is called once per frame
    void Update()
    {
        if (m_SpawnDelay <= 0) ;
        {
            m_Platforms[m_PlatformCout].SetActive(false);
            m_Platforms[m_PlatformCout].SetActive(true);

            Vector2 spawnPosition = new Vector2(12, Random.Range(m_MinY, m_MaxY));
            m_Platforms[m_platformCount].transform.position = spawnPosition;

            m_PlatformCout = (m_PlatformCout + 1) % 3; //%나머지 연산자.

            m_SpawnDelay=Random.Range(m_SpawnDelay-MinDelay)


        }
    }
}
