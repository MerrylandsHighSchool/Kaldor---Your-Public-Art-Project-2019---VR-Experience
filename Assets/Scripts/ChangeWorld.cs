using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeWorld : MonoBehaviour
{
    public string TargetScene;

    public void NewScene ()
    {
        SceneManager.LoadScene(TargetScene, LoadSceneMode.Single);
    }
}
