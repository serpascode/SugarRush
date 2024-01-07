using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergySystem : MonoBehaviour
{
   public Slider energySlider;

   public void SetMaxEnergy(int energy)
   {
    energySlider.maxValue = energy;
    energySlider.value = energy;
   }

   public void SetEnergy(int energy)
   {
    energySlider.value = energy;
   }

    /*private void start()
    {
        _energySlider.GetComponent<Slider>();
    }

    public void SetMaxEnergy(int maxEnergy)
    {
        _energySlider.maxValue = maxEnergy;
        _energySlider.value = maxEnergy;
    }

    public void SetEnergy(int energy)
    {
        _energySlider.value = energy;
    }*/
}
