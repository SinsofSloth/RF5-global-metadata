[ExtensionAttribute] // RVA: 0x14A540 Offset: 0x14A641 VA: 0x14A540
public static class CalcStatus // TypeDefIndex: 10403
{
	// Properties
	public static DamageInfo NotEnoughRP_HPDamage { get; }

	// Methods

	// RVA: 0x206EE50 Offset: 0x206EF51 VA: 0x206EE50
	public static int CalcBasicDamage(DamageInfo damageInfo, StatusBase status, bool isCritical, out bool isWeakAttribute, out bool isResistAttribute) { }

	// RVA: 0x206FAA0 Offset: 0x206FBA1 VA: 0x206FAA0
	private static float CalcAttackAttribute(ref DamageInfo damageInfo, StatusBase status) { }

	// RVA: 0x206FE60 Offset: 0x206FF61 VA: 0x206FE60
	public static int CalcPercentDamage(DamageInfo damageInfo, StatusBase status) { }

	// RVA: 0x206FF80 Offset: 0x2070081 VA: 0x206FF80
	public static void CreateDamageInfoForChracter(CharacterStatusBase characterStatus, out DamageInfo damageInfo) { }

	// RVA: 0x206FFB0 Offset: 0x20700B1 VA: 0x206FFB0
	public static bool CheckAllilince(AttackType attackType, Alliance attacker, Alliance target) { }

	// RVA: 0x206FFF0 Offset: 0x20700F1 VA: 0x206FFF0
	public static bool CalcRand(float attack, float def) { }

	// RVA: 0x20700C0 Offset: 0x20701C1 VA: 0x20700C0
	public static int CalcHpDrain(DamageInfo damageInfo, int totalDamage, Parameter parameter) { }

	// RVA: 0x20701B0 Offset: 0x20702B1 VA: 0x20701B0
	public static Parameter CalcLevelUpRatio(CharaParamDataTable charaParam, Parameter parameter, int level) { }

	// RVA: 0x20703E0 Offset: 0x20704E1 VA: 0x20703E0
	public static Parameter LevelDown(Parameter parameter) { }

	// RVA: 0x2070580 Offset: 0x2070681 VA: 0x2070580
	public static Parameter LevelUpFriendMonster(CharaParamDataTable charaParam, Parameter parameter, int level) { }

	// RVA: 0x205C560 Offset: 0x205C661 VA: 0x205C560
	public static void LevelUpEnemyMonster(CharaParamDataTable charaParam, bool levelup, StatusDataBase status, int level, bool isBoss) { }

	// RVA: 0x20709A0 Offset: 0x2070AA1 VA: 0x20709A0
	public static Parameter PlayerLevel_Up_or_Down(int prevLevel, int nextLevel, Parameter parameter) { }

	// RVA: 0x2070B70 Offset: 0x2070C71 VA: 0x2070B70
	public static int GetNeedExp(int level) { }

	// RVA: 0x2070C00 Offset: 0x2070D01 VA: 0x2070C00
	public static int CalcSkillActionRP(SkillActionID id, int itemLevel = 1) { }

	// RVA: 0x2071140 Offset: 0x2071241 VA: 0x2071140
	public static DamageInfo get_NotEnoughRP_HPDamage() { }

	// RVA: 0x20711A0 Offset: 0x20712A1 VA: 0x20711A0
	public static Parameter CalcSkillEffect() { }

	// RVA: 0x206F9E0 Offset: 0x206FAE1 VA: 0x206F9E0
	private static float CalcSkillAttributeReduce(SkillID skillID, AttackAttribute attribute, bool isMagic) { }

	[ExtensionAttribute] // RVA: 0x1AF220 Offset: 0x1AF321 VA: 0x1AF220
	// RVA: 0x206F9D0 Offset: 0x206FAD1 VA: 0x206F9D0
	public static bool Contains(AttackAttribute self, AttackAttribute target) { }

	[ExtensionAttribute] // RVA: 0x1AF230 Offset: 0x1AF331 VA: 0x1AF230
	// RVA: 0x206FE50 Offset: 0x206FF51 VA: 0x206FE50
	public static bool IsNone(AttackAttribute self) { }

	[ExtensionAttribute] // RVA: 0x1AF240 Offset: 0x1AF341 VA: 0x1AF240
	// RVA: 0x2071410 Offset: 0x2071511 VA: 0x2071410
	public static bool HasBadStatus(BadStatus self, BadStatus badStatus) { }

	// RVA: 0x2071420 Offset: 0x2071521 VA: 0x2071420
	public static float CalcDamageKnockback(ref DamageInfo damageInfo, ref DamageResult damageResult, StatusBase status) { }

	// RVA: 0x20714E0 Offset: 0x20715E1 VA: 0x20714E0
	public static void AddExpWithDestoryEnemy(int addExp, MonsterDataID monsterID) { }

	// RVA: 0x20718B0 Offset: 0x20719B1 VA: 0x20718B0
	public static int GetBlowPowerByItemCategory(ItemCategory itemCategory) { }

	// RVA: 0x2071A30 Offset: 0x2071B31 VA: 0x2071A30
	public static AttackAttribute GetAttackAttribute(ItemData itemData) { }

	// RVA: 0x2071C20 Offset: 0x2071D21 VA: 0x2071C20
	public static bool GetStrengtheingItemAttribute(ItemID itemID, out AttackAttribute attribute) { }

	// RVA: 0x2071D20 Offset: 0x2071E21 VA: 0x2071D20
	public static bool CalcTame(MonsterControllerBase monster) { }

	// RVA: 0x2071F90 Offset: 0x2072091 VA: 0x2071F90
	public static float CalcAddDualSkillGauge(DualSkillGaugeUpType dualSkillGaugeUp) { }

	// RVA: 0x20720E0 Offset: 0x20721E1 VA: 0x20720E0
	public static DamageInfo CalcDualSkillDamage(HumanStatus main, HumanStatus sub, MagicParamID magicParamID, int loveLevel) { }

	// RVA: 0x20722B0 Offset: 0x20723B1 VA: 0x20722B0
	public static Parameter CalcBonusFriendMonster(FriendMonsterStatus status) { }

	// RVA: 0x2072620 Offset: 0x2072721 VA: 0x2072620
	public static float CalcUseRateByLevel(float useRate, int level) { }
}

