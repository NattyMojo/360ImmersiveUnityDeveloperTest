using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class player_load : MonoBehaviour
{
    public GameObject player;
    public GameObject image;

    /*
     * When we load the player scene, set the background image and video
     */
    void Start()
    {
        player.GetComponent<VideoPlayer>().clip = Global_Variables.globalVariables.video;
        image.GetComponent<RawImage>().texture = Global_Variables.globalVariables.image;
    }

}
