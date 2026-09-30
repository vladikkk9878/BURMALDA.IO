using UnityEngine;

using UnityEngine.UI;

public class LevelMenuGenerator : MonoBehaviour
{
    [SerializeField] private int levelCount;
    [SerializeField] private GameObject buttonPrefab;
    [SerializeField] private Transform root;
    [SerializeField] private int  complitedLevelCount;

    private void Start()
    {
        ClearRoot();
        GenerateLevelButtons();
    }

    private void GenerateLevelButtons()
    {
        for (int i = 0; i < levelCount; i++)
        {
            var instance = Instantiate(buttonPrefab, root);
            if (instance.TryGetComponent(out LevelButton button))
            {
                int levelNumber = i + 1;
                int starsCount = Random.Range(1, 4);
                if (i == complitedLevelCount)
                {
                    button.Init(levelNumber, 0, true);
                }
                else
                {
                    button.Init(levelNumber, starsCount, i < complitedLevelCount);
                }
            }
                

        }
    }
    private void ClearRoot()
    {
        for (int i = 0; i < root.childCount; i++)
        {
            Destroy(root.GetChild(i).gameObject);
        }
    }
}

