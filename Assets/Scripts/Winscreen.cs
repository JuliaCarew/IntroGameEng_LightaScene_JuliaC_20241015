using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Winscreen : MonoBehaviour
{
    public GameObject winScreen;
    public Pickups pickupsref;
    private void Start()
    {
        if (winScreen != null)
        {
            winScreen.SetActive(false); // win screen starts inactive
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Triggered Goal");
            if (pickupsref != null && pickupsref.collectedPartsCount >= pickupsref.totalParts)
            {
                ShowWinScreen();
            }
        }
    }

    public void QuitToMenu()
    {
        Debug.Log("Quit to menu");
        SceneManager.LoadScene(0);
    }

    public void ShowWinScreen()
    {
        if (winScreen != null)
        {
            winScreen.SetActive(true);
            Time.timeScale = 0f; 
            Cursor.lockState = CursorLockMode.None; 
            Cursor.visible = true; 
        }
    }
}
