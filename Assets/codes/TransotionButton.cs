using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Button))]
public class TransitionButton : MonoBehaviour
{
    private Button _btn;
    [SerializeField] private GameObject currentScreen;
    [SerializeField] private GameObject nextScreen;

    private void Awake()
    {
        _btn = GetComponent<Button>();
        _btn.onClick.AddListener(DoTransition);
        if (nextScreen != null)
        {
            nextScreen.SetActive(false);
        }
    }

    private void DoTransition()
    {
        currentScreen.SetActive(false);
        nextScreen.SetActive(true);
    }

    private void OnDestroy()
    {
        _btn.onClick.RemoveListener(DoTransition);
    }
}