public class PopupChoiceControl : MonoBehaviour // TypeDefIndex: 8809
{
	// Fields
	[SerializeField] // RVA: 0x173A60 Offset: 0x173B61 VA: 0x173A60
	private bool isSingleton; // 0x18
	[SerializeField] // RVA: 0x173A70 Offset: 0x173B71 VA: 0x173A70
	private bool UseFirstSuspension; // 0x19
	private bool onSuspension; // 0x1A
	public static PopupChoiceControl Instance; // 0x0
	[SerializeField] // RVA: 0x173A80 Offset: 0x173B81 VA: 0x173A80
	private ChoiceImage ChoiceImageObj; // 0x20
	[SerializeField] // RVA: 0x173A90 Offset: 0x173B91 VA: 0x173A90
	private RectTransform CenterChoice; // 0x28
	[SerializeField] // RVA: 0x173AA0 Offset: 0x173BA1 VA: 0x173AA0
	private NonFocusButton UpArrow; // 0x30
	[SerializeField] // RVA: 0x173AB0 Offset: 0x173BB1 VA: 0x173AB0
	private NonFocusButton DownArrow; // 0x38
	[SerializeField] // RVA: 0x173AC0 Offset: 0x173BC1 VA: 0x173AC0
	private float HeightMergin; // 0x40
	[SerializeField] // RVA: 0x173AD0 Offset: 0x173BD1 VA: 0x173AD0
	private int DispMax; // 0x44
	private float ChoiceImgHeight; // 0x48
	private List<string> ChoiceTexts; // 0x50
	private List<string> ChoiceTexts2; // 0x58
	private List<ChoiceImage> ChoiceList; // 0x60
	private List<string> ChoiceAdvTexts; // 0x68
	private List<string> ChoiceAdvNameTexts; // 0x70
	private UnityAction<int> OnSelected; // 0x78
	private int selecting; // 0x80
	private int dispHead; // 0x84
	private bool UseCancelButton; // 0x88
	private bool PauseGameOnChoice; // 0x89
	private const float DefaultStartupTime = 0.3;
	private float StartupTime; // 0x8C
	private const float StartConfirmAcceptDelayMax = 0.8;
	private float StartConfirmAcceptDelay; // 0x90
	private AdvDialogControl _AdvDialogControl; // 0x98
	private bool IsSelected; // 0xA0
	private const float endWaitTimeMax = 0.3;
	private float endWaitTime; // 0xA4

	// Properties
	private AdvDialogControl AdvDialogControl { get; }

	// Methods

	// RVA: 0x2772750 Offset: 0x2772851 VA: 0x2772750
	private AdvDialogControl get_AdvDialogControl() { }

	// RVA: 0x2772860 Offset: 0x2772961 VA: 0x2772860
	private void Awake() { }

	// RVA: 0x27729C0 Offset: 0x2772AC1 VA: 0x27729C0
	public void ChoiceImageAdjustPosition() { }

	// RVA: 0x2772BC0 Offset: 0x2772CC1 VA: 0x2772BC0
	public void SetArrow() { }

	// RVA: 0x2772CC0 Offset: 0x2772DC1 VA: 0x2772CC0
	public void ChoiceDetailSet() { }

	// RVA: 0x2772E80 Offset: 0x2772F81 VA: 0x2772E80
	public void Selecting(int select) { }

	// RVA: 0x2773050 Offset: 0x2773151 VA: 0x2773050
	public void CreateChoice(UnityAction<int> onSelectedEvent, List<string> texts, bool useCancelButton = False, bool pauseGameOnChoice = False) { }

	// RVA: 0x2773350 Offset: 0x2773451 VA: 0x2773350
	public void CreateChoiceWithAdvText(UnityAction<int> onSelectedEvent, List<string> texts, List<string> texts2, List<string> advTexts, List<string> advNames, bool useCancelButton = False, bool pauseGameOnChoice = False) { }

	// RVA: 0x27733C0 Offset: 0x27734C1 VA: 0x27733C0
	public void AddChoice(UnityAction<int> onSelectedEvent, string text, bool useCancelButton = False, bool pauseGameOnChoice = False) { }

	// RVA: 0x2773710 Offset: 0x2773811 VA: 0x2773710
	public void AddChoice(UnityAction<int> onSelectedEvent, string text, string advText, string advName, bool useCancelButton = False, bool pauseGameOnChoice = False) { }

	// RVA: 0x2773990 Offset: 0x2773A91 VA: 0x2773990
	private void ClearNotSelectedChoice() { }

	// RVA: 0x2773530 Offset: 0x2773631 VA: 0x2773530
	private void ClearAllChoice() { }

	// RVA: 0x2773AA0 Offset: 0x2773BA1 VA: 0x2773AA0
	private void EndMessageSelected() { }

	// RVA: 0x2773B80 Offset: 0x2773C81 VA: 0x2773B80
	private void Input() { }

	// RVA: 0x2773FE0 Offset: 0x27740E1 VA: 0x2773FE0
	private void OnSubmit() { }

	// RVA: 0x2773260 Offset: 0x2773361 VA: 0x2773260
	private void SetTouchEvent(int _index) { }

	// RVA: 0x27740D0 Offset: 0x27741D1 VA: 0x27740D0
	private void Update() { }

	// RVA: 0x27741E0 Offset: 0x27742E1 VA: 0x27741E0
	public void .ctor() { }

	// RVA: 0x2774210 Offset: 0x2774311 VA: 0x2774210
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A87E0 Offset: 0x1A88E1 VA: 0x1A87E0
	// RVA: 0x2774220 Offset: 0x2774321 VA: 0x2774220
	private void <Awake>b__28_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A87F0 Offset: 0x1A88F1 VA: 0x1A87F0
	// RVA: 0x27742C0 Offset: 0x27743C1 VA: 0x27742C0
	private void <Awake>b__28_1() { }
}

