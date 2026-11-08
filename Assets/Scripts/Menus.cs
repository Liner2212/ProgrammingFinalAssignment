using UnityEngine;
using StarterAssets;

public class Menus : MonoBehaviour
{
    public GameObject startPanel;
    public ThirdPersonController player;
    public StarterAssetsInputs playerInput;

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


}
