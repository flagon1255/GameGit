using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[Serializable]
public class Hiscores
{
    private string name;
    private int points;

    public Hiscores(string name, int points)
    {
        this.name = name;
        this.points = points;
    }
    
    public string getname()
    {
        return name;
    }

    public void setname(string name)
    {
        this.name = name;
    }
    public int getpoints()
    {
        return points;
    }

    public void setpoints(int points)
    {
        this.points = points;
    }
}
