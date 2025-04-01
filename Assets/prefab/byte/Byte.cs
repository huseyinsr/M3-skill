using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Byte : MonoBehaviour
{
    [SerializeField] Bit[] bits = new Bit[8];
    [SerializeField] int value = 0;

    void Start() // Fixed the capitalization to Start() instead of start()
    {

    }

    void Update()
    {
        Bin2Dec();
    }

    public void Bin2Dec()
    {
        this.value = 0;
        if (bits[0].state) { value += 1; }
        if (bits[1].state) { value += 2; }
        if (bits[2].state) { value += 4; }
        if (bits[3].state) { value += 8; }
        if (bits[4].state) { value += 16; }
        if (bits[5].state) { value += 32; }
        if (bits[6].state) { value += 64; }
        if (bits[7].state) { value += 128; }
    } // Added the missing closing brace here

    public void SetByte(int newValue)
    {
        if (newValue > 255)
        {
            newValue = 255;
        }

        value = newValue;

        if (newValue >= 128)
        {
            bits[7].state = true;
            newValue -= 128;
        } else
        {
            bits[7].state = false;
        }

        if (newValue >= 64)
        {
            bits[6].state = true;
            newValue -= 64;
        }
        else
        {
            bits[6].state = false;
        }

        if (newValue >= 32)
        {
            bits[5].state = true;
            newValue -= 32;
        }
        else
        {
            bits[5].state = false;
        }

        if (newValue >= 16)
        {
            bits[4].state = true;
            newValue -= 16;
        }
        else
        {
            bits[4].state = false;
        }

        if (newValue >= 8)
        {
            bits[3].state = true;
            newValue -= 8;
        }
        else
        {
            bits[3].state = false;
        }

        if (newValue >= 4)
        {
            bits[2].state = true;
            newValue -= 4;
        }
        else
        {
            bits[2].state = false;
        }

        if (newValue >= 2)
        {
            bits[1].state = true;
            newValue -= 2;
        }
        else
        {
            bits[1].state = false;
        }

        if (newValue >= 1)
        {
            bits[0].state = true;
            newValue -= 1;
        }
        else
        {
            bits[0].state = false;
        }
    }
}
