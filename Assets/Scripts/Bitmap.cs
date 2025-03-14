using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bitmap : MonoBehaviour
{
    [SerializeField] private int[] values = new int[8];

    [SerializeField] private Byte[] bytes = new Byte[8];
    // Start is called before the first frame update
    void Start()
    {
        

        // Update is called once per frame

    }

    void Update()
    {
        for (int i = 0; i < 8; i++)
        {
            bytes[i].setValue(values[i]);
        }
    }
}
