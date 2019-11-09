using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMenu : MonoBehaviour
{
    public GameObject HideObjects;
    private void Awake()
    {
        this.gameObject.SetActive(false);
        HideObjects.gameObject.SetActive(true);
    }

    public void SetMenuActive ()
    {
        if (DataScript.TimesPlayed == false)
        {
            this.gameObject.SetActive(!this.gameObject.activeSelf);
            HideObjects.gameObject.SetActive(!this.gameObject.activeSelf);
        }
    }

    
}
