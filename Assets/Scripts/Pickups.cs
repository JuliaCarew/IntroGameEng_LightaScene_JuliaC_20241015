using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{
    public GameObject arms;
    public GameObject body;
    public GameObject head;
    public GameObject legs;

    public GameplayUI gameplayUI;

    public int collectedPartsCount = 0; // Counter for collected parts
    public int totalParts = 4; // Total number of parts to collect

    void Update()
    {
        if (collectedPartsCount >= totalParts)
        {
            gameplayUI.HideWinPromptUIAfterDelay();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            arms.gameObject.SetActive(false);
            Debug.Log("Picked up arms");
            gameplayUI.ChangeTextColor(gameplayUI.armsText, Color.red);
            collectedPartsCount++;
        }  
        if (other.gameObject.CompareTag("PickUpBody"))
        {
            body.gameObject.SetActive(false);
            Debug.Log("Picked up body");
            gameplayUI.ChangeTextColor(gameplayUI.bodyText, Color.red);
            collectedPartsCount++;
        }     
        if (other.gameObject.CompareTag("PickUpHead"))
        {
            head.gameObject.SetActive(false);
            Debug.Log("Picked up head");
            gameplayUI.ChangeTextColor(gameplayUI.headText, Color.red);
            collectedPartsCount++;
        } 
        if (other.gameObject.CompareTag("PickUpLegs"))
        {
            legs.gameObject.SetActive(false);
            Debug.Log("Picked up legs");
            gameplayUI.ChangeTextColor(gameplayUI.legsText, Color.red);
            collectedPartsCount++;
        } 
    }
}
