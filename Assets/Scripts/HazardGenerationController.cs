using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardGenerationController : MonoBehaviour
{
    public GameObject[] hazards;

    public float timeBetweenHazards;
    private float _hazardGenCounter;

    void Start()
    {
        _hazardGenCounter = timeBetweenHazards;
    }

    void Update() {
        GenerateHazards();
    }

    private void GenerateHazards() {
        if (GameManager._canMove) {

            _hazardGenCounter -= Time.deltaTime;

            if (_hazardGenCounter <= 0) {
                int chosenHazard = Random.Range(0, hazards.Length);
                Instantiate(hazards[chosenHazard], transform.position, Quaternion.Euler(0f, Random.Range(-45f, 45f), 0f));

                _hazardGenCounter = Random.Range(timeBetweenHazards * 0.75f, timeBetweenHazards * 1.25f);
            }
        }
    }
}
