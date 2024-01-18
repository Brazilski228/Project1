using TMPro;
using UnityEngine;

public class TxtScoreUpdater : MonoBehaviour
{
    public int score;

    private TextMeshProUGUI textComponent;

    private void Awake()
    {
        textComponent = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        textComponent.text = score.ToString();
    }
}
