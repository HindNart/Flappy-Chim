using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSelectionManager : MonoBehaviour
{
    public GameObject[] birds;

    private void Start()
    {
        HideCharacter();
        LoadCharacter();
    }

    private void HideCharacter()
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

    private void SaveCharacter(int characterIndex)
    {
        PlayerPrefs.SetInt("SelectedCharacter", characterIndex);
    }

    private void LoadCharacter()
    {
        int savedCharacterIndex = PlayerPrefs.GetInt("SelectedCharacter", 0);
        birds[savedCharacterIndex].SetActive(true);
    }
}