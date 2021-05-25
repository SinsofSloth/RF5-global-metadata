public class PlayerTeleportButton : MonoBehaviour, InteractionInterface, FocusInterface // TypeDefIndex: 7496
{
	// Fields
	[SerializeField] // RVA: 0x166AC0 Offset: 0x166BC1 VA: 0x166AC0
	protected FieldTeleportID FieldTeleportID; // 0x18
	protected FieldTeleportDataTable Data; // 0x20
	[SerializeField] // RVA: 0x166AD0 Offset: 0x166BD1 VA: 0x166AD0
	protected string FoucsNameTextID; // 0x28
	[SerializeField] // RVA: 0x166AE0 Offset: 0x166BE1 VA: 0x166AE0
	protected string _FocusName; // 0x30
	protected string _FocusFlagOnName; // 0x38
	[SerializeField] // RVA: 0x166AF0 Offset: 0x166BF1 VA: 0x166AF0
	protected GameFlagData GameFlagData; // 0x40
	[SerializeField] // RVA: 0x166B00 Offset: 0x166C01 VA: 0x166B00
	protected string GameFlagDataString; // 0x48
	[SerializeField] // RVA: 0x166B10 Offset: 0x166C11 VA: 0x166B10
	protected string _LoadSceneIdString; // 0x50
	[SerializeField] // RVA: 0x166B20 Offset: 0x166C21 VA: 0x166B20
	protected FieldSceneId _LoadSceneId; // 0x58
	[SerializeField] // RVA: 0x166B30 Offset: 0x166C31 VA: 0x166B30
	protected string _LoadSceneName; // 0x60
	[SerializeField] // RVA: 0x166B40 Offset: 0x166C41 VA: 0x166B40
	protected string _PlayerTeleportName; // 0x68
	[SerializeField] // RVA: 0x166B50 Offset: 0x166C51 VA: 0x166B50
	private bool _IsCollisionTeleport; // 0x70
	[SerializeField] // RVA: 0x166B60 Offset: 0x166C61 VA: 0x166B60
	private bool _FallenTeleport; // 0x71
	public float FallenTeleportHeight; // 0x74
	[SerializeField] // RVA: 0x166B70 Offset: 0x166C71 VA: 0x166B70
	protected SoundID SeId; // 0x78
	private static Dictionary<int, Func<string>> IntaractionNameReplaceDictionary; // 0x0
	[SerializeField] // RVA: 0x166B80 Offset: 0x166C81 VA: 0x166B80
	private List<NPCID> _NpcIds; // 0x80
	[SerializeField] // RVA: 0x166B90 Offset: 0x166C91 VA: 0x166B90
	private int _OpenTime; // 0x88
	[SerializeField] // RVA: 0x166BA0 Offset: 0x166CA1 VA: 0x166BA0
	private int _CloseTime; // 0x8C
	private Collider _collider; // 0x90
	private bool _isClosed; // 0x98

	// Properties
	public string FocusName { get; set; }
	public bool Focusable { get; }
	public FieldSceneId FieldSceneId { get; set; }
	public string LoadSceneName { get; set; }
	public string PlayerTeleportName { get; set; }
	public bool IsCollisionTeleport { get; set; }
	public bool FallenTeleport { get; set; }
	public FocusObjectType FocusObjectType { get; }
	public int FocusPriority { get; }
	public FocusPointType FocusPointType { get; }

	// Methods

	// RVA: 0x2205FD0 Offset: 0x22060D1 VA: 0x2205FD0
	public string get_FocusName() { }

	// RVA: 0x22061B0 Offset: 0x22062B1 VA: 0x22061B0
	private void set_FocusName(string value) { }

	// RVA: 0x22061C0 Offset: 0x22062C1 VA: 0x22061C0 Slot: 10
	public bool get_Focusable() { }

	// RVA: 0x22061F0 Offset: 0x22062F1 VA: 0x22061F0 Slot: 9
	public string GetFocusName() { }

	// RVA: 0x2206200 Offset: 0x2206301 VA: 0x2206200
	public FieldSceneId get_FieldSceneId() { }

	// RVA: 0x2206210 Offset: 0x2206311 VA: 0x2206210
	public void set_FieldSceneId(FieldSceneId value) { }

	// RVA: 0x2206220 Offset: 0x2206321 VA: 0x2206220
	public string get_LoadSceneName() { }

	// RVA: 0x2206230 Offset: 0x2206331 VA: 0x2206230
	public void set_LoadSceneName(string value) { }

	// RVA: 0x2206240 Offset: 0x2206341 VA: 0x2206240
	public string get_PlayerTeleportName() { }

	// RVA: 0x2206250 Offset: 0x2206351 VA: 0x2206250
	public void set_PlayerTeleportName(string value) { }

	// RVA: 0x2206260 Offset: 0x2206361 VA: 0x2206260 Slot: 11
	public void OnFocus() { }

	// RVA: 0x2206270 Offset: 0x2206371 VA: 0x2206270 Slot: 12
	public void OffFocus() { }

	// RVA: 0x2206280 Offset: 0x2206381 VA: 0x2206280 Slot: 16
	public ushort GetInteractionType() { }

	// RVA: 0x2206340 Offset: 0x2206441 VA: 0x2206340 Slot: 19
	public virtual void DoInteraction(HumanController character) { }

	// RVA: 0x2206310 Offset: 0x2206411 VA: 0x2206310 Slot: 5
	public bool CanInteraction(HumanController character) { }

	// RVA: 0x22066D0 Offset: 0x22067D1 VA: 0x22066D0 Slot: 6
	public void DoInteraction(MonsterControllerBase character) { }

	// RVA: 0x22066E0 Offset: 0x22067E1 VA: 0x22066E0 Slot: 7
	public bool CanInteraction(MonsterControllerBase character) { }

	// RVA: 0x22066F0 Offset: 0x22067F1 VA: 0x22066F0 Slot: 8
	public string GetInteractionButtonHint() { }

	// RVA: 0x2206740 Offset: 0x2206841 VA: 0x2206740
	public bool get_IsCollisionTeleport() { }

	// RVA: 0x2206750 Offset: 0x2206851 VA: 0x2206750
	public void set_IsCollisionTeleport(bool value) { }

	// RVA: 0x2206760 Offset: 0x2206861 VA: 0x2206760
	public bool get_FallenTeleport() { }

	// RVA: 0x2206770 Offset: 0x2206871 VA: 0x2206770
	public void set_FallenTeleport(bool value) { }

	// RVA: 0x2206780 Offset: 0x2206881 VA: 0x2206780 Slot: 13
	public FocusObjectType get_FocusObjectType() { }

	// RVA: 0x2206790 Offset: 0x2206891 VA: 0x2206790 Slot: 14
	public int get_FocusPriority() { }

	// RVA: 0x22067A0 Offset: 0x22068A1 VA: 0x22067A0 Slot: 15
	public FocusPointType get_FocusPointType() { }

	// RVA: 0x22067B0 Offset: 0x22068B1 VA: 0x22067B0
	private static bool CheckInitDictionary() { }

	// RVA: 0x2206860 Offset: 0x2206961 VA: 0x2206860
	private static bool InitDictionary() { }

	// RVA: 0x22060C0 Offset: 0x22061C1 VA: 0x22060C0
	private static string GetReplaceName(int replaceNameId, string name) { }

	// RVA: 0x2207630 Offset: 0x2207731 VA: 0x2207630 Slot: 20
	protected virtual void OnTriggerEnter(Collider collision) { }

	// RVA: 0x22077E0 Offset: 0x22078E1 VA: 0x22077E0 Slot: 21
	protected virtual void Awake() { }

	// RVA: 0x22078F0 Offset: 0x22079F1 VA: 0x22078F0 Slot: 22
	protected virtual void Start() { }

	// RVA: 0x2207C20 Offset: 0x2207D21 VA: 0x2207C20
	private void Update() { }

	// RVA: 0x2207D50 Offset: 0x2207E51 VA: 0x2207D50 Slot: 23
	protected virtual void TeleportScene() { }

	// RVA: 0x2207F50 Offset: 0x2208051 VA: 0x2207F50
	private string GetTeleportSceneName() { }

	// RVA: 0x2206390 Offset: 0x2206491 VA: 0x2206390
	private bool CheckClosedHouse() { }

	// RVA: 0x2207FC0 Offset: 0x22080C1 VA: 0x2207FC0
	private bool CheckClosedHouseResult(bool result) { }

	// RVA: 0x2208020 Offset: 0x2208121 VA: 0x2208020
	private bool CheckCloseHouseByNpcs() { }

	// RVA: 0x2206600 Offset: 0x2206701 VA: 0x2206600
	private bool CheckCloseRideIndoor() { }

	// RVA: 0x22081A0 Offset: 0x22082A1 VA: 0x22081A0
	public void .ctor() { }

	// RVA: 0x2208230 Offset: 0x2208331 VA: 0x2208230
	private static void .cctor() { }

	// RVA: 0x2208240 Offset: 0x2208341 VA: 0x2208240 Slot: 17
	private GameObject FocusInterface.get_gameObject() { }

	// RVA: 0x2208250 Offset: 0x2208351 VA: 0x2208250 Slot: 18
	private Transform FocusInterface.get_transform() { }
}

