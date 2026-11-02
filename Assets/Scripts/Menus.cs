using UnityEngine;
using StarterAssets;
using UnityEngine.InputSystem;

public class Menus : MonoBehaviour
{
    public GameObject startPanel;
    public ThirdPersonController player;
    public StarterAssetsInputs playerInput;
    public GameObject pausePanel;
    bool paused = false;
    void Start()
    {
        // The game opens on the start screen
        startPanel.SetActive(true);
        SetMenuOpen(true);
    }
    void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            paused = !paused;              // flip it
            pausePanel.SetActive(paused);
            SetMenuOpen(paused);
        }
    }
// The Play button will call this.
public void StartGame()
{
    startPanel.SetActive(false);
    SetMenuOpen(false);
}
// Toggles the menu on/off
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
    player.LockCameraPosition = open;
    playerInput.cursorLocked = !open;
}
// Called by the button in the Pause menu
public void Resume()
{
    paused = false;
    pausePanel.SetActive(false);
    SetMenuOpen(false);
}

}
