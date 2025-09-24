using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private CombatController combatController;

    void Start()
    {
        combatController = new CombatController(new UchigatanaAttack(), new ShieldDefense());
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            combatController.PerformAttack();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            combatController.PerformDefense();
        }
    }


}
