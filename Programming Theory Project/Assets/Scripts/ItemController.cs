using System.Collections;
using UnityEngine;

public abstract class ItemController : MonoBehaviour
{
    private bool _isActive = true;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision");
        if (_isActive && other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Is player");
            PlayerProperties playerProperties = other.gameObject.GetComponent<PlayerProperties>();
            if (playerProperties != null)
            {
                Debug.Log("Props found");
                UpdatePlayerProperties(playerProperties);
                Hide();
                StartCoroutine(Show(GetRefreshTime()));
            }
        }
    }

    // ABSTRACTION
    private IEnumerator Show(float delay)
    {
        yield return new WaitForSeconds(delay);
        gameObject.GetComponent<MeshRenderer>().enabled = true;
        _isActive = true;
    }

    // ABSTRACTION
    private void Hide()
    {
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        _isActive = false;
    }

    // POLYMORPHISM
    protected abstract void UpdatePlayerProperties(PlayerProperties playerProperties);
    // POLYMORPHISM
    protected abstract float GetRefreshTime();
}
