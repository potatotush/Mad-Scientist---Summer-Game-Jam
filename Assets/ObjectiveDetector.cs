using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveDetector : Singleton<ObjectiveDetector>
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        MixMaster.Instance.SetIsInGoodZone();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        MixMaster.Instance.SetOutOfGoodZone();
    }
}
