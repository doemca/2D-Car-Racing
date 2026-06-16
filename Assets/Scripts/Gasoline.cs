using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gasoline : MonoBehaviour
{
    public Image gasol;

    void Start()
    {
        
    }

    void Update()
    {
        gasol.fillAmount -= Input.GetAxis("Horizontal") / 1000f;
    }

    public void AddFuel()
    {
        gasol.fillAmount += 0.3f;
    }
}
