using UnityEngine;
using UnityEngine.Events;

public class AddLevel : MonoBehaviour
{
    
    private int updateInterval;
    private int resetGoals = 0;
    
    public int intervalPointsToLevelUp; 

    public int LevelToGoal_1;
    public int LevelToGoal_2;
    public int LevelToGoal_3;
    
    public UnityEvent onLevelUp;
    public UnityEvent onLevelGoal_1;
    public UnityEvent onLevelGoal_2;
    public UnityEvent onLevelGoal_3;

    //START
    void Start()
    {
        updateInterval = intervalPointsToLevelUp;
    }


    //EVENT
    void OnTriggerExit() 
    {    
        //GOAL EVENT FOR EACH LEVEL UP (OPTIONAL)            
        if (intervalPointsToLevelUp <= PanelScore.Score)
        {
            onLevelUp.Invoke();            
        }

        
        //LEVEL UP
        while (intervalPointsToLevelUp <= PanelScore.Score)
        {
            PanelLevel.currentLevel = (PanelScore.Score / updateInterval);
            PanelLevel.currentLevel++;
            intervalPointsToLevelUp = intervalPointsToLevelUp + updateInterval;
        }


        
        //SPECIAL LEVEL GOALS (OPTION)
        if (LevelToGoal_1 <= PanelLevel.currentLevel && LevelToGoal_1 != resetGoals)
        {
            onLevelGoal_1.Invoke();
            LevelToGoal_1 = resetGoals;
        }

        if (LevelToGoal_2 <= PanelLevel.currentLevel && LevelToGoal_2 != resetGoals)
        {
            onLevelGoal_2.Invoke();
            LevelToGoal_2 = resetGoals;
        }

        if (LevelToGoal_3 <= PanelLevel.currentLevel && LevelToGoal_3 != resetGoals)
        {
            onLevelGoal_3.Invoke();
            LevelToGoal_3 = resetGoals;
        }
    }        
}