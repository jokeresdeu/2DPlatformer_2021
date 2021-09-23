using UnityEngine;

public class Chest : MonoBehaviour
{
    [SerializeField] private int _coinsAmount;
    public bool Activated { private get; set; }
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!Activated)
            return;
        
        PlayerMover player = other.GetComponent<PlayerMover>();
        if (player != null)
        {
            player.CoinsAmount += +_coinsAmount;
        }
    }
}
