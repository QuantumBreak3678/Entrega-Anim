using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations.Rigging;

public class IKSlider : MonoBehaviour
{
    public Slider sliderUI; 
    public TwoBoneIKConstraint twoBoneIKConstraint;
    public Animator Running; 

 
  
    void Update()
    { 
  
        float sliderValue = sliderUI.value;

        twoBoneIKConstraint.weight = sliderValue;
        
    }

    public void Button()
    {
        Running.SetBool("Run", true);
    }
}
