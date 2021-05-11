using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private Vector3 _offSet;
    void Update()
    {
        transform.position = new Vector3(0, 0, _player.position.z) + _offSet;
    }
}
