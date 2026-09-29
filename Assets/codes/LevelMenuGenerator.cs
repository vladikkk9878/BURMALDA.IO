using UnityEngine;
using UnityEngine.UI;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private int levelCount;
    [SerializeField] private GameObject buttonPrefab;
    [SerializeField] private Transform root;

    private void Start()
    {
        ClearRoot();
        GenerateLevelButtons();
    }

    private void GenerateLevelButtons()
    {
        for (int i = 0; i < levelCount; i++)
        {
            Instantiate(buttonPrefab, root);

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

