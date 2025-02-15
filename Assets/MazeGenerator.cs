using UnityEngine;

public class MazeGenerator : MonoBehaviour
{
    [SerializeField]
    private GameObject _mazeCellPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MakeSomeRandomCells();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void MakeSomeRandomCells()
    {
        Vector2 mazeCellPos = new Vector2 (Random.Range(-7, -1), Random.Range(1, 5));

        int randomCount = Random.Range(2, 4);

        for (int i = 0; i < randomCount; i++)
        {
            GameObject mazeCell = Instantiate(_mazeCellPrefab, mazeCellPos, Quaternion.identity);
            GameObject rightCopy = Instantiate(_mazeCellPrefab, new Vector2(-mazeCellPos.x, mazeCellPos.y), Quaternion.identity);
            GameObject bottomCopy = Instantiate(_mazeCellPrefab, new Vector2(mazeCellPos.x, -mazeCellPos.y), Quaternion.identity);
            GameObject bottomRightCopy = Instantiate(_mazeCellPrefab, new Vector2(-mazeCellPos.x, -mazeCellPos.y), Quaternion.identity);
            
            mazeCellPos = (Vector2)mazeCellPos + new Vector2(2, 2);

            if ((mazeCellPos.y > 5 || mazeCellPos.x < -8))
            {
                Destroy (mazeCell);
                Destroy (rightCopy);
                Destroy (bottomCopy);
                Destroy (bottomRightCopy);
            }
        }

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
