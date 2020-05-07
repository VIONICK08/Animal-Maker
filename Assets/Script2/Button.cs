using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public Sprite colDown, colUp;


    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().sprite = colDown;
    }

    private void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().sprite = colUp;
    }

    private void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        {
            case "Home_Button":
                Application.LoadLevel("Menu");
                break;
            case "Reload":
                Application.LoadLevel("Game");
                break;
        }
    }
}
