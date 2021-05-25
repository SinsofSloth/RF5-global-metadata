public class AttackCollision : MonoBehaviour // TypeDefIndex: 6563
{
	// Fields
	private HumanController m_Human; // 0x18
	private float m_MotionPower; // 0x20
	private float m_KnockbackPower; // 0x24
	private int m_BlowPower; // 0x28
	private EffectID m_HitEffectName; // 0x2C
	private ItemData m_ItemData; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x15D5F0 Offset: 0x15D6F1 VA: 0x15D5F0
	private List<CharacterBase> <HitList>k__BackingField; // 0x38

	// Properties
	public List<CharacterBase> HitList { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19B6E0 Offset: 0x19B7E1 VA: 0x19B6E0
	// RVA: 0x2289310 Offset: 0x2289411 VA: 0x2289310
	public List<CharacterBase> get_HitList() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B6F0 Offset: 0x19B7F1 VA: 0x19B6F0
	// RVA: 0x2289320 Offset: 0x2289421 VA: 0x2289320
	public void set_HitList(List<CharacterBase> value) { }

	// RVA: 0x2289330 Offset: 0x2289431 VA: 0x2289330
	private void Start() { }

	// RVA: 0x22893C0 Offset: 0x22894C1 VA: 0x22893C0
	public void Setup(HumanController human, float power, AttackType attackType, float knockbackPower, int blowPower, EffectID effectName, string hitStopName, ItemData itemData) { }

	// RVA: 0x2289640 Offset: 0x2289741 VA: 0x2289640
	protected void OnHit(HitResult result) { }

	// RVA: 0x2289660 Offset: 0x2289761 VA: 0x2289660
	protected void OnHit(Collider collider, Vector3 point, Vector3 normal) { }

	// RVA: 0x2289DC0 Offset: 0x2289EC1 VA: 0x2289DC0
	private void OnTriggerEnter(Collider other) { }

	// RVA: 0x2289F10 Offset: 0x228A011 VA: 0x2289F10
	public void .ctor() { }
}

