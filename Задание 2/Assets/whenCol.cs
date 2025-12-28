using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class whenCol : MonoBehaviour
{
    public TMP_Text label;
    public int hp;
    void Start()
    {
        hp = 10;
        label.text = "’œ:" + hp;
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Cube")
        {
            hp--;
            label.text = "’œ:" + hp;
        }
    }
}
