using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public static class CubeState
{
    public static Dictionary<string, float> settings = new Dictionary<string, float>();

    public static float getSpeed()
    {
        return settings["speed"];
    }
    public static float getDistance()
    {
        return settings["distance"];
    }
    public static float getSpawnRate()
    {
        return settings["spawnRate"];
    }
}
