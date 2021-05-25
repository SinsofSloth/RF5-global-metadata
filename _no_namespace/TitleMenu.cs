public class TitleMenu : SingletonMonoBehaviour<TitleMenu> // TypeDefIndex: 7720
{
	// Fields
	private TitleMenu.MODE m_mode; // 0x18
	private float m_stayTime; // 0x1C
	[SerializeField] // RVA: 0x168CC0 Offset: 0x168DC1 VA: 0x168CC0
	private TitleCanvasControl m_TitleCanvasControl; // 0x20
	[SerializeField] // RVA: 0x168CD0 Offset: 0x168DD1 VA: 0x168CD0
	private GameObject m_TitleCanvas; // 0x28
	[SerializeField] // RVA: 0x168CE0 Offset: 0x168DE1 VA: 0x168CE0
	private InfoCanvasControl m_InfoCanvasControl; // 0x30
	private UITextDic.DICID[] textDataList; // 0x38
	private bool m_touchBtn; // 0x40
	private bool m_createSystemFlg; // 0x41
	private const float LOGO_TIME = 2;
	private const float LOGOBTN_TIME = 0.5;
	private const float FADE_TIME_S = 0.5;
	private const float FADE_TIME_L = 1;
	private const float STAY_TIME_L = 2;
	private const float STAY_TIME_S = 1;
	private string[] titleMovieNameList; // 0x48
	private string[] opMovieNameList; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x168CF0 Offset: 0x168DF1 VA: 0x168CF0
	private static bool <changeLangFlg>k__BackingField; // 0x0

	// Properties
	public static bool changeLangFlg { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A2A30 Offset: 0x1A2B31 VA: 0x1A2A30
	// RVA: 0x1D28780 Offset: 0x1D28881 VA: 0x1D28780
	public static bool get_changeLangFlg() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2A40 Offset: 0x1A2B41 VA: 0x1A2A40
	// RVA: 0x1D287F0 Offset: 0x1D288F1 VA: 0x1D287F0
	public static void set_changeLangFlg(bool value) { }

	// RVA: 0x1D28860 Offset: 0x1D28961 VA: 0x1D28860
	private void Start() { }

	// RVA: 0x1D28B10 Offset: 0x1D28C11 VA: 0x1D28B10
	private void Update() { }

	// RVA: 0x1D2A720 Offset: 0x1D2A821 VA: 0x1D2A720
	private void OnDestroy() { }

	// RVA: 0x1D2A7F0 Offset: 0x1D2A8F1 VA: 0x1D2A7F0
	private void InstanceEndScene() { }

	// RVA: 0x1D2A880 Offset: 0x1D2A981 VA: 0x1D2A880
	private void InstanceEndSceneStart() { }

	// RVA: 0x1D2A650 Offset: 0x1D2A751 VA: 0x1D2A650
	private void StartMovie(string movieName, TitleMenu.MOVIETYPE type) { }

	// RVA: 0x1D2A530 Offset: 0x1D2A631 VA: 0x1D2A530
	private void endTitleMovie() { }

	// RVA: 0x1D2A7E0 Offset: 0x1D2A8E1 VA: 0x1D2A7E0
	public void AllDestroy() { }

	// RVA: 0x1D25E90 Offset: 0x1D25F91 VA: 0x1D25E90
	public static void EndScene() { }

	// RVA: 0x1D26260 Offset: 0x1D26361 VA: 0x1D26260
	public static void EndSceneStartGame() { }

	// RVA: 0x1D2A890 Offset: 0x1D2A991 VA: 0x1D2A890
	public void touchStartUpButton(int no) { }

	// RVA: 0x1D2A980 Offset: 0x1D2AA81 VA: 0x1D2A980
	private void DoInfoAutoSave() { }

	// RVA: 0x1D2AA40 Offset: 0x1D2AB41 VA: 0x1D2AA40
	private void DoCreateSystemData() { }

	// RVA: 0x1D2AAD0 Offset: 0x1D2ABD1 VA: 0x1D2AAD0
	public void .ctor() { }

	// RVA: 0x1D2ADA0 Offset: 0x1D2AEA1 VA: 0x1D2ADA0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2A50 Offset: 0x1A2B51 VA: 0x1A2A50
	// RVA: 0x1D2ADB0 Offset: 0x1D2AEB1 VA: 0x1D2ADB0
	private void <Update>b__24_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2A60 Offset: 0x1A2B61 VA: 0x1A2A60
	// RVA: 0x1D2AE40 Offset: 0x1D2AF41 VA: 0x1D2AE40
	private void <Update>b__24_1() { }
}

