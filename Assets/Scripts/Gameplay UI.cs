using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameplayUI : MonoBehaviour
{
    public GameObject tutorialText;
    public float tutorialTextDuration = 3f;

    public TMP_Text armsText;
    public TMP_Text bodyText;
    public TMP_Text headText;
    public TMP_Text legsText;

    public GameObject promptWinUI; 
    public float promptWinUIDuration = 3f;


    void Start()
    {
        if (promptWinUI != null)
        {
            promptWinUI.SetActive(false);
        }
        if (tutorialText != null) //  needs to disappear at set time, so coroutine
        {
            tutorialText.SetActive(true);
            StartCoroutine(HidetutorialTextAfterDelay());
        }
        SetTextColors(Color.white);
    }

    private IEnumerator HidetutorialTextAfterDelay()
    {
        yield return new WaitForSeconds(tutorialTextDuration);

        if (tutorialText != null)
        {
            tutorialText.SetActive(false);
        }
    }

    public void SetTextColors(Color color)
    {
        if (armsText != null) armsText.color = color;
        if (bodyText != null) bodyText.color = color;
        if (headText != null) headText.color = color;
        if (legsText != null) legsText.color = color;
    }

    // change the color of a specific text
    public void ChangeTextColor(TMP_Text textObject, Color color)
    {
        if (textObject != null)
        {
            textObject.color = color;
        }
    }

    public IEnumerator HideWinPromptUIAfterDelay()
    {
        yield return new WaitForSeconds(promptWinUIDuration);

        if (promptWinUI != null)
        {
            promptWinUI.SetActive(false);
        }
    }
}
