public class FieldRandomTreasureBoxSpawner : FieldTreasureBoxSpawner // TypeDefIndex: 10493
{
	// Fields
	[SerializeField] // RVA: 0x181C00 Offset: 0x181D01 VA: 0x181C00
	private FieldRandomTreasureBoxSpawnID _RandomBoxSpawnID; // 0x3C
	private FieldUniqueTreasureBoxSpawner UniqueBoxSpawner; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x181C10 Offset: 0x181D11 VA: 0x181C10
	private MonsterControllerBase <MonsterControllerBase>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x181C20 Offset: 0x181D21 VA: 0x181C20
	private EnemyBehaviorController <EnemyBehaviorController>k__BackingField; // 0x50
	private MonsterDataID SpawnMonsterDataID; // 0x58
	private bool IsSpawnMonster; // 0x5C
	private bool IsDefeatMonster; // 0x5D
	private bool isAddSpawnEvent; // 0x5E
	private static readonly FieldTreasureBoxType[] BoxPrefabType; // 0x0

	// Properties
	public FieldRandomTreasureBoxSpawnID RandomBoxSpawnID { get; set; }
	public MonsterControllerBase MonsterControllerBase { get; set; }
	public EnemyBehaviorController EnemyBehaviorController { get; set; }

	// Methods

	// RVA: 0x1E27ED0 Offset: 0x1E27FD1 VA: 0x1E27ED0
	public FieldRandomTreasureBoxSpawnID get_RandomBoxSpawnID() { }

