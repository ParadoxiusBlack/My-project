using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public int sceneToLoad;

    // Start is called before the first frame update
    public void StartGame()
    {
        SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Click);
        SceneManager.LoadScene(sceneToLoad); // Scene to Load
        Debug.Log("New Scene Loaded!");
    }

   public void QuitGame()
   {
        SfxManager.sfxInstance.Audio.PlayOneShot(SfxManager.sfxInstance.Click);
        Application.Quit();
        Debug.Log("Quit Game!");
   }
}
