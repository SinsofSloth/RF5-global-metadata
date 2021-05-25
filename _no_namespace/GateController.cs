public class GateController : MonoBehaviour // TypeDefIndex: 8057
{
	// Fields
	private const float FadeInTime = 0.35;
	private const float FadeOutTime = 0.2;
	private static readonly float GateRevivalTime; // 0x0
	private const float GateSpawnNormalRange = 2;
	[HeaderAttribute] // RVA: 0x169FE0 Offset: 0x16A0E1 VA: 0x169FE0
	[SerializeField] // RVA: 0x169FE0 Offset: 0x16A0E1 VA: 0x169FE0
	public GateDataID GateDataID; // 0x18
	[HeaderAttribute] // RVA: 0x16A030 Offset: 0x16A131 VA: 0x16A030
	[SerializeField] // RVA: 0x16A030 Offset: 0x16A131 VA: 0x16A030
	private float ViewGateRadius; // 0x1C
	[HeaderAttribute] // RVA: 0x16A080 Offset: 0x16A181 VA: 0x16A080
	[SerializeField] // RVA: 0x16A080 Offset: 0x16A181 VA: 0x16A080
	private float BattleAreaExitRadius; // 0x20
	[HeaderAttribute] // RVA: 0x16A0D0 Offset: 0x16A1D1 VA: 0x16A0D0
	[SerializeField] // RVA: 0x16A0D0 Offset: 0x16A1D1 VA: 0x16A0D0
	private float BattleAreaEnterRadius; // 0x24
	[HeaderAttribute] // RVA: 0x16A120 Offset: 0x16A221 VA: 0x16A120
	[SerializeField] // RVA: 0x16A120 Offset: 0x16A221 VA: 0x16A120
	private int MaxSpawnNum; // 0x28
	[HeaderAttribute] // RVA: 0x16A170 Offset: 0x16A271 VA: 0x16A170
	[SerializeField] // RVA: 0x16A170 Offset: 0x16A271 VA: 0x16A170
	public EnemyPatrolPoints[] EnemyPatrolPoints; // 0x30
	[HeaderAttribute] // RVA: 0x16A1C0 Offset: 0x16A2C1 VA: 0x16A1C0
	[SerializeField] // RVA: 0x16A1C0 Offset: 0x16A2C1 VA: 0x16A1C0
	private GateMovePoint[] GateMovePoints; // 0x38
	[HeaderAttribute] // RVA: 0x16A210 Offset: 0x16A311 VA: 0x16A210
	public GateDataTable CurrentGateDataTable; // 0x40
	[HeaderAttribute] // RVA: 0x16A250 Offset: 0x16A351 VA: 0x16A250
	public GateStatusDataTable CurrentGateStatusDataTable; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x16A290 Offset: 0x16A391 VA: 0x16A290
	private Transform <_Transform>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x16A2A0 Offset: 0x16A3A1 VA: 0x16A2A0
	private GateEnemyController <GateEnemy>k__BackingField; // 0x80
	public Dictionary<MonsterControllerBase, int> SpawnedEnemyMap; // 0x88
	public OnPlayerEnterGateArea OnPlayerEnterGateArea; // 0x90
	public OnPlayerExitGateArea OnPlayerExitGateArea; // 0x98
	public OnAllEnemyDead OnAllEnemyDead; // 0xA0
	public OnGateEnemyDead OnGateEnemyDead; // 0xA8
	public Action OnDestroyCallback; // 0xB0
	private float CurrentEnemySpawnTimer; // 0xB8
	private float DeadGateEnemyTime; // 0xBC
	private Coroutine MaxSpawnCoroutine; // 0xC0
	private int DifficultyMaxSpawnNum; // 0xC8
	private static EventControllerBase EventControllerBaseInstance; // 0x8
	private static TeleportAreaManager TeleportAreaManagerInstance; // 0x10
	private bool IsInit; // 0xCC
	private GateController.BetweenPlayerState BPState; // 0xD0
	private GateController.GateEnemyState GEState; // 0xD4
	private NavMeshHit NavMeshHit; // 0xD8
	private Action<float>[] UpdateBetweenPlayerState; // 0x100
	private Action[] UpdateGateEnemyState; // 0x108
	private float OutViewGateRadius; // 0x110
	private Coroutine CreateGateCoroutine; // 0x118
	private bool IsDestroyGate; // 0x120

	// Properties
	public Transform _Transform { get; set; }
	public GateEnemyController GateEnemy { get; set; }
	public bool IsGateStop { get; }
	public bool IsGeteView { get; }
	public bool IsGateOutSide { get; }
	public bool IsGateEnemyDead { get; }
	public bool IsAllDeadEnemies { get; }
	public int GetMaxSpawnNum { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A56B0 Offset: 0x1A57B1 VA: 0x1A56B0
	// RVA: 0x1E3FD60 Offset: 0x1E3FE61 VA: 0x1E3FD60
	public Transform get__Transform() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A56C0 Offset: 0x1A57C1 VA: 0x1A56C0
	// RVA: 0x1E3FD70 Offset: 0x1E3FE71 VA: 0x1E3FD70
	private void set__Transform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A56D0 Offset: 0x1A57D1 VA: 0x1A56D0
	// RVA: 0x1E3FD80 Offset: 0x1E3FE81 VA: 0x1E3FD80
	private void set_GateEnemy(GateEnemyController value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A56E0 Offset: 0x1A57E1 VA: 0x1A56E0
	// RVA: 0x1E3FD90 Offset: 0x1E3FE91 VA: 0x1E3FD90
	public GateEnemyController get_GateEnemy() { }

	// RVA: 0x1E3FDA0 Offset: 0x1E3FEA1 VA: 0x1E3FDA0
	public bool get_IsGateStop() { }

	// RVA: 0x1E3FDB0 Offset: 0x1E3FEB1 VA: 0x1E3FDB0
	public bool get_IsGeteView() { }

	// RVA: 0x1E3FDC0 Offset: 0x1E3FEC1 VA: 0x1E3FDC0
	public bool get_IsGateOutSide() { }

	// RVA: 0x1E3FDD0 Offset: 0x1E3FED1 VA: 0x1E3FDD0
	public bool get_IsGateEnemyDead() { }

	// RVA: 0x1E3FDE0 Offset: 0x1E3FEE1 VA: 0x1E3FDE0
	public bool get_IsAllDeadEnemies() { }

	// RVA: 0x1E3FEB0 Offset: 0x1E3FFB1 VA: 0x1E3FEB0
	public int get_GetMaxSpawnNum() { }

	// RVA: 0x1E3FEC0 Offset: 0x1E3FFC1 VA: 0x1E3FEC0
	private void Awake() { }

	// RVA: 0x1E40490 Offset: 0x1E40591 VA: 0x1E40490
	private void SetGateEnemyState(GateController.GateEnemyState gateState, bool isForce = False) { }

	// RVA: 0x1E3FED0 Offset: 0x1E3FFD1 VA: 0x1E3FED0
	private void SetupUpdateState() { }

	// RVA: 0x1E404B0 Offset: 0x1E405B1 VA: 0x1E404B0
	private void UpdateOutViewGate(float sqrMagnitudeToPlayer) { }

	// RVA: 0x1E40710 Offset: 0x1E40811 VA: 0x1E40710
	private void UpdateInViewGate(float sqrMagnitudeToPlayer) { }

	// RVA: 0x1E409D0 Offset: 0x1E40AD1 VA: 0x1E409D0
	private void UpdateInside(float sqrMagnitudeToPlayer) { }

	// RVA: 0x1E40B00 Offset: 0x1E40C01 VA: 0x1E40B00
	private void UpdateOutside(float sqrMagnitudeToPlayer) { }

	// RVA: 0x1E40B60 Offset: 0x1E40C61 VA: 0x1E40B60
	private void UpdateAlive() { }

	// RVA: 0x1E40CE0 Offset: 0x1E40DE1 VA: 0x1E40CE0
	private void UpdateDead() { }

	// RVA: 0x1E40DD0 Offset: 0x1E40ED1 VA: 0x1E40DD0
	private void OnDestroy() { }

	// RVA: 0x1E40DF0 Offset: 0x1E40EF1 VA: 0x1E40DF0
	public void Initialize(GateDataTable gateDataTable, Action destroyCallback) { }

	// RVA: 0x1E404F0 Offset: 0x1E405F1 VA: 0x1E404F0
	private void CreateGateEnemy() { }

	// RVA: 0x1E410A0 Offset: 0x1E411A1 VA: 0x1E410A0
	public void MainUpdate() { }

	// RVA: 0x1E41350 Offset: 0x1E41451 VA: 0x1E41350
	public void GateStop(bool isCallBack = False) { }

	// RVA: 0x1E40DB0 Offset: 0x1E40EB1 VA: 0x1E40DB0
	public void GateRestart() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A56F0 Offset: 0x1A57F1 VA: 0x1A56F0
	// RVA: 0x1E41660 Offset: 0x1E41761 VA: 0x1E41660
	private IEnumerator WaitRestrictInMonsterPosition() { }

	// RVA: 0x1E41710 Offset: 0x1E41811 VA: 0x1E41710
	public void RestrictInMonsterPosition() { }

	// RVA: 0x1E417A0 Offset: 0x1E418A1 VA: 0x1E417A0
	private void SetGateActive(bool isActive) { }

	// RVA: 0x1E40770 Offset: 0x1E40871 VA: 0x1E40770
	private void DestroyGateEnemy(bool isCallback = False) { }

	// RVA: 0x1E408D0 Offset: 0x1E409D1 VA: 0x1E408D0
	private void PlayerEnterGateArea() { }

	// RVA: 0x1E40A90 Offset: 0x1E40B91 VA: 0x1E40A90
	private void PlayerExitGateArea() { }

	// RVA: 0x1E419B0 Offset: 0x1E41AB1 VA: 0x1E419B0
	private void DeadGateEnemy(MonsterControllerBase gateEnemy) { }

	// RVA: 0x1E41AB0 Offset: 0x1E41BB1 VA: 0x1E41AB0
	private void OnFinishDeadMonster(MonsterControllerBase monster) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A5760 Offset: 0x1A5861 VA: 0x1A5760
	// RVA: 0x1E41930 Offset: 0x1E41A31 VA: 0x1E41930
	private IEnumerator SpawnEnemyMax() { }

	// RVA: 0x1E40B70 Offset: 0x1E40C71 VA: 0x1E40B70
	private void SpawnEnemyInterval() { }

	// RVA: 0x1E413E0 Offset: 0x1E414E1 VA: 0x1E413E0
	private void DestroyEnemyAll() { }

	// RVA: 0x1E41C40 Offset: 0x1E41D41 VA: 0x1E41C40
	public void DestoryEnemy(MonsterControllerBase enemy) { }

	// RVA: 0x1E418A0 Offset: 0x1E419A1 VA: 0x1E418A0
	private void CheckAllDeadEnemy(bool isCallback = True) { }

	// RVA: 0x1E41E90 Offset: 0x1E41F91 VA: 0x1E41E90
	private int LotterySpawnIndex() { }

	// RVA: 0x1E420A0 Offset: 0x1E421A1 VA: 0x1E420A0
	public static Vector3[] PatrollPointToVector3Array(PatrolPoint[] patrolPoints) { }

	// RVA: 0x1E421B0 Offset: 0x1E422B1 VA: 0x1E421B0
	public static Vector3 GetTerritoryCenterPosition(Vector3[] patrolPoints) { }

	// RVA: 0x1E42310 Offset: 0x1E42411 VA: 0x1E42310
	public static Vector3 GetTerritoryCenterPosition(PatrolPoint[] patrolPoints) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A57D0 Offset: 0x1A58D1 VA: 0x1A57D0
	// RVA: 0x1E41020 Offset: 0x1E41121 VA: 0x1E41020
	private static IEnumerator StaticGateEnemySpawnAsync(GateController spawner) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A5840 Offset: 0x1A5941 VA: 0x1A5840
	// RVA: 0x1E41DE0 Offset: 0x1E41EE1 VA: 0x1E41DE0
	private static IEnumerator StaticSpawnEnemyAsync(GateController spawner, bool isIntervalSpawn, int spawnEnemyIndex = 0) { }

	// RVA: 0x1E424E0 Offset: 0x1E425E1 VA: 0x1E424E0
	public void .ctor() { }

	// RVA: 0x1E42620 Offset: 0x1E42721 VA: 0x1E42620
	private static void .cctor() { }
}

