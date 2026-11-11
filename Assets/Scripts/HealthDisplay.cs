using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    public int Health;
    public int MaxHealth;
    public Sprite EmptyHeart;
    public Sprite FullHeart;
    public Image[] Hearts;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Hearts.Length; i++)
        //a loop that runs for a set number of times, checking every frame, if there is one heart atleast it will run again
        {
        
        }

                                              
    }
}
