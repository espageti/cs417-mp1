using UnityEngine;
using UnityEngine.InputSystem;

public class LightSwitch : MonoBehaviour
{
    public Light light;
    public InputActionReference action;
    [SerializeField] private Color[] colors = { Color.red, Color.green, Color.blue };

    private int colorIndex;

    private void Awake()
    {
        if (light == null)
        {
            light = GetComponent<Light>();
        }
    }

    private void Start()
    {
        if (action != null && action.action != null)
        {
            action.action.Enable();
            action.action.performed += ctx =>
            {
                SwitchColor();
            };
        }
    }

    public void SwitchColor()
    {
        if (light == null || colors == null || colors.Length == 0)
        {
            return;
        }

        colorIndex = (colorIndex + 1) % colors.Length;
        light.color = colors[colorIndex];
    }
}
