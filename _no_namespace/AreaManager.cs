[Serializable]
public class AreaManager : SingletonMonoBehaviour<AreaManager> // TypeDefIndex: 8236
{
	// Fields
	public static readonly Dictionary<string, FieldPlaceId> SceneNameToFieldPlaceId; // 0x0
	public static readonly Dictionary<Place, FieldPlaceId> PlaceToFieldPlaceId; // 0x8
	public static readonly Dictionary<FieldPlaceId, Place> FieldPlaceIdToPlace; // 0x10
	[SerializeField] // RVA: 0x16DBE0 Offset: 0x16DCE1 VA: 0x16DBE0
	public PatrolPointDataTable patrolPointDataTable; // 0x18
	[SerializeField] // RVA: 0x16DBF0 Offset: 0x16DCF1 VA: 0x16DBF0
	private Area[] Areas; // 0x20
	public bool Standby; // 0x28
	private const string PatrolPointDataTableExportPath = "Assets/Scripts/ShopArea/Table/";

	// Methods

	// RVA: 0x2283300 Offset: 0x2283401 VA: 0x2283300 Slot: 4
	protected override void Awake() { }

	// RVA: 0x2283350 Offset: 0x2283451 VA: 0x2283350
	public void SetAreas(GameObject areas) { }

	// RVA: 0x22834E0 Offset: 0x22835E1 VA: 0x22834E0
	public Area GetArea(Place place) { }

	// RVA: 0x22837A0 Offset: 0x22838A1 VA: 0x22837A0
	public int GetCapacity(Place place) { }

	// RVA: 0x22837E0 Offset: 0x22838E1 VA: 0x22837E0
	public bool IsAvailable(Place place) { }

	// RVA: 0x2283810 Offset: 0x2283911 VA: 0x2283810
	public NpcPatrolPoint GetJobPatrolPoint(int NpcId, Place place) { }

	// RVA: 0x22838F0 Offset: 0x22839F1 VA: 0x22838F0
	public NpcPatrolPoint GetWaitJobPatrolPoint(int NpcId, Place place) { }

	// RVA: 0x2283940 Offset: 0x2283A41 VA: 0x2283940
	public NpcPatrolPoint GetSeatPatrolPoint(int NpcId, Place place) { }

	// RVA: 0x2283990 Offset: 0x2283A91 VA: 0x2283990
	public NpcPatrolPoint GetEatPatrolPoint(int NpcId, Place place) { }

	// RVA: 0x22839E0 Offset: 0x2283AE1 VA: 0x22839E0
	public NpcPatrolPoint GetWaitSeatPatrolPoint(int NpcId, Place place) { }

	// RVA: 0x2283A30 Offset: 0x2283B31 VA: 0x2283A30
	public NpcPatrolPoint GetBedPatrolPoint(int NpcId, Place place) { }

	// RVA: 0x2283A80 Offset: 0x2283B81 VA: 0x2283A80
	public NpcPatrolPoint GetBathPatrolPoint(Gender gender) { }

	// RVA: 0x2283AB0 Offset: 0x2283BB1 VA: 0x2283AB0
	public NpcPatrolPoint GetRelayPatrolPoint(NpcData npcData) { }

	// RVA: 0x2283AE0 Offset: 0x2283BE1 VA: 0x2283AE0
	public NpcPatrolPoint GetDoorPoint(Place place) { }

	// RVA: 0x2283B20 Offset: 0x2283C21 VA: 0x2283B20
	public NpcPatrolPoint ReadRotatePatrolPointEnd(Place place, int RotatePatternNumber) { }

	// RVA: 0x2283B70 Offset: 0x2283C71 VA: 0x2283B70
	public NpcPatrolPoint GetRotatePatrolPointEnd(Place place, int RotatePatternNumber, int NpcId) { }

	// RVA: 0x2283BC0 Offset: 0x2283CC1 VA: 0x2283BC0
	public void FreeAllAreaPoints() { }

	// RVA: 0x2283C20 Offset: 0x2283D21 VA: 0x2283C20
	public Place GetPlace(FieldPlaceId FieldPlaceId) { }

	// RVA: 0x2283D00 Offset: 0x2283E01 VA: 0x2283D00
	public FieldPlaceId ConvertSceneNameToFieldPlaceId(string sceneName) { }

	// RVA: 0x2283DE0 Offset: 0x2283EE1 VA: 0x2283DE0
	public FieldPlaceId GetAreaPlaceId(Place place) { }

	// RVA: 0x2283EC0 Offset: 0x2283FC1 VA: 0x2283EC0
	public string[] GetRoutePatrolPoint(int fromIndex, int toIndex) { }

	// RVA: 0x2284120 Offset: 0x2284221 VA: 0x2284120
	public bool IsInDoor(Place place) { }

	// RVA: 0x2283750 Offset: 0x2283851 VA: 0x2283750
	public Place ConvertPlaceId(Place _place) { }

	// RVA: 0x2284140 Offset: 0x2284241 VA: 0x2284140
	public Place ConvertIdPlace(int place) { }

	// RVA: 0x2284180 Offset: 0x2284281 VA: 0x2284180
	public void .ctor() { }

	// RVA: 0x22841D0 Offset: 0x22842D1 VA: 0x22841D0
	private static void .cctor() { }
}

