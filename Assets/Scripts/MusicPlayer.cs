using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour
{
    private void Start()
    {
        Invoke("LoadFirstScene", 2);
    }

    void LoadFirstScene()
    {
        SceneManager.LoadScene(1);
    }
}
