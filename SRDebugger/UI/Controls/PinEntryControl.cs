public class PinEntryControl : SRMonoBehaviourEx // TypeDefIndex: 5588
{
	// Fields
	private bool _isVisible; // 0x48
	private List<int> _numbers; // 0x50
	[RequiredFieldAttribute] // RVA: 0x13C830 Offset: 0x13C931 VA: 0x13C830
	public Image Background; // 0x58
	public bool CanCancel; // 0x60
	[RequiredFieldAttribute] // RVA: 0x13C840 Offset: 0x13C941 VA: 0x13C840
	public Button CancelButton; // 0x68
	[RequiredFieldAttribute] // RVA: 0x13C850 Offset: 0x13C951 VA: 0x13C850
	public Text CancelButtonText; // 0x70
	[RequiredFieldAttribute] // RVA: 0x13C860 Offset: 0x13C961 VA: 0x13C860
	public CanvasGroup CanvasGroup; // 0x78
	[RequiredFieldAttribute] // RVA: 0x13C870 Offset: 0x13C971 VA: 0x13C870
	public Animator DotAnimator; // 0x80
	public Button[] NumberButtons; // 0x88
	public Toggle[] NumberDots; // 0x90
	[RequiredFieldAttribute] // RVA: 0x13C880 Offset: 0x13C981 VA: 0x13C880
	public Text PromptText; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x13C890 Offset: 0x13C991 VA: 0x13C890
	private PinEntryControlCallback Complete; // 0xA0

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x13CF40 Offset: 0x13D041 VA: 0x13CF40
	// RVA: 0x1539F50 Offset: 0x153A051 VA: 0x1539F50
	public void add_Complete(PinEntryControlCallback value) { }

	[CompilerGeneratedAttribute] // RVA: 0x13CF50 Offset: 0x13D051 VA: 0x13CF50
	// RVA: 0x1546F00 Offset: 0x1547001 VA: 0x1546F00
	public void remove_Complete(PinEntryControlCallback value) { }

	// RVA: 0x1546FB0 Offset: 0x15470B1 VA: 0x1546FB0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1547240 Offset: 0x1547341 VA: 0x1547240 Slot: 6
	protected override void Update() { }

	// RVA: 0x1539DA0 Offset: 0x1539EA1 VA: 0x1539DA0
	public void Show() { }

	// RVA: 0x1539ED0 Offset: 0x1539FD1 VA: 0x1539ED0
	public void Hide() { }

	// RVA: 0x1539D40 Offset: 0x1539E41 VA: 0x1539D40
	public void Clear() { }

	// RVA: 0x153A190 Offset: 0x153A291 VA: 0x153A190
	public void PlayInvalidCodeAnimation() { }

	// RVA: 0x15474D0 Offset: 0x15475D1 VA: 0x15474D0
	protected void OnComplete() { }

	// RVA: 0x15479F0 Offset: 0x1547AF1 VA: 0x15479F0
	protected void OnCancel() { }

	// RVA: 0x1547A70 Offset: 0x1547B71 VA: 0x1547A70
	private void CancelButtonPressed() { }

	// RVA: 0x1547390 Offset: 0x1547491 VA: 0x1547390
	public void PushNumber(int number) { }

	// RVA: 0x1547140 Offset: 0x1547241 VA: 0x1547140
	private void RefreshState() { }

	// RVA: 0x1547B40 Offset: 0x1547C41 VA: 0x1547B40
	public void .ctor() { }
}

