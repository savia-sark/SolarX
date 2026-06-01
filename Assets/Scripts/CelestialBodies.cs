using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CelestialBodies : MonoBehaviour
{
    // Start is called before the first frame update
    private string name;
    private GameObject body;

    public string getName()
    {
        return name;
    }

    public GameObject getBody()
    {
        return body;
    }

}
