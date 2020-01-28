using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public Tile tileRef;
    public int lenght;
    public int width;

    // Start is called before the first frame update
    void Start()
    {
        InstantiateBoard();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void InstantiateBoard()
    {
        
       bool blanc = true;

        for (int i = 0; i < lenght; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Tile thisTile = GameObject.Instantiate(tileRef, new Vector3(i, 0, j), Quaternion.identity);
                if (blanc == true)
                {
                    thisTile.GetComponent<Renderer>().material.color = Color.white;
                    blanc = false;
                }
                else
                {
                    thisTile.GetComponent<Renderer>().material.color = Color.black;
                    blanc = true;
                }
            }
            blanc = !blanc;
        }
    }
}
