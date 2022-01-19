using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal{
    public string name;
    public string sound;

    Animal()
    {

    }

    public void PlaySound(){
        Debug.Log(name + " : " + sound);       
    }
}
