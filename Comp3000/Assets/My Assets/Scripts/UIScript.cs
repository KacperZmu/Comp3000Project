using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class UIScript : MonoBehaviour
{
    public GameObject panel;
    public GameObject journalImage;

    private bool panelActive = false;

    void Start()
    {
         if (panel == null || journalImage == null)
        {
            Debug.LogError("Panel or JournalImage is not assigned!");
            return;
        }

  
        panel.SetActive(false);
        journalImage.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            if (panelActive)
            {
         
                DeactivatePanel();
            }
            else
            {
              
                ActivatePanel();
                
            }
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && panelActive)
        {
 
            DeactivatePanel();
        }
    }

    void ActivatePanel()
    {
        panel.SetActive(true);
        journalImage.SetActive(false);
        panelActive = true;
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    void DeactivatePanel()
    {
        panel.SetActive(false);
        journalImage.SetActive(true);  
        panelActive = false;    
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}









