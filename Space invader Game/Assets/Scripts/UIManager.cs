using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

    public void OnStartButtonClick()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void OnBackToMenuButtonClick()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
