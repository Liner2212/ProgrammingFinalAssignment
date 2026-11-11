using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    //creating the heart display and to fill in the empty and full hearts, removing hearts when damaged and displaying empty hearts
    public int Health;
    public int MaxHealth;
    public Sprite EmptyHeart;
    public Sprite FullHeart;
    public Image[] Hearts;

    public PlayerHealth playerHealth;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    { //make sure its checking in the playerhealth script and that the variables are equal
        Health = playerHealth.health;
        MaxHealth = playerHealth.maxHealth;


        for (int i = 0; i < Hearts.Length; i++)
        //a loop that runs for a set number of times, checking every frame, if there is one heart atleast it will run again
        {

            if (i < Health)
            {
                Hearts[i].sprite = FullHeart;
            }
            else
            {
                Hearts[i].sprite = EmptyHeart;
            }


            if (i < MaxHealth)
            {
                Hearts[i].enabled = true;
            }
            //if i (0) is less than the max health then its enabled
            else
            {
                Hearts[i].enabled = false;

            }
        }
    }
}

