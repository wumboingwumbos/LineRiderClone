using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineCreator : MonoBehaviour
{
    public GameObject linePrefab;

    Line activeLine;
    List<GameObject> allLines = new List<GameObject>();
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject lineGO = Instantiate(linePrefab);
            activeLine = lineGO.GetComponent<Line>();
            allLines.Add(lineGO);
        }

        if(Input.GetMouseButtonUp(0))
        {
            activeLine = null; 
        }

        if (activeLine != null)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            activeLine.updateLine(mousePos);
        }
        if (Input.GetKeyDown("c"))
        {
            clearLastLine();
        }
    }
    public void clearLastLine()
    {
        Destroy(allLines[allLines.Count - 1]);
        allLines.RemoveAt(allLines.Count - 1);
    }
}
