public abstract class CharaMagicController<T> : MagicController // TypeDefIndex: 6596
{
	// Fields
	[SerializeField] // RVA: 0x15D970 Offset: 0x15DA71 VA: 0x15D970
	protected T chara; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x15D980 Offset: 0x15DA81 VA: 0x15D980
	private MagicDataTable <CurrentDataTable>k__BackingField; // 0x0

	// Properties
	protected MagicDataTable CurrentDataTable { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19B940 Offset: 0x19BA41 VA: 0x19B940
	// RVA: -1 Offset: -1
	protected MagicDataTable get_CurrentDataTable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2576F80 Offset: 0x2577081 VA: 0x2576F80
	|-CharaMagicController<HumanController>.get_CurrentDataTable
	|-CharaMagicController<object>.get_CurrentDataTable
	*/

	[CompilerGeneratedAttribute] // RVA: 0x19B950 Offset: 0x19BA51 VA: 0x19B950
	// RVA: -1 Offset: -1
	private void set_CurrentDataTable(MagicDataTable value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2576F90 Offset: 0x2577091 VA: 0x2576F90
	|-CharaMagicController<object>.set_CurrentDataTable
	*/

	// RVA: -1 Offset: -1
	protected void Awake() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2576FA0 Offset: 0x25770A1 VA: 0x2576FA0
	|-CharaMagicController<object>.Awake
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected virtual void OnEnable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2577070 Offset: 0x2577171 VA: 0x2577070
	|-CharaMagicController<HumanController>.OnEnable
	|-CharaMagicController<MagicTestChara>.OnEnable
	|-CharaMagicController<MonsterControllerBase>.OnEnable
	|-CharaMagicController<object>.OnEnable
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected virtual void OnDisable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2577140 Offset: 0x2577241 VA: 0x2577140
	|-CharaMagicController<HumanController>.OnDisable
	|-CharaMagicController<MagicTestChara>.OnDisable
	|-CharaMagicController<MonsterControllerBase>.OnDisable
	|-CharaMagicController<object>.OnDisable
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override bool CanPlay() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2577210 Offset: 0x2577311 VA: 0x2577210
	|-CharaMagicController<HumanController>.CanPlay
	|-CharaMagicController<MagicTestChara>.CanPlay
	|-CharaMagicController<MonsterControllerBase>.CanPlay
	|-CharaMagicController<object>.CanPlay
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override bool DoPlay(MagicID magicId, int level, AttackAttribute attribute, Vector3 offset, float rpRate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2577220 Offset: 0x2577321 VA: 0x2577220
	|-CharaMagicController<HumanController>.DoPlay
	|-CharaMagicController<MagicTestChara>.DoPlay
	|-CharaMagicController<MonsterControllerBase>.DoPlay
	|-CharaMagicController<object>.DoPlay
	*/

	// RVA: -1 Offset: -1
	protected void SetTargets(MagicTarget target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2577710 Offset: 0x2577811 VA: 0x2577710
	|-CharaMagicController<object>.SetTargets
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual bool AddTarget(Collider target, TargetAlliance alliance, CharacterBase owner) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2577ED0 Offset: 0x2577FD1 VA: 0x2577ED0
	|-CharaMagicController<HumanController>.AddTarget
	|-CharaMagicController<MagicTestChara>.AddTarget
	|-CharaMagicController<MonsterControllerBase>.AddTarget
	|-CharaMagicController<object>.AddTarget
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual bool AddTarget(Collider target, CharacterBase targetChara, TargetAlliance alliance, CharacterBase owner) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2577FC0 Offset: 0x25780C1 VA: 0x2577FC0
	|-CharaMagicController<HumanController>.AddTarget
	|-CharaMagicController<MagicTestChara>.AddTarget
	|-CharaMagicController<MonsterControllerBase>.AddTarget
	|-CharaMagicController<object>.AddTarget
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2578130 Offset: 0x2578231 VA: 0x2578130
	|-CharaMagicController<HumanController>..ctor
	|-CharaMagicController<MagicTestChara>..ctor
	|-CharaMagicController<MonsterControllerBase>..ctor
	|-CharaMagicController<object>..ctor
	*/
}

