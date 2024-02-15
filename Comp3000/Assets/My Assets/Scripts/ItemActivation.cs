using UnityEngine;
using UnityEngine.UI;

public class ItemActivation : MonoBehaviour
{
    [SerializeField]
    [Header("Notes")]
    private GameObject objectToEnableNote;
    [SerializeField]
    private GameObject objectToEnableNote1;
    [SerializeField]
    private GameObject objectToEnableNote2;
    [SerializeField]
    private GameObject objectToEnableNote3;
    [SerializeField]
    private GameObject objectToEnableNote4;
    [SerializeField]
    private GameObject objectToEnableNote5;
    [SerializeField]
    private GameObject objectToEnableNote6;
    [SerializeField]
    private GameObject objectToEnableNote7;
    [SerializeField]
    private GameObject objectToEnableNote8;
    [SerializeField]
    private GameObject objectToEnableNote9;
    [SerializeField]
    private GameObject objectToEnableNote10;
    [SerializeField]
    private GameObject objectToEnableNote11;
    [SerializeField]
    private GameObject objectToEnableNote12;
    [SerializeField]
    private GameObject objectToEnableNote13;
    [SerializeField]
    private GameObject objectToEnableNote14;
    [SerializeField]
    private GameObject objectToEnableNote15;
    [SerializeField]
    private GameObject objectToEnableNote16;
    [SerializeField]
    private GameObject objectToEnableNote17;


    [SerializeField]
    [Header("Photos")]
    private GameObject objectToEnablePhoto;
    [SerializeField]
    private GameObject objectToEnablePhoto1;
    [SerializeField]
    private GameObject objectToEnablePhoto2;
    [SerializeField]
    private GameObject objectToEnablePhoto3;
    [SerializeField]
    private GameObject objectToEnablePhoto4;

    [SerializeField]
    private ItemPickup itemPickup;

