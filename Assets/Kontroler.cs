using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kontroler : MonoBehaviour
{
    [SerializeField] private GameObject WrogPrefab; 
    private GameObject _enemy; 
    void Update() { 
        if (_enemy == null) { 
            _enemy = Instantiate(WrogPrefab) as GameObject;
            _enemy.transform.position = new Vector3(10, 1, 0); 
            float angle = Random.Range(0, 360); 
            _enemy.transform.Rotate(0, angle, 0);
        } 
    }
}
