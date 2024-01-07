using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnergy : MonoBehaviour
{
    public int maxEnergy = 100;
    public int currentEnergy;

    public EnergySystem energyBar;

    // Start is called before the first frame update
    void Start()
    {
        currentEnergy = maxEnergy;
        energyBar.SetMaxEnergy(maxEnergy);
        InvokeRepeating("DecreaseEnergy", 1.0f, 1.0f);
    }

    void Update()
    {
        //DecreaseEnergy(1);
    }

    void DecreaseEnergy()
    {
        int energy = 1;
        if(currentEnergy > 0)
        {
            currentEnergy -= energy;
            energyBar.SetEnergy(currentEnergy);
        }     
    }
}
