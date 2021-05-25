[DefaultExecutionOrder] // RVA: 0x145E30 Offset: 0x145F31 VA: 0x145E30
public abstract class CharacterBase : MonoBehaviour // TypeDefIndex: 6613
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x15DDC0 Offset: 0x15DEC1 VA: 0x15DDC0
	private Rigidbody <Rigidbody>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x15DDD0 Offset: 0x15DED1 VA: 0x15DDD0
	private Collider <Collider>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x15DDE0 Offset: 0x15DEE1 VA: 0x15DDE0
	private Animator <Animator>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x15DDF0 Offset: 0x15DEF1 VA: 0x15DDF0
	private CharacterModel <CharacterModel>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x15DE00 Offset: 0x15DF01 VA: 0x15DE00
	private EmotionController <Emotion>k__BackingField; // 0x38
	[HeaderAttribute] // RVA: 0x15DE10 Offset: 0x15DF11 VA: 0x15DE10
	[SerializeField] // RVA: 0x15DE10 Offset: 0x15DF11 VA: 0x15DE10
	private HitMaster hitMaster; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x15DE60 Offset: 0x15DF61 VA: 0x15DE60
	private readonly Alliance <Alliance>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x15DE70 Offset: 0x15DF71 VA: 0x15DE70
	private CharacterBase <ParentCharacterBase>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x15DE80 Offset: 0x15DF81 VA: 0x15DE80
	private readonly Vector3 <GetTakeLockonPos>k__BackingField; // 0x58

	// Properties
	public Rigidbody Rigidbody { get; set; }
	public Collider Collider { get; set; }
	public Animator Animator { get; set; }
	public CharacterModel CharacterModel { get; set; }
	public EmotionController Emotion { get; set; }
	public HitMaster HitMaster { get; }
	public virtual Alliance Alliance { get; }
	public CharacterBase ParentCharacterBase { get; set; }
	public virtual Vector3 GetTakeLockonPos { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19BC80 Offset: 0x19BD81 VA: 0x19BC80
	// RVA: 0x1E4D060 Offset: 0x1E4D161 VA: 0x1E4D060
	public Rigidbody get_Rigidbody() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BC90 Offset: 0x19BD91 VA: 0x19BC90
	// RVA: 0x1E4D070 Offset: 0x1E4D171 VA: 0x1E4D070
	protected void set_Rigidbody(Rigidbody value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19BCA0 Offset: 0x19BDA1 VA: 0x19BCA0
	// RVA: 0x1E4D080 Offset: 0x1E4D181 VA: 0x1E4D080 Slot: 4
	public Collider get_Collider() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BCB0 Offset: 0x19BDB1 VA: 0x19BCB0
	// RVA: 0x1E4D090 Offset: 0x1E4D191 VA: 0x1E4D090
	protected void set_Collider(Collider value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19BCC0 Offset: 0x19BDC1 VA: 0x19BCC0
	// RVA: 0x1E4D0A0 Offset: 0x1E4D1A1 VA: 0x1E4D0A0
	public Animator get_Animator() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BCD0 Offset: 0x19BDD1 VA: 0x19BCD0
	// RVA: 0x1E4D0B0 Offset: 0x1E4D1B1 VA: 0x1E4D0B0
	protected void set_Animator(Animator value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19BCE0 Offset: 0x19BDE1 VA: 0x19BCE0
	// RVA: 0x1E4D0C0 Offset: 0x1E4D1C1 VA: 0x1E4D0C0
	public CharacterModel get_CharacterModel() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BCF0 Offset: 0x19BDF1 VA: 0x19BCF0
	// RVA: 0x1E4D0D0 Offset: 0x1E4D1D1 VA: 0x1E4D0D0
	protected void set_CharacterModel(CharacterModel value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19BD00 Offset: 0x19BE01 VA: 0x19BD00
	// RVA: 0x1E4D0E0 Offset: 0x1E4D1E1 VA: 0x1E4D0E0
	public EmotionController get_Emotion() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BD10 Offset: 0x19BE11 VA: 0x19BD10
	// RVA: 0x1E4D0F0 Offset: 0x1E4D1F1 VA: 0x1E4D0F0
	protected void set_Emotion(EmotionController value) { }

	// RVA: 0x1E4D100 Offset: 0x1E4D201 VA: 0x1E4D100
	public HitMaster get_HitMaster() { }

	// RVA: 0x1E4D110 Offset: 0x1E4D211 VA: 0x1E4D110 Slot: 5
	public virtual void OnEnableHitSystem() { }

	// RVA: 0x1E4D120 Offset: 0x1E4D221 VA: 0x1E4D120 Slot: 6
	public virtual void OnHitSystemTriggerEnter(Collider collider, CharacterBase characterBase, Vector3 direction, HitOptionParamID paramID, Collider attackCollider) { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool TakeDamage(DamageInfo damageInfo, out DamageResult damageResult) { }

	[CompilerGeneratedAttribute] // RVA: 0x19BD20 Offset: 0x19BE21 VA: 0x19BD20
	// RVA: 0x1E4D130 Offset: 0x1E4D231 VA: 0x1E4D130 Slot: 8
	public virtual Alliance get_Alliance() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BD30 Offset: 0x19BE31 VA: 0x19BD30
	// RVA: 0x1E4D140 Offset: 0x1E4D241 VA: 0x1E4D140
	public CharacterBase get_ParentCharacterBase() { }

	[CompilerGeneratedAttribute] // RVA: 0x19BD40 Offset: 0x19BE41 VA: 0x19BD40
	// RVA: 0x1E4D150 Offset: 0x1E4D251 VA: 0x1E4D150
	public void set_ParentCharacterBase(CharacterBase value) { }

	// RVA: 0x1E4D160 Offset: 0x1E4D261 VA: 0x1E4D160 Slot: 9
	public virtual bool IsCanNotLockon(CharacterBase lockonCharacter) { }

	[CompilerGeneratedAttribute] // RVA: 0x19BD50 Offset: 0x19BE51 VA: 0x19BD50
	// RVA: 0x1E4D170 Offset: 0x1E4D271 VA: 0x1E4D170 Slot: 10
	public virtual Vector3 get_GetTakeLockonPos() { }

	// RVA: 0x1E4D180 Offset: 0x1E4D281 VA: 0x1E4D180 Slot: 11
	protected virtual void Awake() { }

	// RVA: 0x1E4D2E0 Offset: 0x1E4D3E1 VA: 0x1E4D2E0 Slot: 12
	protected virtual void Start() { }

	// RVA: 0x1E4D2F0 Offset: 0x1E4D3F1 VA: 0x1E4D2F0 Slot: 13
	protected virtual void OnEnable() { }

	// RVA: 0x1E4D300 Offset: 0x1E4D401 VA: 0x1E4D300 Slot: 14
	public virtual void ResetAnimator() { }

	// RVA: 0x1E4D470 Offset: 0x1E4D571 VA: 0x1E4D470 Slot: 15
	public virtual void SetNearCullingEnable(bool enable) { }

	// RVA: 0x1E4D650 Offset: 0x1E4D751 VA: 0x1E4D650
	protected void .ctor() { }
}

