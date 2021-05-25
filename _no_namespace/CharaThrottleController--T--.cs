public abstract class CharaThrottleController<T> : ThrottleController // TypeDefIndex: 6608
{
	// Fields
	[SerializeField] // RVA: 0x15DA80 Offset: 0x15DB81 VA: 0x15DA80
	protected T chara; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	protected void Awake() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x257A5E0 Offset: 0x257A6E1 VA: 0x257A5E0
	|-CharaThrottleController<object>.Awake
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected virtual void OnEnable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x257A6B0 Offset: 0x257A7B1 VA: 0x257A6B0
	|-CharaThrottleController<HumanController>.OnEnable
	|-CharaThrottleController<object>.OnEnable
	*/

	// RVA: -1 Offset: -1 Slot: 13
	protected virtual void OnDisable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x257A780 Offset: 0x257A881 VA: 0x257A780
	|-CharaThrottleController<HumanController>.OnDisable
	|-CharaThrottleController<object>.OnDisable
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override bool CanPlay() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x257A850 Offset: 0x257A951 VA: 0x257A850
	|-CharaThrottleController<HumanController>.CanPlay
	|-CharaThrottleController<object>.CanPlay
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override bool DoPlay(ThrottleID throttleID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x257A910 Offset: 0x257AA11 VA: 0x257A910
	|-CharaThrottleController<HumanController>.DoPlay
	|-CharaThrottleController<object>.DoPlay
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override bool DoStop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x257AA00 Offset: 0x257AB01 VA: 0x257AA00
	|-CharaThrottleController<HumanController>.DoStop
	|-CharaThrottleController<object>.DoStop
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x257AAE0 Offset: 0x257ABE1 VA: 0x257AAE0
	|-CharaThrottleController<HumanController>..ctor
	|-CharaThrottleController<object>..ctor
	*/
}

