using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class home_click : MonoBehaviour
{
    //Load the home screen when home button is clicked from within a player.
    public void goHome()
    {
        SceneManager.LoadSceneAsync(1, LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync(2);
    }
}
