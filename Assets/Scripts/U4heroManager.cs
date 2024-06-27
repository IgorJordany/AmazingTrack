using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class U4heroManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        AudioListener.volume = 0;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        AudioListener.volume = 1;
    }

    public void MuteAllSound()
    {
        AudioListener.volume = 0;
    }

    public void UnMuteAllSound()
    {
        AudioListener.volume = 1;
    }

}
