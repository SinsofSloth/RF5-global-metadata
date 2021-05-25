public class GimmickThunderbolt : GimmickBase // TypeDefIndex: 7592
{
	// Fields
	[SerializeField] // RVA: 0x167C90 Offset: 0x167D91 VA: 0x167C90
	private GimmickThunderbolt.ThunderboltType Type; // 0x20
	[SerializeField] // RVA: 0x167CA0 Offset: 0x167DA1 VA: 0x167CA0
	private GameObject Target; // 0x28
	[SerializeField] // RVA: 0x167CB0 Offset: 0x167DB1 VA: 0x167CB0
	[RangeAttribute] // RVA: 0x167CB0 Offset: 0x167DB1 VA: 0x167CB0
	private float Damage; // 0x30
	[SerializeField] // RVA: 0x167D00 Offset: 0x167E01 VA: 0x167D00
	private float AttackKnockbackPower; // 0x34
	[SerializeField] // RVA: 0x167D10 Offset: 0x167E11 VA: 0x167D10
	private float EffectScale; // 0x38
	[SerializeField] // RVA: 0x167D20 Offset: 0x167E21 VA: 0x167D20
	[TooltipAttribute] // RVA: 0x167D20 Offset: 0x167E21 VA: 0x167D20
	protected float A_Second; // 0x3C
	[SerializeField] // RVA: 0x167D70 Offset: 0x167E71 VA: 0x167D70
	[TooltipAttribute] // RVA: 0x167D70 Offset: 0x167E71 VA: 0x167D70
	protected float B_Second_Min; // 0x40
	[SerializeField] // RVA: 0x167DC0 Offset: 0x167EC1 VA: 0x167DC0
	[TooltipAttribute] // RVA: 0x167DC0 Offset: 0x167EC1 VA: 0x167DC0
	protected float B_Second_Max; // 0x44
	[SerializeField] // RVA: 0x167E10 Offset: 0x167F11 VA: 0x167E10
	[TooltipAttribute] // RVA: 0x167E10 Offset: 0x167F11 VA: 0x167E10
	protected float C_Second; // 0x48
	[SerializeField] // RVA: 0x167E60 Offset: 0x167F61 VA: 0x167E60
	[TooltipAttribute] // RVA: 0x167E60 Offset: 0x167F61 VA: 0x167E60
	protected float D_Second; // 0x4C
	[SerializeField] // RVA: 0x167EB0 Offset: 0x167FB1 VA: 0x167EB0
	[HeaderAttribute] // RVA: 0x167EB0 Offset: 0x167FB1 VA: 0x167EB0
	private Vector3 DamageCenter; // 0x50
	[SerializeField] // RVA: 0x167F00 Offset: 0x168001 VA: 0x167F00
	private float DamageRadius; // 0x5C
	[SerializeField] // RVA: 0x167F10 Offset: 0x168011 VA: 0x167F10
	private float DamageHeight; // 0x60
	private SimpleTriggerEventDispatcher SimpleTriggerEventDispatcher; // 0x68
	private bool stayRoom; // 0x70
	private bool startEffect; // 0x71
	private ParticleSystem sign_effect_; // 0x78
	private ParticleSystem thunder_effect_; // 0x80
	private ParticleSystem thunder_loop_effect_; // 0x88
	private Coroutine coroutine_; // 0x90
	private float CurrentTime; // 0x98
	private Vector3 targetPos; // 0x9C
	private GameObject Thunderbolt; // 0xA8
	private SoundID soundID; // 0xB0
	private SEController se_controller; // 0xB8

	// Methods

	// RVA: 0x1EA7CF0 Offset: 0x1EA7DF1 VA: 0x1EA7CF0 Slot: 6
	protected override void Start() { }

	// RVA: 0x1EA7EF0 Offset: 0x1EA7FF1 VA: 0x1EA7EF0
	private void Update() { }

	// RVA: 0x1EA8260 Offset: 0x1EA8361 VA: 0x1EA8260 Slot: 5
	protected override void OnDestroy() { }

	// RVA: 0x1EA81C0 Offset: 0x1EA82C1 VA: 0x1EA81C0
	private void StartEffect() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A1E70 Offset: 0x1A1F71 VA: 0x1A1E70
	// RVA: 0x1EA86D0 Offset: 0x1EA87D1 VA: 0x1EA86D0
	private IEnumerator ThunderboltCoroutine() { }

	// RVA: 0x1EA8780 Offset: 0x1EA8881 VA: 0x1EA8780
	private void StopSignEffect() { }

	// RVA: 0x1EA8830 Offset: 0x1EA8931 VA: 0x1EA8830
	private void PlaySignEffect(Vector3 pos, Quaternion rot, float scale) { }

	// RVA: 0x1EA84E0 Offset: 0x1EA85E1 VA: 0x1EA84E0
	private void StopThunderEffect() { }

	// RVA: 0x1EA89D0 Offset: 0x1EA8AD1 VA: 0x1EA89D0
	private void PlayThunderEffect(Vector3 pos, Quaternion rot, float scale) { }

	// RVA: 0x1EA8CA0 Offset: 0x1EA8DA1 VA: 0x1EA8CA0
	private void CreateThunderbolt(Vector3 pos, float scale, float damage) { }

	// RVA: 0x1EA85F0 Offset: 0x1EA86F1 VA: 0x1EA85F0
	private void DeleteThunderbolt() { }

	// RVA: 0x1EA8F50 Offset: 0x1EA9051 VA: 0x1EA8F50
	private void OnStayEvent(Collider fromCollider, Collider toCollider) { }

	// RVA: 0x1EA9060 Offset: 0x1EA9161 VA: 0x1EA9060
	private void OnExitEvent(Collider fromCollider, Collider toCollider) { }

	// RVA: 0x1EA9170 Offset: 0x1EA9271 VA: 0x1EA9170
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1EE0 Offset: 0x1A1FE1 VA: 0x1A1EE0
	// RVA: 0x1EA9270 Offset: 0x1EA9371 VA: 0x1EA9270
	private void <Start>b__26_0(ParticleSystem obj) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1EF0 Offset: 0x1A1FF1 VA: 0x1A1EF0
	// RVA: 0x1EA92E0 Offset: 0x1EA93E1 VA: 0x1EA92E0
	private void <Start>b__26_1(ParticleSystem obj) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1F00 Offset: 0x1A2001 VA: 0x1A1F00
	// RVA: 0x1EA9350 Offset: 0x1EA9451 VA: 0x1EA9350
	private void <Start>b__26_2(ParticleSystem obj) { }
}

