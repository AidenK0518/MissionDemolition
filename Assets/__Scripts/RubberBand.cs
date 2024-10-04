using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubberBand : MonoBehaviour
{
    public Transform LeftPoint;
    public Transform RightPoint;
    public Transform CenterPoint;

    LineRenderer rubberBand;
    
    void Start()
    {
        rubberBand = GetComponent<LineRenderer>();
    }

    void Update()
    {
        rubberBand.SetPositions(new Vector3[3] {LeftPoint.position, CenterPoint.position, RightPoint.position});
    }
}
