using UnityEngine;
using System.Collections;

public class PickUpMerveille : MonoBehaviour
{
    public int Valeur_merveille;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Enregistrer le nombre de pieces gagnees
            Inventory.instance.Addcoins(Valeur_merveille);
        }
    }
}
