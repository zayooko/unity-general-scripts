using UnityEngine;
using TMPro;

public class PanelLevel : MonoBehaviour
{
    public TextMeshProUGUI levelTextPanel;
    public string Text;
    public static int currentLevel = 1;

    //LEVEL PANEL
    void Update()
    {
        levelTextPanel.text = Text + currentLevel.ToString();
    }
}
