public abstract class CharaSlowStateController<T> : SlowStateController // TypeDefIndex: 6797
{
	// Fields
	private const float SlowStateDuration = 10;
	[SerializeField] // RVA: 0x15FA20 Offset: 0x15FB21 VA: 0x15FA20
	protected T chara; // 0x0
	private float m_elapsed; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected override void Awake() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2579970 Offset: 0x2579A71 VA: 0x2579970
	|-CharaSlowStateController<HumanController>.Awake
	|-CharaSlowStateController<MonsterControllerBase>.Awake
	|-CharaSlowStateController<object>.Awake
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected virtual void OnEnable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2579A40 Offset: 0x2579B41 VA: 0x2579A40
	|-CharaSlowStateController<HumanController>.OnEnable
	|-CharaSlowStateController<MonsterControllerBase>.OnEnable
	|-CharaSlowStateController<object>.OnEnable
	*/

	// RVA: -1 Offset: -1 Slot: 5
	protected override void OnDisable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2579B10 Offset: 0x2579C11 VA: 0x2579B10
	|-CharaSlowStateController<HumanController>.OnDisable
	|-CharaSlowStateController<MonsterControllerBase>.OnDisable
	|-CharaSlowStateController<object>.OnDisable
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override void OnUpdate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2579BF0 Offset: 0x2579CF1 VA: 0x2579BF0
	|-CharaSlowStateController<HumanController>.OnUpdate
	|-CharaSlowStateController<MonsterControllerBase>.OnUpdate
	|-CharaSlowStateController<object>.OnUpdate
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void DoSlow() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2579CD0 Offset: 0x2579DD1 VA: 0x2579CD0
	|-CharaSlowStateController<HumanController>.DoSlow
	|-CharaSlowStateController<MonsterControllerBase>.DoSlow
	|-CharaSlowStateController<object>.DoSlow
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2579D20 Offset: 0x2579E21 VA: 0x2579D20
	|-CharaSlowStateController<HumanController>..ctor
	|-CharaSlowStateController<MonsterControllerBase>..ctor
	|-CharaSlowStateController<object>..ctor
	*/
}

