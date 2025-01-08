using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public static UIController Instance { get; private set; }
    public GameObject touchToPlay;
    public GameObject btnReplay;
    public GameObject btnOption;
    public GameObject btnSetting;
    public GameObject settingBox;
    public GameObject optionBox;
    private bool showSetting = false;
    private bool showOption = false;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void HideUI()
    {
        touchToPlay.SetActive(false);
        btnSetting.SetActive(false);
        btnOption.SetActive(false);
        if (settingBox.activeSelf || optionBox.activeSelf)
        {
            settingBox.SetActive(false);
            optionBox.SetActive(false);
        }
    }

    public void OpenSettingBox()
    {
        if (optionBox.activeSelf)
        {
            optionBox.SetActive(false);
            showOption = false;
        }

        showSetting = !showSetting;
        settingBox.SetActive(showSetting);
    }

    public void OpenOptionBox()
    {
        if (settingBox.activeSelf)
        {
            settingBox.SetActive(false);
            showSetting = false;
        }

        showOption = !showOption;
        optionBox.SetActive(showOption);
    }
}
