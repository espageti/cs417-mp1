using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Restart: MonoBehaviour
{

    public InputActionReference action;

    public void Start()
    {
        if (action != null && action.action != null)
        {
            action.action.Enable();
            action.action.performed += ctx =>
            {
                RestartGame();
            };
        }
    }
    
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
