using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThemeSelectionManager : MonoBehaviour
{
    private MeshRenderer backgroundMaterial;
    public Material[] materials;
    public static Action onThemeSelected;

    void Start()
    {
        backgroundMaterial = GetComponent<MeshRenderer>();
        LoadTheme();
    }

    public void SelectTheme(int themeIndex)
    {
        if (backgroundMaterial == null || themeIndex < 0 || themeIndex >= materials.Length)
        {
            Debug.LogError("Invalid theme selection or background image not set.");
            return;
        }

        backgroundMaterial.material = materials[themeIndex];
        SaveTheme(themeIndex);

        onThemeSelected?.Invoke();
    }

    void SaveTheme(int themeIndex)
    {
        PlayerPrefs.SetInt("SelectedTheme", themeIndex);
    }

    void LoadTheme()
    {
        int savedThemeIndex = PlayerPrefs.GetInt("SelectedTheme", 0);
        backgroundMaterial.material = materials[savedThemeIndex];

        onThemeSelected?.Invoke();
    }
}