using System.Collections.Generic;

public class AcquisitionRadius
{
    public double flat { get; set; }
    public double percent { get; set; }
    public double perLevel { get; set; }
    public double percentPerLevel { get; set; }
}

public class AramDamageDealt
{
    public double flat { get; set; }
    public double percent { get; set; }
    public double perLevel { get; set; }
    public double percentPerLevel { get; set; }
}

public class AramDamageTaken
{
    public double flat { get; set; }
    public double percent { get; set; }
    public double perLevel { get; set; }
    public double percentPerLevel { get; set; }
}

public class AramHealing
{
    public double flat { get; set; }
    public double percent { get; set; }
    public double perLevel { get; set; }
    public double percentPerLevel { get; set; }
}

public class AramShielding
{
    public double flat { get; set; }
    public double percent { get; set; }
    public double perLevel { get; set; }
    public double percentPerLevel { get; set; }
}

public class Armor
{
    public double flat { get; set; }
    public double percent { get; set; }
    public double perLevel { get; set; }
    public double percentPerLevel { get; set; }
}

public class AttackCastTime
{
    public double flat { get; set; }
    public double percent { get; set; }
    public double perLevel { get; set; }
    public double percentPerLevel { get; set; }
}

public class AttackDamage
{
    public double flat { get; set; }
    public double percent { get; set; }
    public double perLevel { get; set; }
    public double percentPerLevel { get; set; }
}

public class AttackDelayOffset
{
    public double flat { get; set; }
    public double percent { get; set; }
    public double perLevel { get; set; }
    public double percentPerLevel { get; set; }
}

public class AttackRange
{
    public double flat { get; set; }
    public double percent { get; set; }
    public double perLevel { get; set; }
    public double percentPerLevel { get; set; }
}

public class AttackSpeed
{
    public double flat { get; set; }
    public double percent { get; set; }
    public double perLevel { get; set; }
    public double percentPerLevel { get; set; }
}

public class AttackSpeedRatio
{
    public double flat { get; set; }
    public double percent { get; set; }
    public double perLevel { get; set; }
    public double percentPerLevel { get; set; }
}

public class AttackTotalTime
{
    public double flat { get; set; }
    public double percent { get; set; }
    public double perLevel { get; set; }
    public double percentPerLevel { get; set; }
}

public class AttributeRatings
{
    public double damage { get; set; }
    public double toughness { get; set; }
    public double control { get; set; }
    public double mobility { get; set; }
    public double utility { get; set; }
    public double abilityReliance { get; set; }
    public double attack { get; set; }
    public double defense { get; set; }
    public double magic { get; set; }
    public double difficulty { get; set; }
}

public class Chroma
{
    public string name { get; set; }
    public double id { get; set; }
    public string chromaPath { get; set; }
    public List<string> colors { get; set; }
    public List<Description> descriptions { get; set; }
    public List<Rarity> rarities { get; set; }
}

public class Cooldown
{
    public List<Modifier> modifiers { get; set; }
    public bool affectedByCdr { get; set; }
}

public class Cost
{
    public List<Modifier> modifiers { get; set; }
}

public class CriticalStrikeDamage
{
    public double flat { get; set; }
    public double percent { get; set; }
    public double perLevel { get; set; }
    public double percentPerLevel { get; set; }
}

public class CriticalStrikeDamageModifier
{
    public double flat { get; set; }
    public double percent { get; set; }
    public double perLevel { get; set; }
    public double percentPerLevel { get; set; }
}

public class Description
{
    public string description { get; set; }
    public string region { get; set; }
}

public class Effect
{
    public string description { get; set; }
    public List<Leveling> leveling { get; set; }
}

public class GameplayRadius
{
    public double flat { get; set; }
    public double percent { get; set; }
    public double perLevel { get; set; }
    public double percentPerLevel { get; set; }
}

public class Health
{
    public double flat { get; set; }
    public double percent { get; set; }
    public double perLevel { get; set; }
    public double percentPerLevel { get; set; }
}

public class HealthRegen
{
    public double flat { get; set; }
    public double percent { get; set; }
    public double perLevel { get; set; }
    public double percentPerLevel { get; set; }
}

public class Leveling
{
    public string attribute { get; set; }
    public List<Modifier> modifiers { get; set; }
}

public class MagicResistance
{
    public double flat { get; set; }
    public double percent { get; set; }
    public double perLevel { get; set; }
    public double percentPerLevel { get; set; }
}

public class Mana
{
    public double flat { get; set; }
    public double percent { get; set; }
    public double perLevel { get; set; }
    public double percentPerLevel { get; set; }
}

public class ManaRegen
{
    public double flat { get; set; }
    public double percent { get; set; }
    public double perLevel { get; set; }
    public double percentPerLevel { get; set; }
}

public class Modifier
{
    public List<double> values { get; set; }
    public List<string> units { get; set; }
}

