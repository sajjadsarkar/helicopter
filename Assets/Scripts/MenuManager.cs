using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject menu;
    public GameObject Credits;
    public GameObject Controls;
    private void Start()
    {
        menu.SetActive(true);
        Credits.SetActive(false);
        Controls.SetActive(false);
        Time.timeScale = 0f;
    }
    public void MenuDisable()
    {
        menu.SetActive(false);
        Time.timeScale = 1f;
    }
    public void CreditsEnable()
    {
        Credits.SetActive(true);
    }
    public void CreditsDisable()
    {
        Credits.SetActive(false);
    }

    public void ControlsEnable()
    {
        Controls.SetActive(true);
    }
    public void ControlsDisable()
    {
        Controls.SetActive(false);
    }
}
