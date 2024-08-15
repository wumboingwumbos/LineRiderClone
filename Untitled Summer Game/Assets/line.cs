using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public EdgeCollider2D edgeCol;

    List<Vector2> points;

    public void UpdateLine (Vector2 mousePos)
    {
        if (points == null)
        {
            points = new List<Vector2>();
            SetPoints(mousePos);
            return;
        }

        if (Vector2.Distance(points[points.Count - 1],mousePos) > .1f)
        {
            SetPoints(mousePos);
        }
    }

    void SetPoints (Vector2 point)
    {
        points.Add(point);

        lineRenderer.positionCount = points.Count;
        lineRenderer.SetPosition(points.Count - 1, point);

        if (points.Count > 1)
        {
            edgeCol.points = points.ToArray();
        }
    }
}
