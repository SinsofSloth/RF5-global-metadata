public class BugReportSheetController : SRMonoBehaviourEx // TypeDefIndex: 5559
{
	// Fields
	[RequiredFieldAttribute] // RVA: 0x13C300 Offset: 0x13C401 VA: 0x13C300
	public GameObject ButtonContainer; // 0x48
	[RequiredFieldAttribute] // RVA: 0x13C310 Offset: 0x13C411 VA: 0x13C310
	public Text ButtonText; // 0x50
	[RequiredFieldAttribute] // RVA: 0x13C320 Offset: 0x13C421 VA: 0x13C320
	public Button CancelButton; // 0x58
	public Action CancelPressed; // 0x60
	[RequiredFieldAttribute] // RVA: 0x13C330 Offset: 0x13C431 VA: 0x13C330
	public InputField DescriptionField; // 0x68
	[RequiredFieldAttribute] // RVA: 0x13C340 Offset: 0x13C441 VA: 0x13C340
	public InputField EmailField; // 0x70
	[RequiredFieldAttribute] // RVA: 0x13C350 Offset: 0x13C451 VA: 0x13C350
	public Slider ProgressBar; // 0x78
	[RequiredFieldAttribute] // RVA: 0x13C360 Offset: 0x13C461 VA: 0x13C360
	public Text ResultMessageText; // 0x80
	public Action ScreenshotComplete; // 0x88
	[RequiredFieldAttribute] // RVA: 0x13C370 Offset: 0x13C471 VA: 0x13C370
	public Button SubmitButton; // 0x90
	public Action<bool, string> SubmitComplete; // 0x98
	public Action TakingScreenshot; // 0xA0

	// Properties
	public bool IsCancelButtonEnabled { get; set; }

	// Methods

	// RVA: 0x1B2F160 Offset: 0x1B2F261 VA: 0x1B2F160
	public bool get_IsCancelButtonEnabled() { }

	// RVA: 0x1B2F190 Offset: 0x1B2F291 VA: 0x1B2F190
	public void set_IsCancelButtonEnabled(bool value) { }

	// RVA: 0x1B2F1D0 Offset: 0x1B2F2D1 VA: 0x1B2F1D0 Slot: 5
	protected override void Start() { }

	// RVA: 0x1B2F3F0 Offset: 0x1B2F4F1 VA: 0x1B2F3F0
	public void Submit() { }

	// RVA: 0x1B2F710 Offset: 0x1B2F811 VA: 0x1B2F710
	public void Cancel() { }

	[IteratorStateMachineAttribute] // RVA: 0x13CE20 Offset: 0x13CF21 VA: 0x13CE20
	// RVA: 0x1B2F690 Offset: 0x1B2F791 VA: 0x1B2F690
	private IEnumerator SubmitCo() { }

	// RVA: 0x1B2F760 Offset: 0x1B2F861 VA: 0x1B2F760
	private void OnBugReportProgress(float progress) { }

	// RVA: 0x1B2F790 Offset: 0x1B2F891 VA: 0x1B2F790
	private void OnBugReportComplete(bool didSucceed, string errorMessage) { }

	// RVA: 0x1B2F240 Offset: 0x1B2F341 VA: 0x1B2F240
	protected void SetLoadingSpinnerVisible(bool visible) { }

	// RVA: 0x1B2F330 Offset: 0x1B2F431 VA: 0x1B2F330
	protected void ClearForm() { }

	// RVA: 0x1B2F8A0 Offset: 0x1B2F9A1 VA: 0x1B2F8A0
	protected void ShowErrorMessage(string userMessage, string serverMessage) { }

	// RVA: 0x1B2F2A0 Offset: 0x1B2F3A1 VA: 0x1B2F2A0
	protected void ClearErrorMessage() { }

	// RVA: 0x1B2F5B0 Offset: 0x1B2F6B1 VA: 0x1B2F5B0
	protected void SetFormEnabled(bool e) { }

	// RVA: 0x1B2F9D0 Offset: 0x1B2FAD1 VA: 0x1B2F9D0
	private string GetDefaultEmailFieldContents() { }

	// RVA: 0x1B2F630 Offset: 0x1B2F731 VA: 0x1B2F630
	private void SetDefaultEmailFieldContents(string value) { }

	// RVA: 0x1B2FA30 Offset: 0x1B2FB31 VA: 0x1B2FA30
	public void .ctor() { }
}

