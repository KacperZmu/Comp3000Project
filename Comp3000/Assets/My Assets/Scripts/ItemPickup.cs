using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    private bool canInteract = false;

    [SerializeField]
    public int noteCounter = 0;

    [SerializeField]
    public int photoCounter = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Note"))
        {
            canInteract = true;
        }
        else if (other.CompareTag("Photo"))
        {
            canInteract = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Note"))
        {
            canInteract = false;
        }
        else if (other.CompareTag("Photo"))
        {
            canInteract = false;
        }
    }

    private void Update()
    {
        if (canInteract && Input.GetKeyDown(KeyCode.E))
        {
            Interact();
        }
    }

    private void Interact()
    {
        GameObject[] noteObjects = GameObject.FindGameObjectsWithTag("Note");
        foreach (GameObject obj in noteObjects)
        {
            Collider objCollider = obj.GetComponent<Collider>();
            if (objCollider != null && objCollider.isTrigger && GetComponent<Collider>().isTrigger &&
                objCollider.bounds.Intersects(GetComponent<Collider>().bounds))
            {
                noteCounter++; // Increment note counter
                Debug.Log("Note disabled. Total notes disabled: " + noteCounter);
                obj.SetActive(false);
            }
        }

        GameObject[] photoObjects = GameObject.FindGameObjectsWithTag("Photo");
        foreach (GameObject obj in photoObjects)
        {
            Collider objCollider = obj.GetComponent<Collider>();
            if (objCollider != null && objCollider.isTrigger && GetComponent<Collider>().isTrigger &&
                objCollider.bounds.Intersects(GetComponent<Collider>().bounds))
            {
                photoCounter++; // Increment photo counter
                Debug.Log("Photo disabled. Total photos disabled: " + photoCounter);
                obj.SetActive(false);
            }
        }
    }

}















