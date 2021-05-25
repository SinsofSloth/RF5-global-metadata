public abstract class GrantAttributeController : MonoBehaviour // TypeDefIndex: 6630
{
	// Fields
	protected static readonly int AttributeNum; // 0x0
	protected const AttackAttribute AllAttribute = -1;
	protected const float DefaultDuration = 2;
	protected static Dictionary<AttackAttribute, EffectID> m_AuraEffectIds; // 0x8
	private Dictionary<AttackAttribute, float> m_AddAttribute; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x15E3A0 Offset: 0x15E4A1 VA: 0x15E3A0
	private AttackAttribute <CurrentAttribute>k__BackingField; // 0x20
	private Dictionary<AttackAttribute, float> m_Timer; // 0x28
	private Dictionary<AttackAttribute, ParticleSystem> m_Effects; // 0x30

	// Properties
	public AttackAttribute CurrentAttribute { get; set; }
	public Dictionary<AttackAttribute, float> Timer { get; }
	protected abstract Transform EffectPoint { get; }
	protected virtual float EffectScale { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19C340 Offset: 0x19C441 VA: 0x19C340
	// RVA: 0x1EB1DE0 Offset: 0x1EB1EE1 VA: 0x1EB1DE0
	public AttackAttribute get_CurrentAttribute() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C350 Offset: 0x19C451 VA: 0x19C350
	// RVA: 0x1EB1DF0 Offset: 0x1EB1EF1 VA: 0x1EB1DF0
	protected void set_CurrentAttribute(AttackAttribute value) { }

	// RVA: 0x1EB1E00 Offset: 0x1EB1F01 VA: 0x1EB1E00
	public Dictionary<AttackAttribute, float> get_Timer() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract Transform get_EffectPoint() { }

	// RVA: 0x1EB1E10 Offset: 0x1EB1F11 VA: 0x1EB1E10 Slot: 5
	protected virtual float get_EffectScale() { }

	// RVA: 0x1EB1E20 Offset: 0x1EB1F21 VA: 0x1EB1E20 Slot: 6
	public virtual bool DoSet(AttackAttribute attribute, float duration = 2) { }

	// RVA: 0x1EB1F30 Offset: 0x1EB2031 VA: 0x1EB1F30 Slot: 7
	public virtual bool DoAdd() { }

	// RVA: 0x1EB2260 Offset: 0x1EB2361 VA: 0x1EB2260 Slot: 8
	public virtual void DoRemove(AttackAttribute attribute) { }

	// RVA: 0x1EB2440 Offset: 0x1EB2541 VA: 0x1EB2440
	public void DoClear() { }

	// RVA: 0x1EB2450 Offset: 0x1EB2551 VA: 0x1EB2450
	public void OnUpdate() { }

	// RVA: 0x1EB20D0 Offset: 0x1EB21D1 VA: 0x1EB20D0
	protected void PlayEffect(AttackAttribute attribute) { }

	// RVA: 0x1EB2360 Offset: 0x1EB2461 VA: 0x1EB2360
	protected void StopEffect(AttackAttribute attribute) { }

	// RVA: 0x1EB25C0 Offset: 0x1EB26C1 VA: 0x1EB25C0
	protected void .ctor() { }

	// RVA: 0x1EB26A0 Offset: 0x1EB27A1 VA: 0x1EB26A0
	private static void .cctor() { }
}

