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
    KeyColor color;
    public override void Picked()
    {
        GameManager.gameManager.AddKey(color);
        Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        Rotation();
    }
}