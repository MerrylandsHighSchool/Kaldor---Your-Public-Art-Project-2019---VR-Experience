using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayVideoScript : MonoBehaviour
{
    public int timeToStop;
    public GameObject VideoPlayer;
    public GameObject SceneObjects;
    float timer = 0f;
    void Start()
    {
        if (DataScript.TimesPlayed)
        {
            SceneObjects.SetActive(false);
            VideoPlayer.SetActive(true);
        } else {
            SceneObjects.SetActive(true);
            VideoPlayer.SetActive(false);
        }
    }

     void Update()
    {
        timer += Time.deltaTime;

        if (timer >= timeToStop)
        {
            SceneObjects.SetActive(true);
            Destroy(VideoPlayer);
            DataScript.TimesPlayed = false;
        }
    }
}
