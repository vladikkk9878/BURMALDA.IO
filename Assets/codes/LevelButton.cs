using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelButton : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI levelNumberText;
    [SerializeField] private GameObject[] stars;
    [SerializeField] private GameObject locker;
    [SerializeField] private GameObject[] starsRoot;
 
    public void Init(int levelNumber, int starsCount, bool Complited)
    {
        levelNumberText.text = $"{levelNumber}";
        if (Complited)
        {
            for (int i = 0; i < stars.Length; i++)
            {
                stars[i].SetActive(i < starsCount);
            }
        }
        else
        {
            //show locker
        }
    }
}
