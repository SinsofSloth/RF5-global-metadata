public class BeanSowingManager : SingletonMonoBehaviour<BeanSowingManager> // TypeDefIndex: 7349
{
	// Fields
	private readonly int[] BEAN_PREFAB_ID; // 0x18
	private readonly int UI_SCORE_ID; // 0x20
	[SerializeField] // RVA: 0x165E00 Offset: 0x165F01 VA: 0x165E00
	private BeanSowingCamera beanSowingCamera; // 0x28
	[SerializeField] // RVA: 0x165E10 Offset: 0x165F11 VA: 0x165E10
	private ObjectPooler objectPooler; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x165E20 Offset: 0x165F21 VA: 0x165E20
	private Vector3 <StartForward>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x165E30 Offset: 0x165F31 VA: 0x165E30
	private BeanSowingDataTable <BeanSowingDataTable>k__BackingField; // 0x48
	private BeanSowingActionDataTable beanSowingActionDataTable; // 0x50
	[SerializeField] // RVA: 0x165E40 Offset: 0x165F41 VA: 0x165E40
	private GameObject playerPos; // 0x58
	[SerializeField] // RVA: 0x165E50 Offset: 0x165F51 VA: 0x165E50
	private BeanSowingNPC[] npc; // 0x60
	private List<ActorID> actorID; // 0x68
	private BeanSowingManager.State state; // 0x70

	// Properties
	public BeanSowingCamera Camera { get; }
	public ObjectPooler ObjectPooler { get; }
	public Vector3 StartForward { get; set; }
	public BeanSowingDataTable BeanSowingDataTable { get; set; }

	// Methods

	// RVA: 0x20D6760 Offset: 0x20D6861 VA: 0x20D6760
	public BeanSowingCamera get_Camera() { }

	// RVA: 0x20D6770 Offset: 0x20D6871 VA: 0x20D6770
	public ObjectPooler get_ObjectPooler() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0190 Offset: 0x1A0291 VA: 0x1A0190
	// RVA: 0x20D6780 Offset: 0x20D6881 VA: 0x20D6780
	public Vector3 get_StartForward() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A01A0 Offset: 0x1A02A1 VA: 0x1A01A0
	// RVA: 0x20D6790 Offset: 0x20D6891 VA: 0x20D6790
	private void set_StartForward(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A01B0 Offset: 0x1A02B1 VA: 0x1A01B0
	// RVA: 0x20D67A0 Offset: 0x20D68A1 VA: 0x20D67A0
	public BeanSowingDataTable get_BeanSowingDataTable() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A01C0 Offset: 0x1A02C1 VA: 0x1A01C0
	// RVA: 0x20D67B0 Offset: 0x20D68B1 VA: 0x20D67B0
	private void set_BeanSowingDataTable(BeanSowingDataTable value) { }

	// RVA: 0x20D67C0 Offset: 0x20D68C1 VA: 0x20D67C0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x20D6830 Offset: 0x20D6931 VA: 0x20D6830
	private void Start() { }

	// RVA: 0x20D6B40 Offset: 0x20D6C41 VA: 0x20D6B40
	private void OnLoadingBean(int i) { }

	// RVA: 0x20D6C70 Offset: 0x20D6D71 VA: 0x20D6C70
	private void OnDestroy() { }

	// RVA: 0x20D6D70 Offset: 0x20D6E71 VA: 0x20D6D70
	private void CharaSetup() { }

	// RVA: 0x20D70D0 Offset: 0x20D71D1 VA: 0x20D70D0
	private bool IsLoading() { }

	// RVA: 0x20D72E0 Offset: 0x20D73E1 VA: 0x20D72E0
	private void Update() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A01D0 Offset: 0x1A02D1 VA: 0x1A01D0
	// RVA: 0x20D77A0 Offset: 0x20D78A1 VA: 0x20D77A0
	private IEnumerator BeanSowingGame() { }

	// RVA: 0x20D7850 Offset: 0x20D7951 VA: 0x20D7850
	public void ResetNpc() { }

	// RVA: 0x20D7A20 Offset: 0x20D7B21 VA: 0x20D7A20
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0240 Offset: 0x1A0341 VA: 0x1A0240
	// RVA: 0x20D7B60 Offset: 0x20D7C61 VA: 0x20D7B60
	private void <Start>b__23_0(AssetHandle<GameObject> handle) { }
}