	// RVA: 0x1E27EE0 Offset: 0x1E27FE1 VA: 0x1E27EE0
	private void set_RandomBoxSpawnID(FieldRandomTreasureBoxSpawnID value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF900 Offset: 0x1AFA01 VA: 0x1AF900
	// RVA: 0x1E27EF0 Offset: 0x1E27FF1 VA: 0x1E27EF0
	public MonsterControllerBase get_MonsterControllerBase() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF910 Offset: 0x1AFA11 VA: 0x1AF910
	// RVA: 0x1E27F00 Offset: 0x1E28001 VA: 0x1E27F00
	private void set_MonsterControllerBase(MonsterControllerBase value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF920 Offset: 0x1AFA21 VA: 0x1AF920
	// RVA: 0x1E27F10 Offset: 0x1E28011 VA: 0x1E27F10
	public EnemyBehaviorController get_EnemyBehaviorController() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF930 Offset: 0x1AFA31 VA: 0x1AF930
	// RVA: 0x1E27F20 Offset: 0x1E28021 VA: 0x1E27F20
	private void set_EnemyBehaviorController(EnemyBehaviorController value) { }

	// RVA: 0x1E27F30 Offset: 0x1E28031 VA: 0x1E27F30
	private void OnDestroy() { }

	// RVA: 0x1E282E0 Offset: 0x1E283E1 VA: 0x1E282E0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1E28420 Offset: 0x1E28521 VA: 0x1E28420 Slot: 4
	protected override void Start() { }

	// RVA: 0x1E28610 Offset: 0x1E28711 VA: 0x1E28610 Slot: 6
	public override void Spawn() { }

	// RVA: 0x1E29770 Offset: 0x1E29871 VA: 0x1E29770
	public void SetBossStageManager(BossStageManager stage) { }

	// RVA: 0x1E29870 Offset: 0x1E29971 VA: 0x1E29870
	private void OnDeadBossStage(BossStageManager stage) { }

	// RVA: 0x1E29A50 Offset: 0x1E29B51 VA: 0x1E29A50
	private void TreasureBoxSpawn(FieldTreasureBox treasureBox, Vector3 position, Quaternion rotation, Vector3 offset) { }

	// RVA: 0x1E29140 Offset: 0x1E29241 VA: 0x1E29140
	private int GetBoxType(int[] ratios) { }

	// RVA: 0x1E29C70 Offset: 0x1E29D71 VA: 0x1E29C70
	public void SetEnemyInit(MonsterControllerBase setMonsterControllerBase, EnemyBehaviorController setEnemyBehaviorController) { }

	// RVA: 0x1E29D90 Offset: 0x1E29E91 VA: 0x1E29D90
	private void OnFinishDead(MonsterControllerBase monsterControllerBase) { }

	// RVA: 0x1E29E70 Offset: 0x1E29F71 VA: 0x1E29E70
	public void RemoveBox() { }

	// RVA: 0x1E29FD0 Offset: 0x1E2A0D1 VA: 0x1E29FD0
	public void .ctor() { }

	// RVA: 0x1E2A0B0 Offset: 0x1E2A1B1 VA: 0x1E2A0B0
	private static void .cctor() { }
}

public class FieldRandomTreasureBoxSpawner : FieldTreasureBoxSpawner // TypeDefIndex: 10493
{
	// Fields
	[SerializeField] // RVA: 0x181C00 Offset: 0x181D01 VA: 0x181C00
	private FieldRandomTreasureBoxSpawnID _RandomBoxSpawnID; // 0x3C
	private FieldUniqueTreasureBoxSpawner UniqueBoxSpawner; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x181C10 Offset: 0x181D11 VA: 0x181C10
	private MonsterControllerBase <MonsterControllerBase>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x181C20 Offset: 0x181D21 VA: 0x181C20
	private EnemyBehaviorController <EnemyBehaviorController>k__BackingField; // 0x50
	private MonsterDataID SpawnMonsterDataID; // 0x58
	private bool IsSpawnMonster; // 0x5C
	private bool IsDefeatMonster; // 0x5D
	private bool isAddSpawnEvent; // 0x5E
	private static readonly FieldTreasureBoxType[] BoxPrefabType; // 0x0

	// Properties
	public FieldRandomTreasureBoxSpawnID RandomBoxSpawnID { get; set; }
	public MonsterControllerBase MonsterControllerBase { get; set; }
	public EnemyBehaviorController EnemyBehaviorController { get; set; }

	// Methods

	// RVA: 0x1E27ED0 Offset: 0x1E27FD1 VA: 0x1E27ED0
	public FieldRandomTreasureBoxSpawnID get_RandomBoxSpawnID() { }

	// RVA: 0x1E27EE0 Offset: 0x1E27FE1 VA: 0x1E27EE0
	private void set_RandomBoxSpawnID(FieldRandomTreasureBoxSpawnID value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF900 Offset: 0x1AFA01 VA: 0x1AF900
	// RVA: 0x1E27EF0 Offset: 0x1E27FF1 VA: 0x1E27EF0
	public MonsterControllerBase get_MonsterControllerBase() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF910 Offset: 0x1AFA11 VA: 0x1AF910
	// RVA: 0x1E27F00 Offset: 0x1E28001 VA: 0x1E27F00
	private void set_MonsterControllerBase(MonsterControllerBase value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF920 Offset: 0x1AFA21 VA: 0x1AF920
	// RVA: 0x1E27F10 Offset: 0x1E28011 VA: 0x1E27F10
	public EnemyBehaviorController get_EnemyBehaviorController() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF930 Offset: 0x1AFA31 VA: 0x1AF930
	// RVA: 0x1E27F20 Offset: 0x1E28021 VA: 0x1E27F20
	private void set_EnemyBehaviorController(EnemyBehaviorController value) { }

	// RVA: 0x1E27F30 Offset: 0x1E28031 VA: 0x1E27F30
	private void OnDestroy() { }

	// RVA: 0x1E282E0 Offset: 0x1E283E1 VA: 0x1E282E0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1E28420 Offset: 0x1E28521 VA: 0x1E28420 Slot: 4
	protected override void Start() { }

	// RVA: 0x1E28610 Offset: 0x1E28711 VA: 0x1E28610 Slot: 6
	public override void Spawn() { }

	// RVA: 0x1E29770 Offset: 0x1E29871 VA: 0x1E29770
	public void SetBossStageManager(BossStageManager stage) { }

	// RVA: 0x1E29870 Offset: 0x1E29971 VA: 0x1E29870
	private void OnDeadBossStage(BossStageManager stage) { }

	// RVA: 0x1E29A50 Offset: 0x1E29B51 VA: 0x1E29A50
	private void TreasureBoxSpawn(FieldTreasureBox treasureBox, Vector3 position, Quaternion rotation, Vector3 offset) { }

	// RVA: 0x1E29140 Offset: 0x1E29241 VA: 0x1E29140
	private int GetBoxType(int[] ratios) { }

	// RVA: 0x1E29C70 Offset: 0x1E29D71 VA: 0x1E29C70
	public void SetEnemyInit(MonsterControllerBase setMonsterControllerBase, EnemyBehaviorController setEnemyBehaviorController) { }

	// RVA: 0x1E29D90 Offset: 0x1E29E91 VA: 0x1E29D90
	private void OnFinishDead(MonsterControllerBase monsterControllerBase) { }

	// RVA: 0x1E29E70 Offset: 0x1E29F71 VA: 0x1E29E70
	public void RemoveBox() { }

	// RVA: 0x1E29FD0 Offset: 0x1E2A0D1 VA: 0x1E29FD0
	public void .ctor() { }

	// RVA: 0x1E2A0B0 Offset: 0x1E2A1B1 VA: 0x1E2A0B0
	private static void .cctor() { }
}

public class FieldRandomTreasureBoxSpawner : FieldTreasureBoxSpawner // TypeDefIndex: 10493
{
	// Fields
	[SerializeField] // RVA: 0x181C00 Offset: 0x181D01 VA: 0x181C00
	private FieldRandomTreasureBoxSpawnID _RandomBoxSpawnID; // 0x3C
	private FieldUniqueTreasureBoxSpawner UniqueBoxSpawner; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x181C10 Offset: 0x181D11 VA: 0x181C10
	private MonsterControllerBase <MonsterControllerBase>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x181C20 Offset: 0x181D21 VA: 0x181C20
	private EnemyBehaviorController <EnemyBehaviorController>k__BackingField; // 0x50
	private MonsterDataID SpawnMonsterDataID; // 0x58
	private bool IsSpawnMonster; // 0x5C
	private bool IsDefeatMonster; // 0x5D
	private bool isAddSpawnEvent; // 0x5E
	private static readonly FieldTreasureBoxType[] BoxPrefabType; // 0x0

	// Properties
	public FieldRandomTreasureBoxSpawnID RandomBoxSpawnID { get; set; }
	public MonsterControllerBase MonsterControllerBase { get; set; }
	public EnemyBehaviorController EnemyBehaviorController { get; set; }

	// Methods

	// RVA: 0x1E27ED0 Offset: 0x1E27FD1 VA: 0x1E27ED0
	public FieldRandomTreasureBoxSpawnID get_RandomBoxSpawnID() { }

	// RVA: 0x1E27EE0 Offset: 0x1E27FE1 VA: 0x1E27EE0
	private void set_RandomBoxSpawnID(FieldRandomTreasureBoxSpawnID value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF900 Offset: 0x1AFA01 VA: 0x1AF900
	// RVA: 0x1E27EF0 Offset: 0x1E27FF1 VA: 0x1E27EF0
	public MonsterControllerBase get_MonsterControllerBase() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF910 Offset: 0x1AFA11 VA: 0x1AF910
	// RVA: 0x1E27F00 Offset: 0x1E28001 VA: 0x1E27F00
	private void set_MonsterControllerBase(MonsterControllerBase value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF920 Offset: 0x1AFA21 VA: 0x1AF920
	// RVA: 0x1E27F10 Offset: 0x1E28011 VA: 0x1E27F10
	public EnemyBehaviorController get_EnemyBehaviorController() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF930 Offset: 0x1AFA31 VA: 0x1AF930
	// RVA: 0x1E27F20 Offset: 0x1E28021 VA: 0x1E27F20
	private void set_EnemyBehaviorController(EnemyBehaviorController value) { }

	// RVA: 0x1E27F30 Offset: 0x1E28031 VA: 0x1E27F30
	private void OnDestroy() { }

	// RVA: 0x1E282E0 Offset: 0x1E283E1 VA: 0x1E282E0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1E28420 Offset: 0x1E28521 VA: 0x1E28420 Slot: 4
	protected override void Start() { }

	// RVA: 0x1E28610 Offset: 0x1E28711 VA: 0x1E28610 Slot: 6
	public override void Spawn() { }

	// RVA: 0x1E29770 Offset: 0x1E29871 VA: 0x1E29770
	public void SetBossStageManager(BossStageManager stage) { }

	// RVA: 0x1E29870 Offset: 0x1E29971 VA: 0x1E29870
	private void OnDeadBossStage(BossStageManager stage) { }

	// RVA: 0x1E29A50 Offset: 0x1E29B51 VA: 0x1E29A50
	private void TreasureBoxSpawn(FieldTreasureBox treasureBox, Vector3 position, Quaternion rotation, Vector3 offset) { }

	// RVA: 0x1E29140 Offset: 0x1E29241 VA: 0x1E29140
	private int GetBoxType(int[] ratios) { }

	// RVA: 0x1E29C70 Offset: 0x1E29D71 VA: 0x1E29C70
	public void SetEnemyInit(MonsterControllerBase setMonsterControllerBase, EnemyBehaviorController setEnemyBehaviorController) { }

	// RVA: 0x1E29D90 Offset: 0x1E29E91 VA: 0x1E29D90
	private void OnFinishDead(MonsterControllerBase monsterControllerBase) { }

	// RVA: 0x1E29E70 Offset: 0x1E29F71 VA: 0x1E29E70
	public void RemoveBox() { }

	// RVA: 0x1E29FD0 Offset: 0x1E2A0D1 VA: 0x1E29FD0
	public void .ctor() { }

	// RVA: 0x1E2A0B0 Offset: 0x1E2A1B1 VA: 0x1E2A0B0
	private static void .cctor() { }
}

public class FieldRandomTreasureBoxSpawner : FieldTreasureBoxSpawner // TypeDefIndex: 10493
{
	// Fields
	[SerializeField] // RVA: 0x181C00 Offset: 0x181D01 VA: 0x181C00
	private FieldRandomTreasureBoxSpawnID _RandomBoxSpawnID; // 0x3C
	private FieldUniqueTreasureBoxSpawner UniqueBoxSpawner; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x181C10 Offset: 0x181D11 VA: 0x181C10
	private MonsterControllerBase <MonsterControllerBase>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x181C20 Offset: 0x181D21 VA: 0x181C20
	private EnemyBehaviorController <EnemyBehaviorController>k__BackingField; // 0x50
	private MonsterDataID SpawnMonsterDataID; // 0x58
	private bool IsSpawnMonster; // 0x5C
	private bool IsDefeatMonster; // 0x5D
	private bool isAddSpawnEvent; // 0x5E
	private static readonly FieldTreasureBoxType[] BoxPrefabType; // 0x0

	// Properties
	public FieldRandomTreasureBoxSpawnID RandomBoxSpawnID { get; set; }
	public MonsterControllerBase MonsterControllerBase { get; set; }
	public EnemyBehaviorController EnemyBehaviorController { get; set; }

	// Methods

	// RVA: 0x1E27ED0 Offset: 0x1E27FD1 VA: 0x1E27ED0
	public FieldRandomTreasureBoxSpawnID get_RandomBoxSpawnID() { }

	// RVA: 0x1E27EE0 Offset: 0x1E27FE1 VA: 0x1E27EE0
	private void set_RandomBoxSpawnID(FieldRandomTreasureBoxSpawnID value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF900 Offset: 0x1AFA01 VA: 0x1AF900
	// RVA: 0x1E27EF0 Offset: 0x1E27FF1 VA: 0x1E27EF0
	public MonsterControllerBase get_MonsterControllerBase() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF910 Offset: 0x1AFA11 VA: 0x1AF910
	// RVA: 0x1E27F00 Offset: 0x1E28001 VA: 0x1E27F00
	private void set_MonsterControllerBase(MonsterControllerBase value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF920 Offset: 0x1AFA21 VA: 0x1AF920
	// RVA: 0x1E27F10 Offset: 0x1E28011 VA: 0x1E27F10
	public EnemyBehaviorController get_EnemyBehaviorController() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF930 Offset: 0x1AFA31 VA: 0x1AF930
	// RVA: 0x1E27F20 Offset: 0x1E28021 VA: 0x1E27F20
	private void set_EnemyBehaviorController(EnemyBehaviorController value) { }

	// RVA: 0x1E27F30 Offset: 0x1E28031 VA: 0x1E27F30
	private void OnDestroy() { }

	// RVA: 0x1E282E0 Offset: 0x1E283E1 VA: 0x1E282E0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1E28420 Offset: 0x1E28521 VA: 0x1E28420 Slot: 4
	protected override void Start() { }

	// RVA: 0x1E28610 Offset: 0x1E28711 VA: 0x1E28610 Slot: 6
	public override void Spawn() { }

	// RVA: 0x1E29770 Offset: 0x1E29871 VA: 0x1E29770
	public void SetBossStageManager(BossStageManager stage) { }

	// RVA: 0x1E29870 Offset: 0x1E29971 VA: 0x1E29870
	private void OnDeadBossStage(BossStageManager stage) { }

	// RVA: 0x1E29A50 Offset: 0x1E29B51 VA: 0x1E29A50
	private void TreasureBoxSpawn(FieldTreasureBox treasureBox, Vector3 position, Quaternion rotation, Vector3 offset) { }

	// RVA: 0x1E29140 Offset: 0x1E29241 VA: 0x1E29140
	private int GetBoxType(int[] ratios) { }

	// RVA: 0x1E29C70 Offset: 0x1E29D71 VA: 0x1E29C70
	public void SetEnemyInit(MonsterControllerBase setMonsterControllerBase, EnemyBehaviorController setEnemyBehaviorController) { }

	// RVA: 0x1E29D90 Offset: 0x1E29E91 VA: 0x1E29D90
	private void OnFinishDead(MonsterControllerBase monsterControllerBase) { }

	// RVA: 0x1E29E70 Offset: 0x1E29F71 VA: 0x1E29E70
	public void RemoveBox() { }

	// RVA: 0x1E29FD0 Offset: 0x1E2A0D1 VA: 0x1E29FD0
	public void .ctor() { }

	// RVA: 0x1E2A0B0 Offset: 0x1E2A1B1 VA: 0x1E2A0B0
	private static void .cctor() { }
}

public class FieldRandomTreasureBoxSpawner : FieldTreasureBoxSpawner // TypeDefIndex: 10493
{
	// Fields
	[SerializeField] // RVA: 0x181C00 Offset: 0x181D01 VA: 0x181C00
	private FieldRandomTreasureBoxSpawnID _RandomBoxSpawnID; // 0x3C
	private FieldUniqueTreasureBoxSpawner UniqueBoxSpawner; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x181C10 Offset: 0x181D11 VA: 0x181C10
	private MonsterControllerBase <MonsterControllerBase>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x181C20 Offset: 0x181D21 VA: 0x181C20
	private EnemyBehaviorController <EnemyBehaviorController>k__BackingField; // 0x50
	private MonsterDataID SpawnMonsterDataID; // 0x58
	private bool IsSpawnMonster; // 0x5C
	private bool IsDefeatMonster; // 0x5D
	private bool isAddSpawnEvent; // 0x5E
	private static readonly FieldTreasureBoxType[] BoxPrefabType; // 0x0

	// Properties
	public FieldRandomTreasureBoxSpawnID RandomBoxSpawnID { get; set; }
	public MonsterControllerBase MonsterControllerBase { get; set; }
	public EnemyBehaviorController EnemyBehaviorController { get; set; }

	// Methods

	// RVA: 0x1E27ED0 Offset: 0x1E27FD1 VA: 0x1E27ED0
	public FieldRandomTreasureBoxSpawnID get_RandomBoxSpawnID() { }

	// RVA: 0x1E27EE0 Offset: 0x1E27FE1 VA: 0x1E27EE0
	private void set_RandomBoxSpawnID(FieldRandomTreasureBoxSpawnID value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF900 Offset: 0x1AFA01 VA: 0x1AF900
	// RVA: 0x1E27EF0 Offset: 0x1E27FF1 VA: 0x1E27EF0
	public MonsterControllerBase get_MonsterControllerBase() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF910 Offset: 0x1AFA11 VA: 0x1AF910
	// RVA: 0x1E27F00 Offset: 0x1E28001 VA: 0x1E27F00
	private void set_MonsterControllerBase(MonsterControllerBase value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF920 Offset: 0x1AFA21 VA: 0x1AF920
	// RVA: 0x1E27F10 Offset: 0x1E28011 VA: 0x1E27F10
	public EnemyBehaviorController get_EnemyBehaviorController() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF930 Offset: 0x1AFA31 VA: 0x1AF930
	// RVA: 0x1E27F20 Offset: 0x1E28021 VA: 0x1E27F20
	private void set_EnemyBehaviorController(EnemyBehaviorController value) { }

	// RVA: 0x1E27F30 Offset: 0x1E28031 VA: 0x1E27F30
	private void OnDestroy() { }

	// RVA: 0x1E282E0 Offset: 0x1E283E1 VA: 0x1E282E0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1E28420 Offset: 0x1E28521 VA: 0x1E28420 Slot: 4
	protected override void Start() { }

	// RVA: 0x1E28610 Offset: 0x1E28711 VA: 0x1E28610 Slot: 6
	public override void Spawn() { }

	// RVA: 0x1E29770 Offset: 0x1E29871 VA: 0x1E29770
	public void SetBossStageManager(BossStageManager stage) { }

	// RVA: 0x1E29870 Offset: 0x1E29971 VA: 0x1E29870
	private void OnDeadBossStage(BossStageManager stage) { }

	// RVA: 0x1E29A50 Offset: 0x1E29B51 VA: 0x1E29A50
	private void TreasureBoxSpawn(FieldTreasureBox treasureBox, Vector3 position, Quaternion rotation, Vector3 offset) { }

	// RVA: 0x1E29140 Offset: 0x1E29241 VA: 0x1E29140
	private int GetBoxType(int[] ratios) { }

	// RVA: 0x1E29C70 Offset: 0x1E29D71 VA: 0x1E29C70
	public void SetEnemyInit(MonsterControllerBase setMonsterControllerBase, EnemyBehaviorController setEnemyBehaviorController) { }

	// RVA: 0x1E29D90 Offset: 0x1E29E91 VA: 0x1E29D90
	private void OnFinishDead(MonsterControllerBase monsterControllerBase) { }

	// RVA: 0x1E29E70 Offset: 0x1E29F71 VA: 0x1E29E70
	public void RemoveBox() { }

	// RVA: 0x1E29FD0 Offset: 0x1E2A0D1 VA: 0x1E29FD0
	public void .ctor() { }

	// RVA: 0x1E2A0B0 Offset: 0x1E2A1B1 VA: 0x1E2A0B0
	private static void .cctor() { }
}

