using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelButton : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI levelNumberText;

    public void Init(int levelNumber)
    {
        levelNumberText.text = $"{levelNumber}";
    }
}
