using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSelectionManager : MonoBehaviour
{
    public GameObject[] birds;

    void Start()
    {
        HideCharacter();
        LoadCharacter();
    }

    void HideCharacter()
    {
        foreach (var character in birds)
        {
            character.SetActive(false);
        }
    }

    public void SelectCharacter(int characterIndex)
    {
        HideCharacter();
        birds[characterIndex].SetActive(true);
        SaveCharacter(characterIndex);
    }

    void SaveCharacter(int characterIndex)
    {
        PlayerPrefs.SetInt("SelectedCharacter", characterIndex);
    }

    void LoadCharacter()
    {
        int savedCharacterIndex = PlayerPrefs.GetInt("SelectedCharacter", 0);
        birds[savedCharacterIndex].SetActive(true);
    }
}