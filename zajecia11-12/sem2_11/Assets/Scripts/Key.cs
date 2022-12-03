using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum KeyColor
{
    Red,
    Blue,
    Gold
}
public class Key : PickUp
{
    public KeyColor color;
    public override void Picked()
    {
        GameManager.gameManager.AddKey(color);
        Debug.Log("Podnios³eœ " + color  + " klucz");
        Destroy(this.gameObject);
    }
    void Update()
    {
        Rotation();
    }
}
