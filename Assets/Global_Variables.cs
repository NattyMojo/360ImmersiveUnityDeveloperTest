using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class Global_Variables : MonoBehaviour
{
    public static Global_Variables globalVariables;     //This script to be called later for access to variables

    public VideoClip video;     //Will be set via the onClick call from the home screen
    public Texture image;

    bool gameStart;

    void Awake()
    {
        //We only want to do this once so just a check
        if(!gameStart)
        {
            globalVariables = this;
            SceneManager.LoadSceneAsync(1, LoadSceneMode.Additive);
            gameStart = true;
        }
    }
}
