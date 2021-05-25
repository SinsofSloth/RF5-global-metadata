public class SnowmanManager : SingletonMonoBehaviour<SnowmanManager> // TypeDefIndex: 7421
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x166530 Offset: 0x166631 VA: 0x166530
	private GameObject <SnowballPrefab>k__BackingField; // 0x18
	private readonly int SNOWBALL_PREFAB_ID; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x166540 Offset: 0x166641 VA: 0x166540
	private List<FestivalSnowball> <FestivalSnowballs>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x166550 Offset: 0x166651 VA: 0x166550
	private List<SnowmanManager.Mocomoco> <Mocomocos>k__BackingField; // 0x30
	[SerializeField] // RVA: 0x166560 Offset: 0x166661 VA: 0x166560
	private SnowmanCamera snowmanCamera; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x166570 Offset: 0x166671 VA: 0x166570
	private SnowmanPlayer <SnowmanPlayer>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x166580 Offset: 0x166681 VA: 0x166580
	private ParticleSystem <SpeedUpEffect>k__BackingField; // 0x48
	private const int OBJECT_MAX = 30;
	[CompilerGeneratedAttribute] // RVA: 0x166590 Offset: 0x166691 VA: 0x166590
	private SnowmanManager.CurrentObject[] <CurrentObjectList>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x1665A0 Offset: 0x1666A1 VA: 0x1665A0
	private int <CurrentObjectCount>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x1665B0 Offset: 0x1666B1 VA: 0x1665B0
	private SnowballDataTable <SnowballDataTable>k__BackingField; // 0x60
	private List<Transform> popPoints; // 0x68
	[SerializeField] // RVA: 0x1665C0 Offset: 0x1666C1 VA: 0x1665C0
	private GameObject playerPos; // 0x70
	[SerializeField] // RVA: 0x1665D0 Offset: 0x1666D1 VA: 0x1665D0
	private GameObject spawnPos; // 0x78
	private SnowballObjectSpawnDataTable snowballObjectSpawnDataTable; // 0x80
	private const float SNOWBALL_RADIUS = 0.5;
	private int loadCount; // 0x88
	[SerializeField] // RVA: 0x1665E0 Offset: 0x1666E1 VA: 0x1665E0
	private Canvas canvas; // 0x90
	private readonly int MINIMAP_PREFAB_ID; // 0x98
	private GameObject minimapObj; // 0xA0
	private FesMinimapControl minimapContl; // 0xA8
	private SnowmanManager.State state; // 0xB0

	// Properties
	public GameObject SnowballPrefab { get; set; }
	public List<FestivalSnowball> FestivalSnowballs { get; set; }
	public List<SnowmanManager.Mocomoco> Mocomocos { get; set; }
	public SnowmanCamera Camera { get; }
	public SnowmanPlayer SnowmanPlayer { get; set; }
	public ParticleSystem SpeedUpEffect { get; set; }
	public SnowmanManager.CurrentObject[] CurrentObjectList { get; set; }
	public int CurrentObjectCount { get; set; }
	public SnowballDataTable SnowballDataTable { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A0BF0 Offset: 0x1A0CF1 VA: 0x1A0BF0
	// RVA: 0x210EA10 Offset: 0x210EB11 VA: 0x210EA10
	public GameObject get_SnowballPrefab() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0C00 Offset: 0x1A0D01 VA: 0x1A0C00
	// RVA: 0x210EA20 Offset: 0x210EB21 VA: 0x210EA20
	private void set_SnowballPrefab(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0C10 Offset: 0x1A0D11 VA: 0x1A0C10
	// RVA: 0x210EA30 Offset: 0x210EB31 VA: 0x210EA30
	public List<FestivalSnowball> get_FestivalSnowballs() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0C20 Offset: 0x1A0D21 VA: 0x1A0C20
	// RVA: 0x210EA40 Offset: 0x210EB41 VA: 0x210EA40
	private void set_FestivalSnowballs(List<FestivalSnowball> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0C30 Offset: 0x1A0D31 VA: 0x1A0C30
	// RVA: 0x210EA50 Offset: 0x210EB51 VA: 0x210EA50
	public List<SnowmanManager.Mocomoco> get_Mocomocos() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0C40 Offset: 0x1A0D41 VA: 0x1A0C40
	// RVA: 0x210EA60 Offset: 0x210EB61 VA: 0x210EA60
	private void set_Mocomocos(List<SnowmanManager.Mocomoco> value) { }

	// RVA: 0x210EA70 Offset: 0x210EB71 VA: 0x210EA70
	public SnowmanCamera get_Camera() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0C50 Offset: 0x1A0D51 VA: 0x1A0C50
	// RVA: 0x210EA80 Offset: 0x210EB81 VA: 0x210EA80
	public SnowmanPlayer get_SnowmanPlayer() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0C60 Offset: 0x1A0D61 VA: 0x1A0C60
	// RVA: 0x210EA90 Offset: 0x210EB91 VA: 0x210EA90
	private void set_SnowmanPlayer(SnowmanPlayer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0C70 Offset: 0x1A0D71 VA: 0x1A0C70
	// RVA: 0x210EAA0 Offset: 0x210EBA1 VA: 0x210EAA0
	public ParticleSystem get_SpeedUpEffect() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0C80 Offset: 0x1A0D81 VA: 0x1A0C80
	// RVA: 0x210EAB0 Offset: 0x210EBB1 VA: 0x210EAB0
	private void set_SpeedUpEffect(ParticleSystem value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0C90 Offset: 0x1A0D91 VA: 0x1A0C90
	// RVA: 0x210EAC0 Offset: 0x210EBC1 VA: 0x210EAC0
	public SnowmanManager.CurrentObject[] get_CurrentObjectList() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0CA0 Offset: 0x1A0DA1 VA: 0x1A0CA0
	// RVA: 0x210EAD0 Offset: 0x210EBD1 VA: 0x210EAD0
	private void set_CurrentObjectList(SnowmanManager.CurrentObject[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0CB0 Offset: 0x1A0DB1 VA: 0x1A0CB0
	// RVA: 0x210EAE0 Offset: 0x210EBE1 VA: 0x210EAE0
	public int get_CurrentObjectCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0CC0 Offset: 0x1A0DC1 VA: 0x1A0CC0
	// RVA: 0x210EAF0 Offset: 0x210EBF1 VA: 0x210EAF0
	private void set_CurrentObjectCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0CD0 Offset: 0x1A0DD1 VA: 0x1A0CD0
	// RVA: 0x210EB00 Offset: 0x210EC01 VA: 0x210EB00
	public SnowballDataTable get_SnowballDataTable() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0CE0 Offset: 0x1A0DE1 VA: 0x1A0CE0
	// RVA: 0x210EB10 Offset: 0x210EC11 VA: 0x210EB10
	private void set_SnowballDataTable(SnowballDataTable value) { }

	// RVA: 0x210EB20 Offset: 0x210EC21 VA: 0x210EB20 Slot: 4
	protected override void Awake() { }

	// RVA: 0x210EB90 Offset: 0x210EC91 VA: 0x210EB90
	private void Start() { }

	// RVA: 0x210F250 Offset: 0x210F351 VA: 0x210F250
	private void OnDestroy() { }

	// RVA: 0x210F2D0 Offset: 0x210F3D1 VA: 0x210F2D0
	private void InitMocomoco() { }

	// RVA: 0x210F630 Offset: 0x210F731 VA: 0x210F630
	private void CharaSetup() { }

	// RVA: 0x210F760 Offset: 0x210F861 VA: 0x210F760
	private bool IsLoading() { }

	// RVA: 0x210F890 Offset: 0x210F991 VA: 0x210F890
	private void Update() { }

	// RVA: 0x210F500 Offset: 0x210F601 VA: 0x210F500
	private void LoadMocomoco(SnowmanManager.Mocomoco _mocomoco) { }

	// RVA: 0x210FE10 Offset: 0x210FF11 VA: 0x210FE10
	private GameObject SummonMocomoco(SnowmanObjectID _id, Vector3 _pos) { }

	// RVA: 0x2110210 Offset: 0x2110311 VA: 0x2110210
	private void ResetMocomoco() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A0CF0 Offset: 0x1A0DF1 VA: 0x1A0CF0
	// RVA: 0x210FD80 Offset: 0x210FE81 VA: 0x210FD80
	private IEnumerator SnowmanGame() { }

	// RVA: 0x2110670 Offset: 0x2110771 VA: 0x2110670
	private SnowmanObjectType GetSnowmanObjectType(SnowmanObjectID _id) { }

	// RVA: 0x21106B0 Offset: 0x21107B1 VA: 0x21106B0
	private void ResetInvincible() { }

	// RVA: 0x2110700 Offset: 0x2110801 VA: 0x2110700
	public void MinimapSwitcher() { }

	// RVA: 0x2110720 Offset: 0x2110821 VA: 0x2110720
	public void SetNormalScale() { }

	// RVA: 0x2110740 Offset: 0x2110841 VA: 0x2110740
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0D60 Offset: 0x1A0E61 VA: 0x1A0D60
	// RVA: 0x21108A0 Offset: 0x21109A1 VA: 0x21108A0
	private bool <Start>b__52_0(Transform obj) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0D70 Offset: 0x1A0E71 VA: 0x1A0D70
	// RVA: 0x21108F0 Offset: 0x21109F1 VA: 0x21108F0
	private void <Start>b__52_1(ParticleSystem _effect) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0D80 Offset: 0x1A0E81 VA: 0x1A0D80
	// RVA: 0x21109F0 Offset: 0x2110AF1 VA: 0x21109F0
	private void <Start>b__52_2(AssetHandle<GameObject> handle) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0D90 Offset: 0x1A0E91 VA: 0x1A0D90
	// RVA: 0x2110A70 Offset: 0x2110B71 VA: 0x2110A70
	private void <Start>b__52_3(AssetHandle<GameObject> handle) { }
}

