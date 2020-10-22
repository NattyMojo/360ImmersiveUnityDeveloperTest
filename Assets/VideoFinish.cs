using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using UnityEngine.UI;

public class VideoFinish : MonoBehaviour
{
    private VideoPlayer player;
    public GameObject playButton;
    public Sprite playSprite;
    private Image image;
    private toggle_play script;

    //Set variables that need to be used later
    void Start()
    {
        player = GameObject.Find("Video Player").GetComponent<VideoPlayer>();
        image = playButton.GetComponent<Image>();
        script = playButton.GetComponent<toggle_play>();
    }

    //This is just used to update the play button and toggle variable to clean out a double click at the end of the video.
    void Update()
    {
        if(player.isPaused)
        {
            script.playToggle = false;
            image.sprite = playSprite;
        }
    }
}
