using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }
    public GameObject touchToPlay;
    public GameObject btnReplay;
    public GameObject btnOption;
    public GameObject btnSetting;
    public GameObject settingBox;
    public GameObject optionBox;
    private bool showSetting = false;
    private bool showOption = false;

    private void Awake()
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

    private void Start()
    {
        if (btnReplay != null)
        {
            btnReplay.SetActive(false);
        }
    }

    public void HideUI()
    {
        if (touchToPlay != null)
        {
            touchToPlay.SetActive(false);
        }
        else if (btnSetting != null)
        {
            btnSetting.SetActive(false);
        }
        else if (btnOption != null)
        {
            btnOption.SetActive(false);
        }
        if (settingBox.activeSelf || optionBox.activeSelf)
        {
            settingBox.SetActive(false);
            optionBox.SetActive(false);
        }
    }

    public void OpenSettingBox()
    {
        if (optionBox != null && optionBox.activeSelf)
        {
            optionBox.SetActive(false);
            showOption = false;
        }

        showSetting = !showSetting;
        settingBox.SetActive(showSetting);
    }

    public void OpenOptionBox()
    {
        if (settingBox != null && settingBox.activeSelf)
        {
            settingBox.SetActive(false);
            showSetting = false;
        }

        showOption = !showOption;
        optionBox.SetActive(showOption);
    }
}
