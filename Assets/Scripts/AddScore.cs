using UnityEngine;
using UnityEngine.Events;

public class AddScore : MonoBehaviour
{    
    private int resetScoreGoal;

    public int Points;
    public int scoreGoal;

    public UnityEvent onGoalScore;
    
    public static int globalPoints;


    //START
    void Start()
    {
        globalPoints = Points;
    }


    
    //EVENT    
    void OnTriggerEnter() 
    {
        //ADD POINTS
        PanelScore.Score += Points;

        //EVENT SCORE (OPTION)        
        if (scoreGoal == PanelScore.Score)
            {
            onGoalScore.Invoke();
            scoreGoal = resetScoreGoal;
            }
    }
}

