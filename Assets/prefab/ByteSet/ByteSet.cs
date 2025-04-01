using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ByteSet     : MonoBehaviour
{
    [SerializeField] int newValue = 0;
    [SerializeField] Byte myByte;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        myByte.SetByte(newValue);
    }
}
