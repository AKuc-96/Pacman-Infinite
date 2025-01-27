using UnityEngine;

public class MazeGenerator : MonoBehaviour
{
    [SerializeField]
    private GameObject _mazeCellPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MakeSomeRandomWalls();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MakeSomeRandomWalls()
    {
        int randomNumberOfCells = Random.Range(1, 20);
        for (int i = 0; i < randomNumberOfCells; i++)
        {
            Instantiate(_mazeCellPrefab, new Vector2(Random.Range(-8, 8), Random.Range(-4, 4)), Quaternion.identity);
        }
    }
}
