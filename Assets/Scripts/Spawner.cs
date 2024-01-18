using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawnFrequency;
    public float spawnFrequencWaves;

    private void OnDisable()
    {
        StopAllCoroutines();
    }

    public void StartSpawn()
    {
        StartCoroutine(Spawn());
    }

    public IEnumerator Spawn()
    {
        while (true)
        {
            foreach (Transform child in transform)
            {
                if (child.gameObject.activeSelf) continue;

                yield return new WaitForSeconds(spawnFrequency);
                child.gameObject.SetActive(true);
            }
            yield return new WaitForSeconds(spawnFrequencWaves);
        }
    }
}
