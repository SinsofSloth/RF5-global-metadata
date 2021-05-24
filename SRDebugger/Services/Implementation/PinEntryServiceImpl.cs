[ServiceAttribute] // RVA: 0x13B990 Offset: 0x13BA91 VA: 0x13B990
public class PinEntryServiceImpl : SRServiceBase<IPinEntryService>, IPinEntryService // TypeDefIndex: 5634
{
	// Fields
	private PinEntryCompleteCallback _callback; // 0x48
	private bool _isVisible; // 0x50
	private PinEntryControl _pinControl; // 0x58
	private List<int> _requiredPin; // 0x60

	// Properties
	public bool IsShowingKeypad { get; }

	// Methods

	// RVA: 0x1539340 Offset: 0x1539441 VA: 0x1539340 Slot: 11
	public bool get_IsShowingKeypad() { }

	// RVA: 0x1539350 Offset: 0x1539451 VA: 0x1539350 Slot: 12
	public void ShowPinEntry(IList<int> requiredPin, string message, PinEntryCompleteCallback callback, bool allowCancel = True) { }

	[ObsoleteAttribute] // RVA: 0x13D2C0 Offset: 0x13D3C1 VA: 0x13D2C0
	// RVA: 0x1539E10 Offset: 0x1539F11 VA: 0x1539E10 Slot: 13
	public void ShowPinEntry(IList<int> requiredPin, string message, PinEntryCompleteCallback callback, bool blockInput, bool allowCancel) { }

	// RVA: 0x1539E20 Offset: 0x1539F21 VA: 0x1539E20 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1539850 Offset: 0x1539951 VA: 0x1539850
	private void Load() { }

	// RVA: 0x153A000 Offset: 0x153A101 VA: 0x153A000
	private void PinControlOnComplete(IList<int> result, bool didCancel) { }

	// RVA: 0x15395E0 Offset: 0x15396E1 VA: 0x15395E0
	private void VerifyPin(IList<int> pin) { }

	// RVA: 0x153A1F0 Offset: 0x153A2F1 VA: 0x153A1F0
	public void .ctor() { }
}

[ServiceAttribute] // RVA: 0x13B990 Offset: 0x13BA91 VA: 0x13B990
public class PinEntryServiceImpl : SRServiceBase<IPinEntryService>, IPinEntryService // TypeDefIndex: 5634
{
	// Fields
	private PinEntryCompleteCallback _callback; // 0x48
	private bool _isVisible; // 0x50
	private PinEntryControl _pinControl; // 0x58
	private List<int> _requiredPin; // 0x60

	// Properties
	public bool IsShowingKeypad { get; }

	// Methods

	// RVA: 0x1539340 Offset: 0x1539441 VA: 0x1539340 Slot: 11
	public bool get_IsShowingKeypad() { }

	// RVA: 0x1539350 Offset: 0x1539451 VA: 0x1539350 Slot: 12
	public void ShowPinEntry(IList<int> requiredPin, string message, PinEntryCompleteCallback callback, bool allowCancel = True) { }

	[ObsoleteAttribute] // RVA: 0x13D2C0 Offset: 0x13D3C1 VA: 0x13D2C0
	// RVA: 0x1539E10 Offset: 0x1539F11 VA: 0x1539E10 Slot: 13
	public void ShowPinEntry(IList<int> requiredPin, string message, PinEntryCompleteCallback callback, bool blockInput, bool allowCancel) { }

	// RVA: 0x1539E20 Offset: 0x1539F21 VA: 0x1539E20 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1539850 Offset: 0x1539951 VA: 0x1539850
	private void Load() { }

	// RVA: 0x153A000 Offset: 0x153A101 VA: 0x153A000
	private void PinControlOnComplete(IList<int> result, bool didCancel) { }

	// RVA: 0x15395E0 Offset: 0x15396E1 VA: 0x15395E0
	private void VerifyPin(IList<int> pin) { }

	// RVA: 0x153A1F0 Offset: 0x153A2F1 VA: 0x153A1F0
	public void .ctor() { }
}

[ServiceAttribute] // RVA: 0x13B990 Offset: 0x13BA91 VA: 0x13B990
public class PinEntryServiceImpl : SRServiceBase<IPinEntryService>, IPinEntryService // TypeDefIndex: 5634
{
	// Fields
	private PinEntryCompleteCallback _callback; // 0x48
	private bool _isVisible; // 0x50
	private PinEntryControl _pinControl; // 0x58
	private List<int> _requiredPin; // 0x60

	// Properties
	public bool IsShowingKeypad { get; }

	// Methods

	// RVA: 0x1539340 Offset: 0x1539441 VA: 0x1539340 Slot: 11
	public bool get_IsShowingKeypad() { }

	// RVA: 0x1539350 Offset: 0x1539451 VA: 0x1539350 Slot: 12
	public void ShowPinEntry(IList<int> requiredPin, string message, PinEntryCompleteCallback callback, bool allowCancel = True) { }

