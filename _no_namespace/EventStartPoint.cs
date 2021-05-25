public class EventStartPoint : MonoBehaviour // TypeDefIndex: 7178
{
	// Fields
	private static readonly Vector3 PosInaciveEventStartPoint; // 0x0
	private int EventId; // 0x18
	private string nameCache; // 0x20
	[SerializeField] // RVA: 0x1645B0 Offset: 0x1646B1 VA: 0x1645B0
	public EventPointID EventPointId; // 0x28
	[SerializeField] // RVA: 0x1645C0 Offset: 0x1646C1 VA: 0x1645C0
	public EventCheckType eventCheckType; // 0x2C
	private bool IsCleard; // 0x30
	private int EventCallCount; // 0x34
	[SerializeField] // RVA: 0x1645D0 Offset: 0x1646D1 VA: 0x1645D0
	public int EventStartTime; // 0x38
	[SerializeField] // RVA: 0x1645E0 Offset: 0x1646E1 VA: 0x1645E0
	public int EventEndTime; // 0x3C
	[SerializeField] // RVA: 0x1645F0 Offset: 0x1646F1 VA: 0x1645F0
	public bool BossStartArea; // 0x40
	[SerializeField] // RVA: 0x164600 Offset: 0x164701 VA: 0x164600
	public string ScriptName; // 0x48
	[SerializeField] // RVA: 0x164610 Offset: 0x164711 VA: 0x164610
	public EventScriptID ScriptId; // 0x50
	[SerializeField] // RVA: 0x164620 Offset: 0x164721 VA: 0x164620
	public string EnableSceneName; // 0x58
	[SerializeField] // RVA: 0x164630 Offset: 0x164731 VA: 0x164630
	public GameFlagData On1; // 0x60
	[SerializeField] // RVA: 0x164640 Offset: 0x164741 VA: 0x164640
	public GameFlagData Off1; // 0x64
	private bool ignoreGamePauseOnce; // 0x68
	public bool isBossPointActive; // 0x69

	// Properties
	public string NameCache { get; }
	public bool IgnoreGamePauseOnce { set; }

	// Methods

	// RVA: 0x20776D0 Offset: 0x20777D1 VA: 0x20776D0
	public string get_NameCache() { }

	// RVA: 0x2077730 Offset: 0x2077831 VA: 0x2077730
	public void set_IgnoreGamePauseOnce(bool value) { }

	// RVA: 0x2077740 Offset: 0x2077841 VA: 0x2077740
	private void Start() { }

	// RVA: 0x2077780 Offset: 0x2077881 VA: 0x2077780
	public void InitNameCache() { }

	// RVA: 0x20777C0 Offset: 0x20778C1 VA: 0x20777C0
	private void OnDrawGizmos() { }

	// RVA: 0x2077980 Offset: 0x2077A81 VA: 0x2077980
	private void OnCollisionEnter(Collision collision) { }

	// RVA: 0x2077C10 Offset: 0x2077D11 VA: 0x2077C10
	public void Disable() { }

	// RVA: 0x2077CE0 Offset: 0x2077DE1 VA: 0x2077CE0
	public bool Enable(EventPointData eventPointData, EventUnlockFlagData unlockData) { }

	// RVA: 0x2077FA0 Offset: 0x20780A1 VA: 0x2077FA0
	public void SetEventPointPlace(EventPointData eventPointData) { }

	// RVA: 0x2077ED0 Offset: 0x2077FD1 VA: 0x2077ED0
	private bool CheckEventPointScriptPriority(EventUnlockFlagData eventPoint) { }

	// RVA: 0x2078150 Offset: 0x2078251 VA: 0x2078150
	public bool CheckEventPointPriority(string prevScriptName, string newScriptName) { }

	// RVA: 0x2078260 Offset: 0x2078361 VA: 0x2078260
	private void OnTriggerEnter(Collider collision) { }

	// RVA: 0x2078880 Offset: 0x2078981 VA: 0x2078880
	public void OnTrigger() { }

	// RVA: 0x2078410 Offset: 0x2078511 VA: 0x2078410
	private bool IsLakeItemScript(Collider collision) { }

	// RVA: 0x2077AC0 Offset: 0x2077BC1 VA: 0x2077AC0
	private bool CheckPlayScript(bool checkPlayer = True) { }

	// RVA: 0x2078B40 Offset: 0x2078C41 VA: 0x2078B40
	private bool CheckPlayFlag(bool checkPlayer = True) { }

	// RVA: 0x2078710 Offset: 0x2078811 VA: 0x2078710
	public bool CheckEventStartPointPlay(Character player, bool checkPlayer = True) { }

	// RVA: 0x2078CF0 Offset: 0x2078DF1 VA: 0x2078CF0
	public void SetBossPointActive(bool isActive) { }

	// RVA: 0x2078D30 Offset: 0x2078E31 VA: 0x2078D30
	public void .ctor() { }

	// RVA: 0x2078DB0 Offset: 0x2078EB1 VA: 0x2078DB0
	private static void .cctor() { }
}

