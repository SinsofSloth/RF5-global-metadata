public class BaffamoDodgeManager : SingletonMonoBehaviour<BaffamoDodgeManager> // TypeDefIndex: 7323
{
	// Fields
	private List<BaffamoDodgeManager.BaffamoMonster> Baffamos; // 0x18
	private BaffamoFestivalDataTable baffamoFestivalDataTable; // 0x20
	public readonly float FESTIVAL_ZONE_RADIUS; // 0x28
	[SerializeField] // RVA: 0x165B80 Offset: 0x165C81 VA: 0x165B80
	private FestivalCamera baffamoCamera; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x165B90 Offset: 0x165C91 VA: 0x165B90
	private Vector3 <StartForward>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x165BA0 Offset: 0x165CA1 VA: 0x165BA0
	private ParticleSystem[] <BaffamoRushEffect>k__BackingField; // 0x48
	private BaffamoUI baffamoUI; // 0x50
	[SerializeField] // RVA: 0x165BB0 Offset: 0x165CB1 VA: 0x165BB0
	private GameObject festivalZone; // 0x58
	[SerializeField] // RVA: 0x165BC0 Offset: 0x165CC1 VA: 0x165BC0
	private GameObject[] baffamoStartPos; // 0x60
	[SerializeField] // RVA: 0x165BD0 Offset: 0x165CD1 VA: 0x165BD0
	private GameObject baffamoEndPos; // 0x68
	[SerializeField] // RVA: 0x165BE0 Offset: 0x165CE1 VA: 0x165BE0
	private GameObject playerPos; // 0x70
	[SerializeField] // RVA: 0x165BF0 Offset: 0x165CF1 VA: 0x165BF0
	private GameObject cameraStartPos; // 0x78
	[SerializeField] // RVA: 0x165C00 Offset: 0x165D01 VA: 0x165C00
	private ParticleSystem focusLine; // 0x80
	[SerializeField] // RVA: 0x165C10 Offset: 0x165D11 VA: 0x165C10
	private float ZOOM_TIME; // 0x88
	[SerializeField] // RVA: 0x165C20 Offset: 0x165D21 VA: 0x165C20
	private float zoomSpeed; // 0x8C
	private int loadCount; // 0x90
	private float currentZoomTime; // 0x94
	private bool isCameraZoom; // 0x98
	private AvoidType avoid; // 0x9C
	private BaffamoDodgeManager.State state; // 0xA0

	// Properties
	public FestivalCamera Camera { get; }
	public Vector3 StartForward { get; set; }
	public ParticleSystem[] BaffamoRushEffect { get; set; }

	// Methods

	// RVA: 0x2157A00 Offset: 0x2157B01 VA: 0x2157A00
	public FestivalCamera get_Camera() { }

	[CompilerGeneratedAttribute] // RVA: 0x19FD50 Offset: 0x19FE51 VA: 0x19FD50
	// RVA: 0x2157A10 Offset: 0x2157B11 VA: 0x2157A10
	public Vector3 get_StartForward() { }

	[CompilerGeneratedAttribute] // RVA: 0x19FD60 Offset: 0x19FE61 VA: 0x19FD60
	// RVA: 0x2157A20 Offset: 0x2157B21 VA: 0x2157A20
	private void set_StartForward(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19FD70 Offset: 0x19FE71 VA: 0x19FD70
	// RVA: 0x2157A30 Offset: 0x2157B31 VA: 0x2157A30
	public ParticleSystem[] get_BaffamoRushEffect() { }

	[CompilerGeneratedAttribute] // RVA: 0x19FD80 Offset: 0x19FE81 VA: 0x19FD80
	// RVA: 0x2157A40 Offset: 0x2157B41 VA: 0x2157A40
	private void set_BaffamoRushEffect(ParticleSystem[] value) { }

	// RVA: 0x2157A50 Offset: 0x2157B51 VA: 0x2157A50 Slot: 4
	protected override void Awake() { }

	// RVA: 0x2157AC0 Offset: 0x2157BC1 VA: 0x2157AC0
	private void Start() { }

	// RVA: 0x2157D90 Offset: 0x2157E91 VA: 0x2157D90
	private void LoadEffect(int _i) { }

	// RVA: 0x2157E90 Offset: 0x2157F91 VA: 0x2157E90
	private void CharaSetup() { }

	// RVA: 0x2158010 Offset: 0x2158111 VA: 0x2158010
	private bool IsLoading() { }

	// RVA: 0x2158140 Offset: 0x2158241 VA: 0x2158140
	private void Update() { }

	// RVA: 0x21584D0 Offset: 0x21585D1 VA: 0x21584D0
	private void InitBaffamo() { }

	// RVA: 0x2158DF0 Offset: 0x2158EF1 VA: 0x2158DF0
	private void LoadBaffamo(BaffamoDodgeManager.BaffamoMonster _baffamo) { }

	// RVA: 0x2158F30 Offset: 0x2159031 VA: 0x2158F30
	private void SummonBaffamo(BaffamoID _id, int _count) { }

	// RVA: 0x2159100 Offset: 0x2159201 VA: 0x2159100
	private void PrepareBaffamo() { }

	// RVA: 0x21589B0 Offset: 0x2158AB1 VA: 0x21589B0
	private void ResetBaffamo() { }

	[IteratorStateMachineAttribute] // RVA: 0x19FD90 Offset: 0x19FE91 VA: 0x19FD90
	// RVA: 0x2158830 Offset: 0x2158931 VA: 0x2158830
	private IEnumerator BaffamoGame() { }

	// RVA: 0x2159700 Offset: 0x2159801 VA: 0x2159700
	public void Dodge() { }

	[IteratorStateMachineAttribute] // RVA: 0x19FE00 Offset: 0x19FF01 VA: 0x19FE00
	// RVA: 0x2159BC0 Offset: 0x2159CC1 VA: 0x2159BC0
	private IEnumerator CheckNormalRolling(BaffamoDodgeManager.BaffamoMonster _baffamo) { }

	[IteratorStateMachineAttribute] // RVA: 0x19FE70 Offset: 0x19FF71 VA: 0x19FE70
	// RVA: 0x2159C90 Offset: 0x2159D91 VA: 0x2159C90
	private IEnumerator CameraZoom() { }

	// RVA: 0x21588B0 Offset: 0x21589B1 VA: 0x21588B0
	public void PlayJudgeCutin() { }

	// RVA: 0x2159F70 Offset: 0x215A071 VA: 0x2159F70
	public void HitBaffamo(Vector3 _forward) { }

	// RVA: 0x215A150 Offset: 0x215A251 VA: 0x215A150
	public float CheckZone(Vector3 _player_pos) { }

	// RVA: 0x2159D40 Offset: 0x2159E41 VA: 0x2159D40
	private void PlayRollingSE(AvoidType _type) { }

	// RVA: 0x215A220 Offset: 0x215A321 VA: 0x215A220
	public void .ctor() { }
}

