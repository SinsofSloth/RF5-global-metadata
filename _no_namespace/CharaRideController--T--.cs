public abstract class CharaRideController<T> : RideController // TypeDefIndex: 6603
{
	// Fields
	[SerializeField] // RVA: 0x15DA20 Offset: 0x15DB21 VA: 0x15DA20
	protected T m_chara; // 0x0
	[SerializeField] // RVA: 0x15DA30 Offset: 0x15DB31 VA: 0x15DA30
	protected Transform m_hips; // 0x0

	// Properties
	public override Actor GetActor { get; }
	public T Character { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public override Actor get_GetActor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25792F0 Offset: 0x25793F1 VA: 0x25792F0
	|-CharaRideController<HumanController>.get_GetActor
	|-CharaRideController<object>.get_GetActor
	*/

	// RVA: -1 Offset: -1
	public T get_Character() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2579320 Offset: 0x2579421 VA: 0x2579320
	|-CharaRideController<object>.get_Character
	*/

	// RVA: -1 Offset: -1 Slot: 5
	protected override void Awake() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2579330 Offset: 0x2579431 VA: 0x2579330
	|-CharaRideController<HumanController>.Awake
	|-CharaRideController<object>.Awake
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void UpdateFadeAlpha(float alpha) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25793F0 Offset: 0x25794F1 VA: 0x25793F0
	|-CharaRideController<HumanController>.UpdateFadeAlpha
	|-CharaRideController<object>.UpdateFadeAlpha
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void UpdateTransform(Vector3 position, Quaternion rotation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2579510 Offset: 0x2579611 VA: 0x2579510
	|-CharaRideController<HumanController>.UpdateTransform
	|-CharaRideController<object>.UpdateTransform
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override void PlayDamageAction(DamageResult damageResult) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2579670 Offset: 0x2579771 VA: 0x2579670
	|-CharaRideController<HumanController>.PlayDamageAction
	|-CharaRideController<object>.PlayDamageAction
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override bool DoStartRide() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2579780 Offset: 0x2579881 VA: 0x2579780
	|-CharaRideController<HumanController>.DoStartRide
	|-CharaRideController<object>.DoStartRide
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void DoEndRide() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2579870 Offset: 0x2579971 VA: 0x2579870
	|-CharaRideController<HumanController>.DoEndRide
	|-CharaRideController<object>.DoEndRide
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2579950 Offset: 0x2579A51 VA: 0x2579950
	|-CharaRideController<HumanController>..ctor
	|-CharaRideController<object>..ctor
	*/
}

