public abstract class CharaRestraintController<T> : RestraintController // TypeDefIndex: 6783
{
	// Fields
	[SerializeField] // RVA: 0x15F800 Offset: 0x15F901 VA: 0x15F800
	protected T chara; // 0x0
	protected float m_elapsed; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected override void Awake() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2578F30 Offset: 0x2579031 VA: 0x2578F30
	|-CharaRestraintController<HumanController>.Awake
	|-CharaRestraintController<MonsterControllerBase>.Awake
	|-CharaRestraintController<object>.Awake
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected virtual void OnEnable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2579000 Offset: 0x2579101 VA: 0x2579000
	|-CharaRestraintController<HumanController>.OnEnable
	|-CharaRestraintController<MonsterControllerBase>.OnEnable
	|-CharaRestraintController<object>.OnEnable
	*/

	// RVA: -1 Offset: -1 Slot: 5
	protected override void OnDisable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25790D0 Offset: 0x25791D1 VA: 0x25790D0
	|-CharaRestraintController<HumanController>.OnDisable
	|-CharaRestraintController<MonsterControllerBase>.OnDisable
	|-CharaRestraintController<object>.OnDisable
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override void Setup() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25791B0 Offset: 0x25792B1 VA: 0x25791B0
	|-CharaRestraintController<HumanController>.Setup
	|-CharaRestraintController<MonsterControllerBase>.Setup
	|-CharaRestraintController<object>.Setup
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract bool ReleaseCondition() { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-CharaRestraintController<object>.ReleaseCondition
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override void OnUpdate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2579210 Offset: 0x2579311 VA: 0x2579210
	|-CharaRestraintController<HumanController>.OnUpdate
	|-CharaRestraintController<MonsterControllerBase>.OnUpdate
	|-CharaRestraintController<object>.OnUpdate
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnRestraint() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25792A0 Offset: 0x25793A1 VA: 0x25792A0
	|-CharaRestraintController<HumanController>.OnRestraint
	|-CharaRestraintController<MonsterControllerBase>.OnRestraint
	|-CharaRestraintController<object>.OnRestraint
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25792D0 Offset: 0x25793D1 VA: 0x25792D0
	|-CharaRestraintController<HumanController>..ctor
	|-CharaRestraintController<MonsterControllerBase>..ctor
	|-CharaRestraintController<object>..ctor
	*/
}

