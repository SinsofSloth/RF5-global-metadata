[Serializable]
private class SignalReceiver.EventKeyValue // TypeDefIndex: 4596
{
	// Fields
	[SerializeField] // RVA: 0x12BE40 Offset: 0x12BF41 VA: 0x12BE40
	private List<SignalAsset> m_Signals; // 0x10
	[SerializeField] // RVA: 0x12BE50 Offset: 0x12BF51 VA: 0x12BE50
	[CustomSignalEventDrawer] // RVA: 0x12BE50 Offset: 0x12BF51 VA: 0x12BE50
	private List<UnityEvent> m_Events; // 0x18

	// Properties
	public List<SignalAsset> signals { get; }
	public List<UnityEvent> events { get; }

	// Methods

	// RVA: 0x17E5A60 Offset: 0x17E5B61 VA: 0x17E5A60
	public bool TryGetValue(SignalAsset key, out UnityEvent value) { }

	// RVA: 0x17E5CC0 Offset: 0x17E5DC1 VA: 0x17E5CC0
	public void Append(SignalAsset key, UnityEvent value) { }

	// RVA: 0x17E63C0 Offset: 0x17E64C1 VA: 0x17E63C0
	public void Remove(int idx) { }

	// RVA: 0x17E5EE0 Offset: 0x17E5FE1 VA: 0x17E5EE0
	public void Remove(SignalAsset key) { }

	// RVA: 0x17E67D0 Offset: 0x17E68D1 VA: 0x17E67D0
	public List<SignalAsset> get_signals() { }

	// RVA: 0x17E67E0 Offset: 0x17E68E1 VA: 0x17E67E0
	public List<UnityEvent> get_events() { }

	// RVA: 0x17E6720 Offset: 0x17E6821 VA: 0x17E6720
	public void .ctor() { }
}

