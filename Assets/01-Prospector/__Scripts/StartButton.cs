using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    // Method to handle button click
    public void OnStartButtonClick()
    {
        // Load the scene with the specified name
        SceneManager.LoadScene("__Prospector");
    }
}
