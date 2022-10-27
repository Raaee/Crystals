using UnityEngine;
using UnityEngine.AI;

public class PlayerAnimation : MonoBehaviour    {  
    
    NavMeshAgent _agent;
    Animator _animator;

    // Start is called before the first frame update
    void Start()    {

        _animator = GetComponentInChildren<Animator>();
        _agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()   {
        
        //if (Input.GetMouseButtonDown(0)) {
        //    MoveToPosition();
        //}

        float speedPercent = _agent.velocity.magnitude / _agent.speed;
        _animator.SetFloat("speed", speedPercent);

    }
}