public class Movespeed
{
    public double flat { get; set; }
    public double percent { get; set; }
    public double perLevel { get; set; }
    public double percentPerLevel { get; set; }
}

public class PathingRadius
{
    public double flat { get; set; }
    public double percent { get; set; }
    public double perLevel { get; set; }
    public double percentPerLevel { get; set; }
}

public class Price
{
    public double blueEssence { get; set; }
    public double rp { get; set; }
    public double saleRp { get; set; }
}

public class Rarity
{
    public double? rarity { get; set; }
    public string region { get; set; }
}

public class RiotAPIChampionDataResponse
{
    public double id { get; set; }
    public string key { get; set; }
    public string name { get; set; }
    public string title { get; set; }
    public string fullName { get; set; }
    public string icon { get; set; }
    public string resource { get; set; }
    public string attackType { get; set; }
    public string adaptiveType { get; set; }
    public Stat stats { get; set; }
    public List<string> roles { get; set; }
    public AttributeRatings attributeRatings { get; set; }
    //public Abilities abilities { get; set; }
    public Dictionary<string, List<Abilities>> abilities { get; set; }
    public string releaseDate { get; set; }
    public string releasePatch { get; set; }
    public string patchLastChanged { get; set; }
    public Price price { get; set; }
    public string lore { get; set; }
}

public class SelectionRadius
{
    public double flat { get; set; }
    public double percent { get; set; }
    public double perLevel { get; set; }
    public double percentPerLevel { get; set; }
}

public class Stat
{
    public Health health { get; set; }
    public HealthRegen healthRegen { get; set; }
    public Mana mana { get; set; }
    public ManaRegen manaRegen { get; set; }
    public Armor armor { get; set; }
    public MagicResistance magicResistance { get; set; }
    public AttackDamage attackDamage { get; set; }
    public Movespeed movespeed { get; set; }
    public AcquisitionRadius acquisitionRadius { get; set; }
    public SelectionRadius selectionRadius { get; set; }
    public PathingRadius pathingRadius { get; set; }
    public GameplayRadius gameplayRadius { get; set; }
    public CriticalStrikeDamage criticalStrikeDamage { get; set; }
    public CriticalStrikeDamageModifier criticalStrikeDamageModifier { get; set; }
    public AttackSpeed attackSpeed { get; set; }
    public AttackSpeedRatio attackSpeedRatio { get; set; }
    public AttackCastTime attackCastTime { get; set; }
    public AttackTotalTime attackTotalTime { get; set; }
    public AttackDelayOffset attackDelayOffset { get; set; }
    public AttackRange attackRange { get; set; }
    public AramDamageTaken aramDamageTaken { get; set; }
    public AramDamageDealt aramDamageDealt { get; set; }
    public AramHealing aramHealing { get; set; }
    public AramShielding aramShielding { get; set; }
    public UrfDamageTaken urfDamageTaken { get; set; }
    public UrfDamageDealt urfDamageDealt { get; set; }
    public UrfHealing urfHealing { get; set; }
    public UrfShielding urfShielding { get; set; }
}

public class UrfDamageDealt
{
    public double flat { get; set; }
    public double percent { get; set; }
    public double perLevel { get; set; }
    public double percentPerLevel { get; set; }
}

public class UrfDamageTaken
{
    public double flat { get; set; }
    public double percent { get; set; }
    public double perLevel { get; set; }
    public double percentPerLevel { get; set; }
}

public class UrfHealing
{
    public double flat { get; set; }
    public double percent { get; set; }
    public double perLevel { get; set; }
    public double percentPerLevel { get; set; }
}

public class UrfShielding
{
    public double flat { get; set; }
    public double percent { get; set; }
    public double perLevel { get; set; }
    public double percentPerLevel { get; set; }
}

public class Abilities
{
    public string name { get; set; }
    public string icon { get; set; }
    public List<Effect> effects { get; set; }
    public Cost cost { get; set; }
    public Cooldown cooldown { get; set; }
    public string targeting { get; set; }
    public string affects { get; set; }
    public string spellshieldable { get; set; }
    public string resource { get; set; }
    public string damageType { get; set; }
    public string spellEffects { get; set; }
    public string projectile { get; set; }
    public object onHitEffects { get; set; }
    public object occurrence { get; set; }
    public string notes { get; set; }
    public string blurb { get; set; }
    public object missileSpeed { get; set; }
    public object rechargeRate { get; set; }
    public object collisionRadius { get; set; }
    public object tetherRadius { get; set; }
    public object onTargetCdStatic { get; set; }
    public object innerRadius { get; set; }
    public string speed { get; set; }
    public string width { get; set; }
    public string angle { get; set; }
    public string castTime { get; set; }
    public string effectRadius { get; set; }
    public object targetRange { get; set; }
}