using UnityEngine;
using TMPro;                  // Text

public class PlayerSoulOrbs : MonoBehaviour
{
    public int SoulOrbs = 0;
    public TMP_Text SoulOrbsText;    
    public int totalSoulOrbs = 5;   

    void Start()                 
    {
        ShowSoulOrbs();
    }

    public void AddSoulOrbs()
    {
        SoulOrbs = SoulOrbs + 1;
        ShowSoulOrbs();             
    }

    void ShowSoulOrbs()             
    {
        SoulOrbs.text = "SoulOrbs: " + SoulOrbs + " / " + totalSoulOrbs;
    }


}
