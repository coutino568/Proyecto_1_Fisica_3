using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class Particleassignation : MonoBehaviour
{
    public Text statsText;
    // Start is called before the first frame update
    private double particleProtonMass;
    private double particleElectronMass;
    private double particleMass;
    private double particleCharge;
    private const double fundamentalCharge = 0.0000000000000000001602;
    private const double electronMass = 0.00000000000000000000911;
    private const double protonMass = 0.00000000000000000000000000167;
    public double fieldStrength;
    public double fieldLength;
    public double initialVelocity;
    public double angle;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RefreshText();
    }

    public void assignCharge(int multiplier)
    {
        particleCharge = multiplier * fundamentalCharge;
        Debug.Log("Particle charge : " + particleCharge);
        //RefreshText();
    }

   

    public void setProtonMass(int protonMultiplier)
    {
        particleProtonMass = (protonMultiplier * protonMass);
        combineMasses();
    }
    public void setElectronMass(int electronMultiplier)
    {
        particleElectronMass = (electronMultiplier * electronMass);
        combineMasses();

    }
    private void combineMasses()
    {
        particleMass = particleProtonMass + particleElectronMass;
        RefreshText();
    }

    void RefreshText() {
        statsText.text = "Charge (C):  " + particleCharge + "\nMass(KG) : " + particleMass;
    }

}
