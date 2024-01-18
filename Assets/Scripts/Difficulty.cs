using UnityEngine;
using UnityEngine.UI;

public class Difficulty : MonoBehaviour
{
    [SerializeField] private Dropdown dropdown;

    public float difficulty;

    private void OnEnable()
    {
        dropdown.onValueChanged.AddListener(delegate { Change(); });
    }

    void Change()
    {
        if (dropdown.value == 0)
            difficulty = 1;
        if(dropdown.value == 1)
            difficulty = 0.7f;
        if(dropdown.value == 2)
            difficulty = 0.4f;
    }
}
