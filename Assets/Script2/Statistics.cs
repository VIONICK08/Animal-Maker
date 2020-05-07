using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Statistics : MonoBehaviour
{
    //public bool onNextLevel;
    private bool minAnimalHead = false;
    private bool maxAnimalHead = false;
    
    private bool type = true;

    private bool minanimalTorso = false;
    private bool maxanimalTorso = false;

    private bool minanimalTorso2 = false;
    private bool maxanimalTorso2 = false;

    private bool minanimalLegs = false;
    private bool maxanimalLegs = false;

    private bool minanimalLegs2 = false;
    private bool maxanimalLegs2 = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public bool MinAnimalHead()
    {
        return minAnimalHead;
    }

    public bool MaxAnimalHead()
    {
        return maxAnimalHead;
    }

    public bool Type()
    {
        return type;
    }

    public bool MinAnimalTorso()
    {
        return minanimalTorso;
    }

    public bool MaxAnimalTorso()
    {
        return maxanimalTorso;
    }

    public bool MinAnimalTorso2()
    {
        return minanimalTorso2;
    }

    public bool MaxAnimalTorso2()
    {
        return maxanimalTorso2;
    }

    public bool MinanimaalLegs()
    {
        return minanimalLegs;
    }

    public bool MaxanimaalLegs()
    {
        return maxanimalLegs;
    }

    public bool MinanimaalLegs2()
    {
        return minanimalLegs2;
    }

    public bool MaxanimaalLegs2()
    {
        return maxanimalLegs2;
    }
}
