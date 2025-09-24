using UnityEngine;

public class CombatController
{
    private IAttackAction attackAction;
    private IDefenseAction defenseAction;

    public CombatController(IAttackAction attack, IDefenseAction defense)
    {
        attackAction = attack;
        defenseAction = defense;
    }

    public void PerformAttack()
    {
        attackAction.ExecuteAttack();
    }

    public void PerformDefense()
    {
        defenseAction.ExecuteDefense();
    }

}
