using UnityEngine;
using UnityEngine.UI;

public class ToggleSpeakerBtn : MonoBehaviour
{
    public Sprite speakerOn;
    public Sprite speakerOff;
    private Image buttonImage;
    private bool isSpeakerOn = true;

    void Start()
    {
        buttonImage = GetComponent<Image>();
        buttonImage.sprite = speakerOn;
    }

    public void ToggleSpeaker()
    {
        isSpeakerOn = !isSpeakerOn;

        if (isSpeakerOn)
        {
            buttonImage.sprite = speakerOn;
        }
        else
        {
            buttonImage.sprite = speakerOff;
        }
    }
}