using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMenu : MonoBehaviour
{

    private void Awake()
    {
        this.gameObject.SetActive(false);
    }

    public void SetMenuActive ()
    {
        this.gameObject.SetActive(!this.gameObject.activeSelf);
    }
}
