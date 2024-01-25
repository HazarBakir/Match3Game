using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridGenerator : MonoBehaviour
{
    public int Rows = 5;
    public int Columns = 5;
    public float Spacing = 1f;
    public GameObject TilePrefab;
    void Start()
    {
        GenerateGrid();
    }

    void GenerateGrid()
    {
        for (int row = 0; row < Rows; row++)
        {
            for (int col = 0; col < Columns; col++)
            {
                Vector3 spawnPosition = new Vector3(col * Spacing, row * Spacing, 0);
                InstantiateTile(spawnPosition);

            }
        }
    }
    void InstantiateTile(Vector3 position)
    {
        Instantiate(TilePrefab, position, Quaternion.identity, transform);
    }
}
