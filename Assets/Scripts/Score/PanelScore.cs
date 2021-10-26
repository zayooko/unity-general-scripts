using UnityEngine;
using TMPro;

public class PanelScore : MonoBehaviour
{
    public TextMeshProUGUI scoreTextPanel;
    public string Text;
    public static int Score;

    //SCORE PANEL
    void Update()
    {
        scoreTextPanel.text = Text + Score.ToString();
    }
}

