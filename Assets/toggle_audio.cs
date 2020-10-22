using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class toggle_audio : MonoBehaviour
{
    public GameObject audioSource;
    public GameObject button;
    public Sprite onSprite;
    public Sprite offSprite;
    bool soundToggle = true;

    //Currently there is no audio with the videos, though this will pretend there is and change the sprite shown
    public void toggleAudio()
    {
        Image image = button.GetComponent<Image>();
        soundToggle = !soundToggle;
        if(soundToggle)
        {
            //audioSource.SetActive(true);      leaving these in here even though the videos have no audio
            image.sprite = onSprite;
        }
        else
        {
            //audioSource.SetActive(false);
            image.sprite = offSprite;
        }
    }
}
