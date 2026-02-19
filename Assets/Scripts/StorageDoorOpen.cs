using UnityEngine;

public class StorageDoorOpen : MonoBehaviour
{
    [SerializeField] private Transform doorTransform;
    [SerializeField] private Light pointLight;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // This can be called from XR Socket Hover Enter event
    public void OpenDoorAndTurnOnLight()
    {
        // Turn on the point light
        if (pointLight != null)
        {
            pointLight.enabled = true;
        }

        // Rotate the door from 90 degrees to 0 degrees
        if (doorTransform != null)
        {
            doorTransform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
