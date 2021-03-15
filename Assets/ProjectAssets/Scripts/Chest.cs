using UnityEngine;

public class Chest : MonoBehaviour
{
    [SerializeField] private Animator animator;

    private bool isOpen = false;
    private static readonly int IsOpen = Animator.StringToHash("IsOpen");

    private void Update()
    {
        if (!Input.GetKeyDown(KeyCode.Space)) return;
        isOpen = !isOpen;
        animator.SetBool(IsOpen, isOpen);
    }
}
