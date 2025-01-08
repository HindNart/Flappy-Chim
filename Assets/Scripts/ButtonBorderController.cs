using UnityEngine;
using UnityEngine.UI;

public class ButtonBorderController : MonoBehaviour
{
    private Outline outline;
    public Color selectedColor = Color.green;
    public Color defaultColor = Color.clear;

    void Start()
    {
        outline = GetComponent<Outline>();
        outline.effectColor = defaultColor;
    }

    public void SelectButton()
    {
        outline.effectColor = selectedColor;
    }

    public void DeselectButton()
    {
        outline.effectColor = defaultColor;
    }
}
