using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;


public class Menus : MonoBehaviour
{
    public GameObject startPanel;
    public GameObject pausePanel;

    void Start()
    {
        
        startPanel.SetActive(true);
        SetMenuOpen(true);
    }

    public void StartGame()
    {
        startPanel.SetActive(false);
        SetMenuOpen(false);
    }

    public void PauseGame()
    {
       if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            pausePanel.SetActive(true);
            SetMenuOpen(true);
        }
    }

    public void ResumeGame()
    {
        pausePanel.SetActive(false);
        SetMenuOpen(false);
    }

public void QuitGame()
    {
        Application.Quit();
    }

    void SetMenuOpen(bool open)
    {
        if (open)
        {
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Time.timeScale = 1;
            Cursor.lockState = CursorLockMode.Locked;
        }
      
    }


}
