using UnityEngine;

public class SumoManager : MonoBehaviour
{
    public float firstPlayerHealth;
    public float secondPlayerHealth;
    public bool firstPlayerLost;
    public bool secondPlayerLost;
    public float gameTimer;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            firstPlayerHealth--;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            secondPlayerHealth--;
        }
        if (gameTimer < 0)
        {
            if (firstPlayerHealth < secondPlayerHealth)
            {
                firstPlayerLost = true;
                secondPlayerLost = false;
            }
            else if (firstPlayerHealth > secondPlayerHealth)
            {
                firstPlayerLost = false;
                secondPlayerLost = true;
            }
        }
        if (firstPlayerHealth < 0)
        {
            firstPlayerLost = true;
        }
        if (secondPlayerHealth < 0)
        {
            secondPlayerLost = true;
        }
    }
}
