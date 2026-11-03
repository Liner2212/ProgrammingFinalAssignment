using UnityEngine;
using TMPro;                  // Text

public class PlayerDiamonds : MonoBehaviour
{
    public int Diamonds = 0;
    public TMP_Text DiamondText;    
    public int totalDiamonds = 5;   

    void Start()                 
    {
        ShowDiamonds();
    }

    public void AddDiamonds()
    {
        Diamonds = Diamonds + 1;
        ShowDiamonds();             
    }

    void ShowDiamonds()             
    {
        DiamondText.text = "Diamonds: " + Diamonds + " / " + totalDiamonds;
    }


}
