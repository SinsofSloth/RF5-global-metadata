public class AttackCollider : MonoBehaviour // TypeDefIndex: 8948
{
	// Fields
	public OnAttackCollisionEvent TriggerEnter; // 0x18
	private Collider _Collider; // 0x20
	private Rigidbody Rigidbody; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x174D70 Offset: 0x174E71 VA: 0x174D70
	private List<CharacterBase> <HitList>k__BackingField; // 0x30

	// Properties
	private Collider Collider { get; }
	public List<CharacterBase> HitList { get; set; }

	// Methods

	// RVA: 0x2288DC0 Offset: 0x2288EC1 VA: 0x2288DC0
	private Collider get_Collider() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9340 Offset: 0x1A9441 VA: 0x1A9340
	// RVA: 0x2288E90 Offset: 0x2288F91 VA: 0x2288E90
	public List<CharacterBase> get_HitList() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A9350 Offset: 0x1A9451 VA: 0x1A9350
	// RVA: 0x2288EA0 Offset: 0x2288FA1 VA: 0x2288EA0
	public void set_HitList(List<CharacterBase> value) { }

	// RVA: 0x2288EB0 Offset: 0x2288FB1 VA: 0x2288EB0
	private void Start() { }

	// RVA: 0x2289090 Offset: 0x2289191 VA: 0x2289090
	private void OnTriggerEnter(Collider other) { }

	// RVA: 0x2289260 Offset: 0x2289361 VA: 0x2289260
	public void SetColliderEnable(bool enable) { }

	// RVA: 0x2289290 Offset: 0x2289391 VA: 0x2289290
	public void .ctor() { }
}

