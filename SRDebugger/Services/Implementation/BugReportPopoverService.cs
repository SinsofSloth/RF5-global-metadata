[ServiceAttribute] // RVA: 0x13B680 Offset: 0x13B781 VA: 0x13B680
public class BugReportPopoverService : SRServiceBase<BugReportPopoverService> // TypeDefIndex: 5626
{
	// Fields
	private BugReportCompleteCallback _callback; // 0x48
	private bool _isVisible; // 0x50
	private BugReportPopoverRoot _popover; // 0x58
	private BugReportSheetController _sheet; // 0x60

	// Properties
	public bool IsShowingPopover { get; }

	// Methods

	// RVA: 0x1534670 Offset: 0x1534771 VA: 0x1534670
	public bool get_IsShowingPopover() { }

	// RVA: 0x1534680 Offset: 0x1534781 VA: 0x1534680
	public void ShowBugReporter(BugReportCompleteCallback callback, bool takeScreenshotFirst = True, string descriptionText) { }

	[IteratorStateMachineAttribute] // RVA: 0x13D1F0 Offset: 0x13D2F1 VA: 0x13D1F0
	// RVA: 0x1534BD0 Offset: 0x1534CD1 VA: 0x1534BD0
	private IEnumerator OpenCo(bool takeScreenshot, string descriptionText) { }

	// RVA: 0x1534CB0 Offset: 0x1534DB1 VA: 0x1534CB0
	private void SubmitComplete(bool didSucceed, string errorMessage) { }

	// RVA: 0x1534E40 Offset: 0x1534F41 VA: 0x1534E40
	private void CancelPressed() { }

	// RVA: 0x1534CC0 Offset: 0x1534DC1 VA: 0x1534CC0
	private void OnComplete(bool success, string errorMessage, bool close) { }

	// RVA: 0x1534EA0 Offset: 0x1534FA1 VA: 0x1534EA0
	private void TakingScreenshot() { }

	// RVA: 0x1534F40 Offset: 0x1535041 VA: 0x1534F40
	private void ScreenshotComplete() { }

	// RVA: 0x1534FE0 Offset: 0x15350E1 VA: 0x1534FE0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1534890 Offset: 0x1534991 VA: 0x1534890
	private void Load() { }

	// RVA: 0x1535090 Offset: 0x1535191 VA: 0x1535090
	public void .ctor() { }
}