	[ObsoleteAttribute] // RVA: 0x13D2C0 Offset: 0x13D3C1 VA: 0x13D2C0
	// RVA: 0x1539E10 Offset: 0x1539F11 VA: 0x1539E10 Slot: 13
	public void ShowPinEntry(IList<int> requiredPin, string message, PinEntryCompleteCallback callback, bool blockInput, bool allowCancel) { }

	// RVA: 0x1539E20 Offset: 0x1539F21 VA: 0x1539E20 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1539850 Offset: 0x1539951 VA: 0x1539850
	private void Load() { }

	// RVA: 0x153A000 Offset: 0x153A101 VA: 0x153A000
	private void PinControlOnComplete(IList<int> result, bool didCancel) { }

	// RVA: 0x15395E0 Offset: 0x15396E1 VA: 0x15395E0
	private void VerifyPin(IList<int> pin) { }

	// RVA: 0x153A1F0 Offset: 0x153A2F1 VA: 0x153A1F0
	public void .ctor() { }
}

[ServiceAttribute] // RVA: 0x13B990 Offset: 0x13BA91 VA: 0x13B990
public class PinEntryServiceImpl : SRServiceBase<IPinEntryService>, IPinEntryService // TypeDefIndex: 5634
{
	// Fields
	private PinEntryCompleteCallback _callback; // 0x48
	private bool _isVisible; // 0x50
	private PinEntryControl _pinControl; // 0x58
	private List<int> _requiredPin; // 0x60

	// Properties
	public bool IsShowingKeypad { get; }

	// Methods

	// RVA: 0x1539340 Offset: 0x1539441 VA: 0x1539340 Slot: 11
	public bool get_IsShowingKeypad() { }

	// RVA: 0x1539350 Offset: 0x1539451 VA: 0x1539350 Slot: 12
	public void ShowPinEntry(IList<int> requiredPin, string message, PinEntryCompleteCallback callback, bool allowCancel = True) { }

	[ObsoleteAttribute] // RVA: 0x13D2C0 Offset: 0x13D3C1 VA: 0x13D2C0
	// RVA: 0x1539E10 Offset: 0x1539F11 VA: 0x1539E10 Slot: 13
	public void ShowPinEntry(IList<int> requiredPin, string message, PinEntryCompleteCallback callback, bool blockInput, bool allowCancel) { }

	// RVA: 0x1539E20 Offset: 0x1539F21 VA: 0x1539E20 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1539850 Offset: 0x1539951 VA: 0x1539850
	private void Load() { }

	// RVA: 0x153A000 Offset: 0x153A101 VA: 0x153A000
	private void PinControlOnComplete(IList<int> result, bool didCancel) { }

	// RVA: 0x15395E0 Offset: 0x15396E1 VA: 0x15395E0
	private void VerifyPin(IList<int> pin) { }

	// RVA: 0x153A1F0 Offset: 0x153A2F1 VA: 0x153A1F0
	public void .ctor() { }
}

[ServiceAttribute] // RVA: 0x13B990 Offset: 0x13BA91 VA: 0x13B990
public class PinEntryServiceImpl : SRServiceBase<IPinEntryService>, IPinEntryService // TypeDefIndex: 5634
{
	// Fields
	private PinEntryCompleteCallback _callback; // 0x48
	private bool _isVisible; // 0x50
	private PinEntryControl _pinControl; // 0x58
	private List<int> _requiredPin; // 0x60

	// Properties
	public bool IsShowingKeypad { get; }

	// Methods

	// RVA: 0x1539340 Offset: 0x1539441 VA: 0x1539340 Slot: 11
	public bool get_IsShowingKeypad() { }

	// RVA: 0x1539350 Offset: 0x1539451 VA: 0x1539350 Slot: 12
	public void ShowPinEntry(IList<int> requiredPin, string message, PinEntryCompleteCallback callback, bool allowCancel = True) { }

	[ObsoleteAttribute] // RVA: 0x13D2C0 Offset: 0x13D3C1 VA: 0x13D2C0
	// RVA: 0x1539E10 Offset: 0x1539F11 VA: 0x1539E10 Slot: 13
	public void ShowPinEntry(IList<int> requiredPin, string message, PinEntryCompleteCallback callback, bool blockInput, bool allowCancel) { }

	// RVA: 0x1539E20 Offset: 0x1539F21 VA: 0x1539E20 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1539850 Offset: 0x1539951 VA: 0x1539850
	private void Load() { }

	// RVA: 0x153A000 Offset: 0x153A101 VA: 0x153A000
	private void PinControlOnComplete(IList<int> result, bool didCancel) { }

	// RVA: 0x15395E0 Offset: 0x15396E1 VA: 0x15395E0
	private void VerifyPin(IList<int> pin) { }

	// RVA: 0x153A1F0 Offset: 0x153A2F1 VA: 0x153A1F0
	public void .ctor() { }
}

