using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OceanBoundary : MonoBehaviour
{
    public static float leftSide = -344f;
    public static float rightSide = 344f;
    public float internalLeft;
    public float internalRight;

   
    void Update()
    {
        internalLeft = leftSide;
        internalRight = rightSide;
    }
}
