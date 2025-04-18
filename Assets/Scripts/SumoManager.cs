using System.Collections;
using UnityEngine;

public class SumoManager : MonoBehaviour
{
    public float firstPlayerScore;
    public float secondPlayerScore;
    public bool firstPlayerLost;
    public bool secondPlayerLost;
    public float gameTimer;
    public bool gameStarted;
    public bool fistHitP1;
    public bool fistHitP2;
    public bool fistBlockedP1;
    public bool fistBlockedP2;
    public bool stepOutP1;
    public bool stepOutP2;
    

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (!fistHitP1)
            {
                StartCoroutine(P1FistHitEnum());
            }
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (!fistHitP2)
            {
                StartCoroutine(P2FistHitEnum());
            }
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (!fistBlockedP1)
            {
                StartCoroutine(P1BlockedEnum());
            }
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (!fistBlockedP2)
            {
                StartCoroutine(P2BlockedEnum());
            }
        }
    }

    IEnumerator P1FistHitEnum()
    {
        fistHitP1 = true;
        yield return new WaitForSeconds(0.1f);
        if (fistHitP2)
        {
            Clash();
        }
        else if (fistBlockedP1)
        {
            P1Blocked();
        }
        else
        {
            P1Score();
        }
        fistHitP1 = false;
    }

    IEnumerator P2FistHitEnum()
    {
        fistHitP2 = true;
        yield return new WaitForSeconds(0.1f);
        if (fistHitP1)
        {
            Clash();
        }
        else if (fistBlockedP2)
        {
            P2Blocked();
        }
        else
        {
            P2Score();
        }
        fistHitP2 = false;
    }

    IEnumerator P1BlockedEnum()
    {
        fistBlockedP1 = true;
        yield return new WaitForSeconds(0.1f);
        fistBlockedP1 = false;
    }

    IEnumerator P2BlockedEnum()
    {
        fistBlockedP2 = true;
        yield return new WaitForSeconds(0.1f);
        fistBlockedP2 = false;
    }

    void Clash()
    {
        firstPlayerScore++;
        secondPlayerScore++;
    }

    void P1Score()
    {
        firstPlayerScore += 3;
    }

    void P2Score()
    {
        secondPlayerScore +=  3;
    }

    void P1Blocked()
    {
        firstPlayerScore -= 2;
    }

    void P2Blocked()
    {
        secondPlayerScore -= 2;
    }
}
