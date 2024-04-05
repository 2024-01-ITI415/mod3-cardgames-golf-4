using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGolf : MonoBehaviour
{
    public void OnStartButtonClick()
    {
        SceneManager.LoadScene("__Golf");
    }
}
