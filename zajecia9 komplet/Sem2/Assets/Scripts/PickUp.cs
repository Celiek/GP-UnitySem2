using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private void Update()
    {
        Rotation();
    }
    // Update is called once per frame
    public void Rotation()
    {
        transform.Rotate(new Vector3(0, 5f, 0));
    }

    public virtual void Picked()
    {
        Debug.Log("Podniosłem");
        Destroy(this.gameObject);
    }
}
