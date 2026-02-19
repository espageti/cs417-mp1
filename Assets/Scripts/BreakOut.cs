using UnityEngine;
using UnityEngine.InputSystem;

public class BreakOut : MonoBehaviour
{
    [SerializeField] private Vector3 insidePosition;
    [SerializeField] private Vector3 outsidePosition;
    public InputActionReference action;

    private bool isOutside;

    private void Awake()
    {
        if (insidePosition == default)
        {
            insidePosition = transform.position;
        }
    }

    private void Start()
    {
        if (action != null && action.action != null)
        {
            action.action.Enable();
            action.action.performed += ctx =>
            {
                ToggleBreakout();
            };
        }
    }

    public void ToggleBreakout()
    {
        if (!isOutside)
        {
            insidePosition = transform.position;
            transform.position = outsidePosition;
            isOutside = true;
        }
        else
        {
            transform.position = insidePosition;
            isOutside = false;
        }
    }
}
