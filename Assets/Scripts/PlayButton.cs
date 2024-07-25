using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public AudioSource click;
    
    public void Play()
    {
        click.Play();
        PlayerPrefs.SetInt("isAIEnabled", 0);
        StartCoroutine(PlayGame());

    }
    public void PlayVsAI()
    {
        click.Play();
        PlayerPrefs.SetInt("isAIEnabled", 1);
        StartCoroutine(PlayGame());
        
    }
    public void PlayAgain()
    {
        click.Play();
        PlayerPrefs.SetInt("isAIEnabled", 0);
        StartCoroutine(ToMainMenu());
    }
    public IEnumerator PlayGame()
    {
        yield return new WaitForSeconds(click.clip.length);
        SceneManager.LoadScene("Game");
    }
    public IEnumerator ToMainMenu()
    {
        yield return new WaitForSeconds(click.clip.length);
        SceneManager.LoadScene("MainMenu");
    }
    
}
