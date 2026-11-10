using UnityEngine;
using UnityEngine.SceneManagement;   // NEW at the top
using UnityEngine.InputSystem;

// The five states the game can be in. Only one at a time.
public enum GameState { Menu, Playing, Paused, Won, Lost }

public class GameManager : MonoBehaviour
{
    public GameState state = GameState.Menu;
    static bool skipStartScreen = false;

    // An announcement, like OnCoinCollected. This one carries a GameState.
    public static event System.Action<GameState> OnStateChanged;

    public static GameManager Instance;   // NEW, below OnStateChanged

    private void Awake()
    {
        Instance = this;   // NEW, below OnStateChanged
    }

    // Below OnStateChanged
    void Start()                       // CHANGED: replace your Start with this
    {
        if (skipStartScreen)
        {
            skipStartScreen = false;   // only skip once
            SetState(GameState.Playing);
        }
        else
        {
            SetState(GameState.Menu);
        }
    }
    void Update()                // NEW, below Start
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            if (state == GameState.Playing)
            {
                SetState(GameState.Paused);
            }
            else if (state == GameState.Paused)
            {
                SetState(GameState.Playing);
            }
        }
    }



    // The ONLY way the state changes
    public void SetState(GameState newState)
    {
        state = newState;
        Debug.Log("State: " + state);
        OnStateChanged?.Invoke(state);
    }
    // NEW, below SetState. Buttons call these.
    public void StartGame() { SetState(GameState.Playing); }
    public void Resume() { SetState(GameState.Playing); }

    public void PlayAgain()
    {
        skipStartScreen = true;
        Time.timeScale = 1;   // the speed survives a reload, so reset it
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Win() { SetState(GameState.Won); }

}
