using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pont : MonoBehaviour
{
    public double point = 0;
    public CanvasScript can;

    private void Update()
    {
        can.ShowScore(point);
    }

}
