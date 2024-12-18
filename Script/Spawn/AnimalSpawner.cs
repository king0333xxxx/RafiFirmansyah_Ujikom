using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawner : MonoBehaviour
{
    [SerializeField] private SO_Animal _animalList;
    public Vector3 SpawnOffset;
    public float duration = 2f; 
    public float xMin = -5f; 
    public float xMax = 5f; 

    private void Start()
    {
        
        StartCoroutine(SpawnAnimalsWithInterval());
    }

    private IEnumerator SpawnAnimalsWithInterval()
    {
        while (true)
        {
            SpawnRandomAnimal();
            yield return new WaitForSeconds(duration); 
        }
    }

    private void SpawnRandomAnimal()
    {
        if (_animalList == null || _animalList.AnimalList.Count == 0)
        {
            Debug.LogWarning("AnimalList is empty or null!");
            return;
        }

        // Randomisasi index hewan dari list
        int randomIndex = Random.Range(0, _animalList.AnimalList.Count);
        GameObject selectedAnimal = _animalList.AnimalList[randomIndex];

        // Randomisasi posisi X untuk offset spawn
        float randomX = Random.Range(xMin, xMax);
        Vector3 spawnPosition = new Vector3(randomX, SpawnOffset.y, SpawnOffset.z) + transform.position;

        // Spawn hewan
        Instantiate(selectedAnimal, spawnPosition, Quaternion.identity, transform);
    }
}
