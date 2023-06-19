using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShiftChildToFront : MonoBehaviour
{
    public void ShiftToFront()
    {
        transform.SetSiblingIndex(2);
    }
}
