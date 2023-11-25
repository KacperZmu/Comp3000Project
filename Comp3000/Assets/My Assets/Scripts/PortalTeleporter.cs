using UnityEngine;

public class PortalTeleporter : MonoBehaviour
{
    public Transform player;
    public Transform reciever;
    private bool playerOverlap = false;

    private void FixedUpdate()
    {
        if (playerOverlap)
        {
            // Calculate the teleportation offset
            Vector3 positionOffset = reciever.position - transform.position;

            // Teleport the player
            player.position = player.position + positionOffset;

            Debug.Log("Teleported Player to: " + player.position);

            playerOverlap = false; // Reset overlap flag
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered teleporter trigger zone");
            playerOverlap = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player exited teleporter trigger zone");
            // You can choose whether to reset the playerOverlap flag on exit or leave it as is
            // playerOverlap = false;
        }
    }
}
