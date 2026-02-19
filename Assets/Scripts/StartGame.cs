using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField] private Transform objectToTeleport;
    [SerializeField] private Transform destinationLocation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TeleportToDestination()
    {
        if (objectToTeleport != null && destinationLocation != null)
        {
            objectToTeleport.position = destinationLocation.position;
        }
    }
}
