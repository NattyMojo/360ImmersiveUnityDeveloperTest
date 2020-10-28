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
using UnityEngine.Video;

public class click : MonoBehaviour, IPointerClickHandler
{
    public Texture texture;
    public VideoClip video;
    /*
     * This just switches to the correct scene when a video thumbnail is clicked
     */
    public void OnPointerClick(PointerEventData eventData)
    {
        Global_Variables.globalVariables.video = video;     //Set the variables we will need in the future
        Global_Variables.globalVariables.image = texture;
        SceneManager.LoadSceneAsync(2, LoadSceneMode.Additive);     //Load the player scene
        SceneManager.UnloadSceneAsync(1);       //Unload the home scene
    }
}
