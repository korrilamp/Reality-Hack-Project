using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuSceneLogic : MonoBehaviour
{
    public void loadGame()
    {
        SceneManager.LoadScene(1);
    }

}
