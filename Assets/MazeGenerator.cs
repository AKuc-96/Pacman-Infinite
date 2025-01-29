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
        Vector2 mazeCellPos = new Vector2 (Random.Range(-8, -1), Random.Range(1, 4));
        Vector2 scaleChange = new Vector2 (Random.Range(0, 6), Random.Range(0, 3));

        GameObject prefabInst = Instantiate(_mazeCellPrefab, mazeCellPos, Quaternion.identity);

        Vector2 cellScale = transform.localScale;
        
        if (scaleChange.x == 0 || scaleChange.y == 0)
        {
            prefabInst.transform.localScale = (Vector2)prefabInst.transform.localScale + (Vector2)scaleChange;
        }

        Instantiate(prefabInst, new Vector2(-mazeCellPos.x, mazeCellPos.y), Quaternion.identity);
        Instantiate(prefabInst, new Vector2(mazeCellPos.x, -mazeCellPos.y), Quaternion.identity);
        Instantiate(prefabInst, new Vector2(-mazeCellPos.x, -mazeCellPos.y), Quaternion.identity);
        
        //some useful code, please don't delete it
        // for (int i = 0; i < randomNumberOfCells; i++)
        // {
        //     lastPosition = prefabInst.transform.position;
        //     if (Vector2.Distance(prefabInst.transform.position, lastPosition) == 1)
        //     {
        //         prefabInst.transform.position = (Vector2)prefabInst.transform.position + new Vector2(1, 1); 
        //     }
        // }
    }
}
