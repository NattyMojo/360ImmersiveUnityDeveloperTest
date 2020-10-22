using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class toggle_play : MonoBehaviour
{
    public GameObject player;
    public GameObject button;
    public Sprite playSprite;
    public Sprite pauseSprite;
    public bool playToggle = false;
    public GameObject preload_image;    //Having a preload image so that the screen is not staring into empty space upon load

    /*
     * when the play/pause button is clicked this method will flop the playToggle value and play the video or pause the video
     * Will also get rid of the preload image before playing the video
     */
    public void togglePlay()
    {

        Image image = button.GetComponent<Image>();
        VideoPlayer video = player.GetComponent<VideoPlayer>();
        playToggle = !playToggle;
        if (playToggle)
        {
            video.Play();
            StartCoroutine(Sleep());    //There is a delay for when the video actually displays
            image.sprite = pauseSprite;
        }
        else
        {
            video.Pause();
            image.sprite = playSprite;
        }
    }

    IEnumerator Sleep()
    {
        yield return new WaitForSeconds(0.3f);  //Short delay between starting the video and removing the image to give the video time to render
        preload_image.GetComponent<RawImage>().CrossFadeAlpha(0, 0.0f, false);  //Get rid of the preload image so the video can play through
    }
}

