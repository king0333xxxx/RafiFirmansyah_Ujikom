using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtributeAnimal : MonoBehaviour, IDamageable
{
    [SerializeField] private string _nameAnimal;
    [SerializeField] private float _speedAnimal;
    [SerializeField] private int _scoreAnimal;
    [SerializeField] private int _health = 1; 

    private Rigidbody rb;
    private Vector3 _moveDirection;

    void Start()
    {
        MoveAnimal();
    }

    void Update()
    {
        transform.position += _moveDirection * _speedAnimal * Time.deltaTime;
    }

    private void MoveAnimal()
    {
        _moveDirection = -transform.forward;
    }

    // Implementasi dari interface IDamageable
    public void TakeDamage(int damage)
    {
        _health -= damage;

        if (_health <= 0)
        {
            //tambah score
            ScoreManager.Instance.AddScore(_scoreAnimal);
            Destroy(gameObject); 
        }
    }
}
