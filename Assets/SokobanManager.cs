using UnityEngine;
using UnityEngine.SceneManagement;

public class SokobanManager : MonoBehaviour
{
    public GameObject[] boxes;
    public Transform[] targetPositions;
    private bool isLevelEnding = false; 


    void Update()
    {
        if (CheckWinCondition())
        {
            //string currentScene = SceneManager.GetActiveScene().name;

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }



    bool CheckWinCondition()
    {
        for (int i = 0; i < boxes.Length; i++)
        {
            bool onTarget = false;
            Vector2 boxPos = boxes[i].transform.position;

            for (int j = 0; j < targetPositions.Length; j++)
            {
                if (Vector2.Distance(boxPos, targetPositions[j].position) < 0.1f)
                {
                    onTarget = true;
                    break;
                }
            }

            if (!onTarget)
            {
                return false;
            }
        }
        return true;
    }
}
