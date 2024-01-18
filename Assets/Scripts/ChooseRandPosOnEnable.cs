using UnityEngine;

public class ChooseRandPosOnEnable : MonoBehaviour
{
    [SerializeField] private Axis axis;
    [SerializeField] private float radius;
    [SerializeField] private float centerPoint;
        
    private Transform target;

    private void Awake()
    {
        target = transform;
    }

    private void OnEnable()
    {       
        float num = Random.Range(-radius, radius);
        num += centerPoint;

        if (axis == Axis.x)
            target.position = new Vector3(num, target.position.y, target.position.z);

        if (axis == Axis.y)
            target.position = new Vector3(target.position.x, num, target.position.z);

        if (axis == Axis.z)
            target.position = new Vector3(target.position.x, target.position.y, num);
    }
}
