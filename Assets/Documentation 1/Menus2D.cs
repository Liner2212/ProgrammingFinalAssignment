using UnityEngine;

// Menus2D: the Menus script from Class 16, without the Starter Assets parts.
// Use it in a 2D or UI-based game, instead of Menus.
//
// It needs the GameManager from Class 16 in your scene (it listens to
// GameManager.OnStateChanged). Your buttons still call the GameManager:
// Play > StartGame, Resume > Resume, Play Again > PlayAgain.

public class Menus2D : MonoBehaviour
{
    public GameObject startPanel;
    public GameObject pausePanel;
    public GameObject winPanel;
    public GameObject lostPanel;

    // Optional: drag your player's movement script here (for example, PlayerMove2D).
    // It gets switched off while a menu is open, so a key press on the pause
    // screen doesn't make the player jump when the game starts again.
    // Leave it empty if your game has no player to move.
    public MonoBehaviour playerControls;

    void OnEnable()  { GameManager.OnStateChanged += ShowScreen; }   // tune in
    void OnDisable() { GameManager.OnStateChanged -= ShowScreen; }   // tune out

    // The GameManager announces every new state. I show the screen that matches it.
    void ShowScreen(GameState state)
    {
        startPanel.SetActive(state == GameState.Menu);
        pausePanel.SetActive(state == GameState.Paused);
        winPanel.SetActive(state == GameState.Won);
        lostPanel.SetActive(state == GameState.Lost);
        SetMenuOpen(state != GameState.Playing);
    }

    void SetMenuOpen(bool open)
    {
        // Freeze the world while a menu is open, and run it again when it closes
        if (open)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }

        // Switch the player's controls off while a menu is open.
        // != null means: only if the slot has something in it.
        if (playerControls != null)
        {
            playerControls.enabled = !open;
        }

        // What's different from the 3D Menus:
        // no camera to lock, and the mouse stays visible and free,
        // because 2D and UI-based games usually need it.
    }
}
