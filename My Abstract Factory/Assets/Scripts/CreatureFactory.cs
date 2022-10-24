using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureFactory : AbstractCreatureFactory
{
    private readonly ICreatureFactory _factory;
    private readonly CreatureRequirements _requirements;

    public CreatureFactory(CreatureRequirements requirements)
    {
        if (requirements.isMonster)
        {
            _factory = new MonsterFactory();
        }
        else if (!requirements.isMonster && requirements.isHuman)
        {
            _factory = new HumanHeroFactory();
        }
        else 
        {
            _factory = new NonHumanHeroFactory();
        }
        _requirements = requirements;
    }
    public override ICreature Create()
    {

        return _factory.Create(_requirements);
    }
}