    private void Update()
    {
        ActivateObjects();

        // Check for right arrow key press
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            BringBottomObjectToTop();
        }
    }

    private void ActivateObjects()
    {
        if (itemPickup == null)
        {
            Debug.LogError("ItemPickup reference is not set.");
            return;
        }

        // Check noteCounter and enable object if it's 1 and has the tag "Journalinfo"
        if (itemPickup.noteCounter == 1 && objectToEnableNote != null && objectToEnableNote.CompareTag("Journalinfo"))
        {
            objectToEnableNote.SetActive(true);
            Debug.Log("Note object enabled 1.");
        }
        if (itemPickup.noteCounter == 2 && objectToEnableNote1 != null && objectToEnableNote1.CompareTag("Journalinfo"))
        {
            objectToEnableNote1.SetActive(true);
            Debug.Log("Note object enabled 2.");
        }
        if (itemPickup.noteCounter == 3 && objectToEnableNote2 != null && objectToEnableNote2.CompareTag("Journalinfo"))
        {
            objectToEnableNote2.SetActive(true);
            Debug.Log("Note object enabled 3.");
        }
        if (itemPickup.noteCounter == 4 && objectToEnableNote3 != null && objectToEnableNote3.CompareTag("Journalinfo"))
        {
            objectToEnableNote3.SetActive(true);
            Debug.Log("Note object enabled 4.");
        }
        if (itemPickup.noteCounter == 5 && objectToEnableNote4 != null && objectToEnableNote4.CompareTag("Journalinfo"))
        {
            objectToEnableNote4.SetActive(true);
            Debug.Log("Note object enabled 5.");
        }
        if (itemPickup.noteCounter == 6 && objectToEnableNote5 != null && objectToEnableNote5.CompareTag("Journalinfo"))
        {
            objectToEnableNote5.SetActive(true);
            Debug.Log("Note object enabled 6.");
        }
        if (itemPickup.noteCounter == 7 && objectToEnableNote6 != null && objectToEnableNote6.CompareTag("Journalinfo"))
        {
            objectToEnableNote6.SetActive(true);
            Debug.Log("Note object enabled 7.");
        }
        if (itemPickup.noteCounter == 8 && objectToEnableNote7 != null && objectToEnableNote7.CompareTag("Journalinfo"))
        {
            objectToEnableNote7.SetActive(true);
            Debug.Log("Note object enabled 8.");
        }
        if (itemPickup.noteCounter == 9 && objectToEnableNote8 != null && objectToEnableNote8.CompareTag("Journalinfo"))
        {
            objectToEnableNote8.SetActive(true);
            Debug.Log("Note object enabled 9.");
        }
        if (itemPickup.noteCounter == 10 && objectToEnableNote9 != null && objectToEnableNote9.CompareTag("Journalinfo"))
        {
            objectToEnableNote9.SetActive(true);
            Debug.Log("Note object enabled 10.");
        }
        if (itemPickup.noteCounter == 11 && objectToEnableNote10 != null && objectToEnableNote10.CompareTag("Journalinfo"))
        {
            objectToEnableNote10.SetActive(true);
            Debug.Log("Note object enabled 11.");
        }
        if (itemPickup.noteCounter == 12 && objectToEnableNote11 != null && objectToEnableNote11.CompareTag("Journalinfo"))
        {
            objectToEnableNote11.SetActive(true);
            Debug.Log("Note object enabled 12.");
        }
        if (itemPickup.noteCounter == 13 && objectToEnableNote12 != null && objectToEnableNote12.CompareTag("Journalinfo"))
        {
            objectToEnableNote12.SetActive(true);
            Debug.Log("Note object enabled 13.");
        }
        if (itemPickup.noteCounter == 14 && objectToEnableNote13 != null && objectToEnableNote13.CompareTag("Journalinfo"))
        {
            objectToEnableNote13.SetActive(true);
            Debug.Log("Note object enabled 14.");
        }
        if (itemPickup.noteCounter == 15 && objectToEnableNote14 != null && objectToEnableNote14.CompareTag("Journalinfo"))
        {
            objectToEnableNote14.SetActive(true);
            Debug.Log("Note object enabled 15.");
        }
        if (itemPickup.noteCounter == 16 && objectToEnableNote15 != null && objectToEnableNote15.CompareTag("Journalinfo"))
        {
            objectToEnableNote15.SetActive(true);
            Debug.Log("Note object enable 16d.");
        }
        if (itemPickup.noteCounter == 17 && objectToEnableNote16 != null && objectToEnableNote16.CompareTag("Journalinfo"))
        {
            objectToEnableNote16.SetActive(true);
            Debug.Log("Note object enabled 17.");
        }
        if (itemPickup.noteCounter == 18 && objectToEnableNote17 != null && objectToEnableNote17.CompareTag("Journalinfo"))
        {
            objectToEnableNote17.SetActive(true);
            Debug.Log("Note object enabled 18.");
        }

        // Check photoCounter and enable object if it's 1 and has the tag "Journalinfo"
        if (itemPickup.photoCounter == 1 && objectToEnablePhoto != null && objectToEnablePhoto.CompareTag("Journalinfo"))
        {
            objectToEnablePhoto.SetActive(true);
            Debug.Log("Photo object enabled 1.");
        }
        if (itemPickup.photoCounter == 2 && objectToEnablePhoto1 != null && objectToEnablePhoto1.CompareTag("Journalinfo"))
        {
            objectToEnablePhoto1.SetActive(true);
            Debug.Log("Photo object enabled 2.");
        }
        if (itemPickup.photoCounter == 3 && objectToEnablePhoto2 != null && objectToEnablePhoto2.CompareTag("Journalinfo"))
        {
            objectToEnablePhoto2.SetActive(true);
            Debug.Log("Photo object enabled 3.");
        }
        if (itemPickup.photoCounter == 4 && objectToEnablePhoto3 != null && objectToEnablePhoto3.CompareTag("Journalinfo"))
        {
            objectToEnablePhoto3.SetActive(true);
            Debug.Log("Photo object enabled 4.");
        }
        if (itemPickup.photoCounter == 5 && objectToEnablePhoto4 != null && objectToEnablePhoto4.CompareTag("Journalinfo"))
        {
            objectToEnablePhoto4.SetActive(true);
            Debug.Log("Photo object enabled 5.");
        }
    }

    // Method to bring the bottom object to the top
    private void BringBottomObjectToTop()
    {
        Transform bottomObject = FindBottomObject();
        if (bottomObject != null)
        {
            bottomObject.SetAsLastSibling();
        }
    }

    // Method to find the bottom-most object with the tag "Journalinfo" in the hierarchy
    private Transform FindBottomObject()
    {
        Transform bottomObject = null;
        int lowestSiblingIndex = int.MaxValue;

        // Check each child's index
        foreach (Transform child in transform)
        {
            if (child.CompareTag("Journalinfo") && child.gameObject.activeSelf && child.GetSiblingIndex() <= lowestSiblingIndex)
            {
                lowestSiblingIndex = child.GetSiblingIndex();
                bottomObject = child;
            }
        }

        return bottomObject;
    }
}

