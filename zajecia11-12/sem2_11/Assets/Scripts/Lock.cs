using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class Lock : MonoBehaviour
{
    bool iCanOpen = false;
    public Door[] doors;
    public KeyColor myColor;
    bool locked = false;
    Animator key;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            iCanOpen = true;
            Debug.Log("mOZESZ U¯YÆ KLUCZA");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            iCanOpen = false;
            Debug.Log("Nie masz klucza"); 
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        key = GetComponent<Animator>();
    }

    public void UseKey()
    {
        foreach(Door door in doors)
        {
            door.OpenClose();
        }
    }

    public bool CheckTheKey()
    {
        //Debug.Log("Zaczê³o dzia³aæ");
        if(GameManager.gameManager.redKey > 0 && myColor == KeyColor.Red )
        {
            GameManager.gameManager.redKey--;
            locked = true;
            return true;
        } 
        else if(GameManager.gameManager.blueKey > 0 
            && myColor == KeyColor.Blue)
        {
            GameManager.gameManager.blueKey--;
            locked = true;
            return true;
        } 
        else if(GameManager.gameManager.goldKey > 0 
            && myColor == KeyColor.Gold)
        {
            GameManager.gameManager.goldKey--;
            locked = true;
            return true;
        } else {
            Debug.Log("Nie masz klucza!");
            return false;
        }
    }



    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && iCanOpen && !locked)
        {
            key.SetBool("useKey" , CheckTheKey());
        }
    }
}
