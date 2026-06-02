using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour
{

    private GameObject[] Obstacles;
    private GameObject[] Box;


    void Start()
    {
        Obstacles = GameObject.FindGameObjectsWithTag("Obstacles");
        Box = GameObject.FindGameObjectsWithTag("Box");
    }

    void Update()
    {
        
    }

    public bool Move(Vector2 direction)
    {
        if (ObjBlocked(transform.position, direction))
        {
            return false;
        }
        else
        {
            transform.Translate(direction);
            return true;
        }
    }

    public bool ObjBlocked(Vector3 position, Vector2 direction)
    {
        Vector2 newpos = new Vector2(position.x, position.y) + direction;

        foreach (var obj in Obstacles)
        {
            if (obj.transform.position.x == newpos.x && obj.transform.position.y == newpos.y)
            {
                return true;
            }
        }

        foreach (var box in Box)
        {
            if (box.transform.position.x == newpos.x && box.transform.position.y == newpos.y)
            {
                return true;
            }
        }
        return false;
    }
}
