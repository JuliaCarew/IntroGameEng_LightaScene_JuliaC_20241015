using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Winscreen : MonoBehaviour
{
    public GameObject winScreen;
    private void Start()
    {
        winScreen.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("Goal"))
        {
            Debug.Log("Triggered Goal");
            winScreen.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void QuitToMenu()
    {
        Debug.Log("Quit to menu");
        SceneManager.LoadScene(0);
    }
}
