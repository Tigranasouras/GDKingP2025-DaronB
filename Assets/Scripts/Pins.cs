using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Pins", menuName = "ScriptableObjects/Pins", order = 1)]
public class Pins : ScriptableObject
{
   public Pin[] pins;
   public int count(){
    return pins.Length;
   }

   public Pin getPin(int i){
        return pins[i];
   }


}
