using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public Sprite colDown, colUp;

    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().sprite = colDown;
    }

    public void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().sprite = colUp;
    }

    public void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        {
            case "Play_Button":
                Application.LoadLevel("Game");
                break;
        }
    }
}
