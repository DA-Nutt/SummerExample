using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int score;

    public static GameManager instance {get; private set;}

        //set instance in this script's constructor
        public GameManager()
        {
            instance = this;
        }

    void Start()
    {
        score = 0;    
    }

    public void EndGame()
    {
        Debug.Log("GAME OVER");
    }

    public void WinLevel()
    {
        Debug.Log("LEVEL COMPLETE");
    }
}
