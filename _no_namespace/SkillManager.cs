public class SkillManager : SingletonMonoBehaviour<SkillManager> // TypeDefIndex: 8287
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x16E980 Offset: 0x16EA81 VA: 0x16E980
	private static float <UseRpRate>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x16E990 Offset: 0x16EA91 VA: 0x16E990
	private SkillLevelUpEffectController <EffectController>k__BackingField; // 0x18

	// Properties
	public static float UseRpRate { get; set; }
	private SkillLevelUpEffectController EffectController { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A6890 Offset: 0x1A6991 VA: 0x1A6890
	// RVA: 0x1C545A0 Offset: 0x1C546A1 VA: 0x1C545A0
	public static void set_UseRpRate(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A68A0 Offset: 0x1A69A1 VA: 0x1A68A0
	// RVA: 0x1C54620 Offset: 0x1C54721 VA: 0x1C54620
	public static float get_UseRpRate() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A68B0 Offset: 0x1A69B1 VA: 0x1A68B0
	// RVA: 0x1C54690 Offset: 0x1C54791 VA: 0x1C54690
	private SkillLevelUpEffectController get_EffectController() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A68C0 Offset: 0x1A69C1 VA: 0x1A68C0
	// RVA: 0x1C546A0 Offset: 0x1C547A1 VA: 0x1C546A0
	private void set_EffectController(SkillLevelUpEffectController value) { }

	// RVA: 0x1C546B0 Offset: 0x1C547B1 VA: 0x1C546B0
	private void Start() { }

	// RVA: 0x1C54720 Offset: 0x1C54821 VA: 0x1C54720
	public static void DoActionRpExp(SkillActionID skillActionID, int level = 1) { }

	// RVA: 0x1C54A10 Offset: 0x1C54B11 VA: 0x1C54A10
	public static void DoActionExp(SkillActionID skillActionID) { }

	// RVA: 0x1C54830 Offset: 0x1C54931 VA: 0x1C54830
	public static void DoActionRp(SkillActionID skillUpAction, int level = 1) { }

	// RVA: 0x1C550F0 Offset: 0x1C551F1 VA: 0x1C550F0
	public static int GetSkillLevel(SkillID skillID) { }

	// RVA: 0x1C55150 Offset: 0x1C55251 VA: 0x1C55150
	public static int GetExp(SkillID skillID) { }

	// RVA: 0x1C551B0 Offset: 0x1C552B1 VA: 0x1C551B0
	public static int GetNextLevelExp(SkillID skillID) { }

	// RVA: 0x1C552E0 Offset: 0x1C553E1 VA: 0x1C552E0
	public static bool IsDeathCheck(SkillActionID skillActionID, int level = 1) { }

	// RVA: 0x1C54CD0 Offset: 0x1C54DD1 VA: 0x1C54CD0
	public static bool ExpUp(SkillID skillID, int exp) { }

	// RVA: 0x1C555F0 Offset: 0x1C556F1 VA: 0x1C555F0
	public static void RandomSkillLvUp() { }

	// RVA: 0x1C55410 Offset: 0x1C55511 VA: 0x1C55410
	private static void OrderFlagCheck(SkillID skillID, int level) { }

	// RVA: 0x1C559E0 Offset: 0x1C55AE1 VA: 0x1C559E0
	public void .ctor() { }

	// RVA: 0x1C55A30 Offset: 0x1C55B31 VA: 0x1C55A30
	private static void .cctor() { }
}

