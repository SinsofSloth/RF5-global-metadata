public class BugReportApi // TypeDefIndex: 5649
{
	// Fields
	private readonly string _apiKey; // 0x10
	private readonly BugReport _bugReport; // 0x18
	private bool _isBusy; // 0x20
	private UnityWebRequest _webRequest; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x13CB80 Offset: 0x13CC81 VA: 0x13CB80
	private bool <IsComplete>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x13CB90 Offset: 0x13CC91 VA: 0x13CB90
	private bool <WasSuccessful>k__BackingField; // 0x31
	[CompilerGeneratedAttribute] // RVA: 0x13CBA0 Offset: 0x13CCA1 VA: 0x13CBA0
	private string <ErrorMessage>k__BackingField; // 0x38

	// Properties
	public bool IsComplete { get; set; }
	public bool WasSuccessful { get; set; }
	public string ErrorMessage { get; set; }
	public float Progress { get; }

	// Methods

	// RVA: 0x152D3B0 Offset: 0x152D4B1 VA: 0x152D3B0
	public void .ctor(BugReport report, string apiKey) { }

	[CompilerGeneratedAttribute] // RVA: 0x13D500 Offset: 0x13D601 VA: 0x13D500
	// RVA: 0x152D400 Offset: 0x152D501 VA: 0x152D400
	public bool get_IsComplete() { }

	[CompilerGeneratedAttribute] // RVA: 0x13D510 Offset: 0x13D611 VA: 0x13D510
	// RVA: 0x152D410 Offset: 0x152D511 VA: 0x152D410
	private void set_IsComplete(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13D520 Offset: 0x13D621 VA: 0x13D520
	// RVA: 0x152D420 Offset: 0x152D521 VA: 0x152D420
	public bool get_WasSuccessful() { }

	[CompilerGeneratedAttribute] // RVA: 0x13D530 Offset: 0x13D631 VA: 0x13D530
	// RVA: 0x152D430 Offset: 0x152D531 VA: 0x152D430
	private void set_WasSuccessful(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13D540 Offset: 0x13D641 VA: 0x13D540
	// RVA: 0x152D440 Offset: 0x152D541 VA: 0x152D440
	public string get_ErrorMessage() { }

	[CompilerGeneratedAttribute] // RVA: 0x13D550 Offset: 0x13D651 VA: 0x13D550
	// RVA: 0x152D450 Offset: 0x152D551 VA: 0x152D450
	private void set_ErrorMessage(string value) { }

	// RVA: 0x152D460 Offset: 0x152D561 VA: 0x152D460
	public float get_Progress() { }

	[IteratorStateMachineAttribute] // RVA: 0x13D560 Offset: 0x13D661 VA: 0x13D560
	// RVA: 0x152D500 Offset: 0x152D601 VA: 0x152D500
	public IEnumerator Submit() { }

	// RVA: 0x152D5B0 Offset: 0x152D6B1 VA: 0x152D5B0
	private void SetCompletionState(bool wasSuccessful) { }

	// RVA: 0x152D680 Offset: 0x152D781 VA: 0x152D680
	private static string BuildJsonRequest(BugReport report) { }

	// RVA: 0x152D7E0 Offset: 0x152D8E1 VA: 0x152D7E0
	private static IList<IList<string>> CreateConsoleDump() { }
}

