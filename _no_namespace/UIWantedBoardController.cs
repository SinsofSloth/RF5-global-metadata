public class UIWantedBoardController : CursorLinkConnector // TypeDefIndex: 8773
{
	// Fields
	[SerializeField] // RVA: 0x173500 Offset: 0x173601 VA: 0x173500
	private UIWantedBlock BlockLeft2; // 0x58
	[SerializeField] // RVA: 0x173510 Offset: 0x173611 VA: 0x173510
	private UIWantedBlock BlockLeft1; // 0x60
	[SerializeField] // RVA: 0x173520 Offset: 0x173621 VA: 0x173520
	private UIWantedBlock BlockCenter; // 0x68
	[SerializeField] // RVA: 0x173530 Offset: 0x173631 VA: 0x173530
	private UIWantedBlock BlockRight1; // 0x70
	[SerializeField] // RVA: 0x173540 Offset: 0x173641 VA: 0x173540
	private UIWantedBlock BlockRight2; // 0x78
	[SerializeField] // RVA: 0x173550 Offset: 0x173651 VA: 0x173550
	private Animator MainAnimator; // 0x80
	[SerializeField] // RVA: 0x173560 Offset: 0x173661 VA: 0x173560
	private GameObject ConfirmOK; // 0x88
	[SerializeField] // RVA: 0x173570 Offset: 0x173671 VA: 0x173570
	private GameObject ConfirmNG; // 0x90
	[SerializeField] // RVA: 0x173580 Offset: 0x173681 VA: 0x173580
	private Text CompleteGroupText; // 0x98
	[SerializeField] // RVA: 0x173590 Offset: 0x173691 VA: 0x173590
	private Text CompleteNumText; // 0xA0
	[SerializeField] // RVA: 0x1735A0 Offset: 0x1736A1 VA: 0x1735A0
	private Text AcceptMonsterNameText; // 0xA8
	[SerializeField] // RVA: 0x1735B0 Offset: 0x1736B1 VA: 0x1735B0
	private Text AcceptDetailText; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x1735C0 Offset: 0x1736C1 VA: 0x1735C0
	private List<WantedData> <WantedDatas>k__BackingField; // 0xB8
	private int focusNo; // 0xC0
	private bool focusConfirmOK; // 0xC4
	private static UnityEvent callback; // 0x0
	private AssetHandle<SpriteAtlas> handle; // 0xC8
	private SpriteAtlas spriteAtlas; // 0xD0
	private const int SpriteAtlasId = 19765;
	private UIWantedBoardController.State state; // 0xD8

	// Properties
	public List<WantedData> WantedDatas { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A8550 Offset: 0x1A8651 VA: 0x1A8550
	// RVA: 0x1FF8530 Offset: 0x1FF8631 VA: 0x1FF8530
	public List<WantedData> get_WantedDatas() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8560 Offset: 0x1A8661 VA: 0x1A8560
	// RVA: 0x1FF8540 Offset: 0x1FF8641 VA: 0x1FF8540
	private void set_WantedDatas(List<WantedData> value) { }

	// RVA: 0x1FF8550 Offset: 0x1FF8651 VA: 0x1FF8550
	private void Start() { }

	// RVA: 0x1FF8B20 Offset: 0x1FF8C21 VA: 0x1FF8B20
	private void LoadAtlas(AssetHandle<SpriteAtlas> _handle) { }

	// RVA: 0x1FF86D0 Offset: 0x1FF87D1 VA: 0x1FF86D0
	private void SetBlocks() { }

	// RVA: 0x1FF8BB0 Offset: 0x1FF8CB1 VA: 0x1FF8BB0
	private void Update() { }

	// RVA: 0x1FF9580 Offset: 0x1FF9681 VA: 0x1FF9580
	public static void Call(UnityEvent _callback) { }

	// RVA: 0x1FF9610 Offset: 0x1FF9711 VA: 0x1FF9610
	private void OnDestroy() { }

	// RVA: 0x1FF9690 Offset: 0x1FF9791 VA: 0x1FF9690
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8570 Offset: 0x1A8671 VA: 0x1A8570
	// RVA: 0x1FF96A0 Offset: 0x1FF97A1 VA: 0x1FF96A0
	private void <Update>b__27_0(bool select) { }
}

