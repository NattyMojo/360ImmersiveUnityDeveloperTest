using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using static UnityEngine.Application;

public class click : MonoBehaviour, IPointerClickHandler
{
    /*
     * This just switches to the correct scene when a video thumbnail is clicked
     */
    public void OnPointerClick(PointerEventData eventData)
    {
        string objName = name;
        if (objName == "4k_fire")       //I promise I tried figuring out how to just update the player url but it was not having it, so I made multiple players
        {
            SceneManager.LoadScene("4k_forest_videoplayer");
        }
        else if (objName == "huge_flames")
        {
            SceneManager.LoadScene("huge_flames_videoplayer");
        }
        else if (objName == "remains_steepe")
        {
            SceneManager.LoadScene("remains_videoplayer");
        }
        else if (objName == "socal_fire")
        {
            SceneManager.LoadScene("socal_videoplayer");
        }
        else if (objName == "steepe_night")
        {
            SceneManager.LoadScene("steepe_videoplayer");
        }
        else if (objName == "videoblock_fire")
        {
            SceneManager.LoadScene("videoblock_videoplayer");
        }
    }
}
