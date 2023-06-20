using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MixMaster : Singleton<MixMaster>
{
    public float timeRemaining = 1;
    bool isInTheGoodZone;
    bool finished = false;

    void Update()
    {
        if (timeRemaining > 0 && isInTheGoodZone)
        {
            timeRemaining -= Time.deltaTime;

            Debug.Log("TICK");
        }
        else if (timeRemaining <= 0 && !finished)
        {
            finished = true;
            FinishMix();
        }
    }

    public void ResetTimer(float time)
    {
        finished = false;
        timeRemaining = time;
    }

    public void SetIsInGoodZone()
    {
        isInTheGoodZone = true;
        Debug.Log("IN");
    }

    public void SetOutOfGoodZone()
    {
        isInTheGoodZone = false;
        Debug.Log("OUT");
    }

    void FinishMix()
    {
        Debug.Log("DONE");
    }
}