using UnityEngine;
using UnityEngine.SceneManagement;

public class DebugLog : MonoBehaviour
{
    // Start is called once 
    void Start()
    {
        // Printing a debug to test how Start works
        Debug.Log("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("Main");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
