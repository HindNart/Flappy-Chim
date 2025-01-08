using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThemeSelectionManager : MonoBehaviour
{
    public SpriteRenderer backgroundImage1;
    public SpriteRenderer backgroundImage2;
    public Sprite[] themes;

    void Start()
    {
        LoadTheme();
    }

    public void SelectTheme(int themeIndex)
    {
        backgroundImage1.sprite = themes[themeIndex];
        backgroundImage2.sprite = themes[themeIndex];
        SaveTheme(themeIndex);
    }

    void SaveTheme(int themeIndex)
    {
        PlayerPrefs.SetInt("SelectedTheme", themeIndex);
    }

    void LoadTheme()
    {
        int savedThemeIndex = PlayerPrefs.GetInt("SelectedTheme", 0);
        backgroundImage1.sprite = themes[savedThemeIndex];
        backgroundImage2.sprite = themes[savedThemeIndex];
    }
}