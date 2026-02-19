using UnityEngine;

public class Moon : MonoBehaviour
{
    [SerializeField] private float orbitDegreesPerSecond = 30f;

    // Update is called once per frame
    void Update()
    {
        if (transform.parent == null)
        {
            return;
        }

        transform.RotateAround(transform.parent.position, Vector3.up, orbitDegreesPerSecond * Time.deltaTime);
    }
}
