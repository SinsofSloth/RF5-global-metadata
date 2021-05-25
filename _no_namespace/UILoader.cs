public class UILoader : UIMenuCanvasBase // TypeDefIndex: 8760
{
	// Fields
	private static UILoader Instance; // 0x0
	[SerializeField] // RVA: 0x1733A0 Offset: 0x1734A1 VA: 0x1733A0
	private UILoaderFade FadeOpenObj; // 0x40
	[SerializeField] // RVA: 0x1733B0 Offset: 0x1734B1 VA: 0x1733B0
	private UILoaderFade FadeEndObj; // 0x48
	[SerializeField] // RVA: 0x1733C0 Offset: 0x1734C1 VA: 0x1733C0
	private GameObject LoadingObject; // 0x50
	[SerializeField] // RVA: 0x1733D0 Offset: 0x1734D1 VA: 0x1733D0
	private GameObject HeadObject; // 0x58
	private static UnityAction CloseCallBack; // 0x8
	private static bool IsAutoPause; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x1733E0 Offset: 0x1734E1 VA: 0x1733E0
	private static bool <IsBlockHUD>k__BackingField; // 0x11
	private UIObjectLoadingCheck UIObjectLoadingCheck; // 0x60
	private bool _isLoadFinished; // 0x68
	private int nowObjectNum; // 0x6C
	private readonly int[] ObjectIdList; // 0x70
	private readonly SoundID[] OpenSound; // 0x78
	private readonly SoundID[] CloseSound; // 0x80
	private readonly bool[] CursorUseFlag; // 0x88
	private readonly bool[] UseFadeOpen; // 0x90
	private readonly bool[] UseFadeEnd; // 0x98
	private readonly bool[] KillMainCamera; // 0xA0
	private readonly bool[] BlockCursorEndCanvas; // 0xA8

	// Properties
	public static bool IsBlockHUD { get; set; }
	public bool isLoadFinished { get; set; }
	public static bool IsLoadFinished { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A84F0 Offset: 0x1A85F1 VA: 0x1A84F0
	// RVA: 0x1ED76D0 Offset: 0x1ED77D1 VA: 0x1ED76D0
	public static bool get_IsBlockHUD() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8500 Offset: 0x1A8601 VA: 0x1A8500
	// RVA: 0x1ED7740 Offset: 0x1ED7841 VA: 0x1ED7740
	public static void set_IsBlockHUD(bool value) { }

	// RVA: 0x1ED77B0 Offset: 0x1ED78B1 VA: 0x1ED77B0
	public bool get_isLoadFinished() { }

	// RVA: 0x1ED7860 Offset: 0x1ED7961 VA: 0x1ED7860
	private void set_isLoadFinished(bool value) { }

	// RVA: 0x1ED7870 Offset: 0x1ED7971 VA: 0x1ED7870 Slot: 4
	protected override void Start() { }

	// RVA: 0x1ED79A0 Offset: 0x1ED7AA1 VA: 0x1ED79A0
	public void DoOpenCanvas() { }

	// RVA: 0x1ED7B50 Offset: 0x1ED7C51 VA: 0x1ED7B50
	private static bool Call(int objectNo) { }

	// RVA: 0x1ED7F70 Offset: 0x1ED8071 VA: 0x1ED7F70
	public static bool Call(UILoader.ObjectNumber objectNo, UnityAction callback, bool isAutoPause = True) { }

	// RVA: 0x1ED8010 Offset: 0x1ED8111 VA: 0x1ED8010
	public static void SetCloseCallback(UnityAction callback) { }

	// RVA: 0x1ED8080 Offset: 0x1ED8181 VA: 0x1ED8080
	public static void Close() { }

	// RVA: 0x1ED7E30 Offset: 0x1ED7F31 VA: 0x1ED7E30
	public static bool get_IsLoadFinished() { }

	// RVA: 0x1ED8440 Offset: 0x1ED8541 VA: 0x1ED8440
	public static void set_IsLoadFinished(bool value) { }

	// RVA: 0x1ED84C0 Offset: 0x1ED85C1 VA: 0x1ED84C0
	private void AddObject(GameObject gameObject) { }

	// RVA: 0x1ED7A60 Offset: 0x1ED7B61 VA: 0x1ED7A60
	private void OpenCanvas() { }

	// RVA: 0x1ED8880 Offset: 0x1ED8981 VA: 0x1ED8880
	private void LoadCanvas(AssetHandle<GameObject> handle) { }

	// RVA: 0x1ED8900 Offset: 0x1ED8A01 VA: 0x1ED8900
	public void DoCloseCanvas() { }

	// RVA: 0x1ED8E20 Offset: 0x1ED8F21 VA: 0x1ED8E20 Slot: 7
	public override void CloseCanvas() { }

	// RVA: 0x1ED9120 Offset: 0x1ED9221 VA: 0x1ED9120
	public static void SetGuideMapOpen(GameFlagData gameFlagData) { }

	// RVA: 0x1ED9340 Offset: 0x1ED9441 VA: 0x1ED9340
	public void .ctor() { }

	// RVA: 0x1ED9570 Offset: 0x1ED9671 VA: 0x1ED9570
	private static void .cctor() { }
}

