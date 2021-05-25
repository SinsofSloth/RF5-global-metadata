public abstract class CharaGrappleController<T> : GrappleController // TypeDefIndex: 6592
{
	// Fields
	[SerializeField] // RVA: 0x15D920 Offset: 0x15DA21 VA: 0x15D920
	protected T chara; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected override void Awake() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2575500 Offset: 0x2575601 VA: 0x2575500
	|-CharaGrappleController<HumanController>.Awake
	|-CharaGrappleController<object>.Awake
	*/

	// RVA: -1 Offset: -1
	private void OnEnable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25755E0 Offset: 0x25756E1 VA: 0x25755E0
	|-CharaGrappleController<object>.OnEnable
	*/

	// RVA: -1 Offset: -1
	private void OnDisable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25756B0 Offset: 0x25757B1 VA: 0x25756B0
	|-CharaGrappleController<object>.OnDisable
	*/

	// RVA: -1 Offset: -1 Slot: 21
	protected virtual DamageInfo CreateDamageInfo(MagicParamID id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2575770 Offset: 0x2575871 VA: 0x2575770
	|-CharaGrappleController<object>.CreateDamageInfo
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override bool DoGrap(GrapInterface target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2575820 Offset: 0x2575921 VA: 0x2575820
	|-CharaGrappleController<HumanController>.DoGrap
	|-CharaGrappleController<object>.DoGrap
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public override void DoThrow(float angle, float power, MagicParamID id1, MagicParamID id2 = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25758F0 Offset: 0x25759F1 VA: 0x25758F0
	|-CharaGrappleController<HumanController>.DoThrow
	|-CharaGrappleController<object>.DoThrow
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public override void TakeDamage(MagicParamID id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2575FD0 Offset: 0x25760D1 VA: 0x2575FD0
	|-CharaGrappleController<HumanController>.TakeDamage
	|-CharaGrappleController<object>.TakeDamage
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected override void ResetThrowPosition() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2576570 Offset: 0x2576671 VA: 0x2576570
	|-CharaGrappleController<HumanController>.ResetThrowPosition
	|-CharaGrappleController<object>.ResetThrowPosition
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2576AD0 Offset: 0x2576BD1 VA: 0x2576AD0
	|-CharaGrappleController<HumanController>..ctor
	|-CharaGrappleController<object>..ctor
	*/
}

