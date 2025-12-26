using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switchu : MonoBehaviour
{
    public GameObject Cube;
    void Start()
    {
        Cube.SetActive(false);
    }

    // Update is called once per frame
    public void Switch()
    {
        Cube.SetActive(!Cube.activeSelf);
    }
}
