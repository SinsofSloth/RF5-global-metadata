public class SignalReceiver : MonoBehaviour, INotificationReceiver // TypeDefIndex: 4595
{
	// Fields
	[SerializeField] // RVA: 0x12BC90 Offset: 0x12BD91 VA: 0x12BC90
	private SignalReceiver.EventKeyValue m_Events; // 0x18

	// Methods

	// RVA: 0x17E5930 Offset: 0x17E5A31 VA: 0x17E5930 Slot: 4
	public void OnNotify(Playable origin, INotification notification, object context) { }

	// RVA: 0x17E5B40 Offset: 0x17E5C41 VA: 0x17E5B40
	public void AddReaction(SignalAsset asset, UnityEvent reaction) { }

	// RVA: 0x17E5D50 Offset: 0x17E5E51 VA: 0x17E5D50
	public int AddEmptyReaction(UnityEvent reaction) { }

	// RVA: 0x17E5E20 Offset: 0x17E5F21 VA: 0x17E5E20
	public void Remove(SignalAsset asset) { }

	// RVA: 0x17E5FA0 Offset: 0x17E60A1 VA: 0x17E5FA0
	public IEnumerable<SignalAsset> GetRegisteredSignals() { }

	// RVA: 0x17E5FC0 Offset: 0x17E60C1 VA: 0x17E5FC0
	public UnityEvent GetReaction(SignalAsset key) { }

	// RVA: 0x17E6000 Offset: 0x17E6101 VA: 0x17E6000
	public int Count() { }

	// RVA: 0x17E6060 Offset: 0x17E6161 VA: 0x17E6060
	public void ChangeSignalAtIndex(int idx, SignalAsset newKey) { }

	// RVA: 0x17E62C0 Offset: 0x17E63C1 VA: 0x17E62C0
	public void RemoveAtIndex(int idx) { }

	// RVA: 0x17E6460 Offset: 0x17E6561 VA: 0x17E6460
	public void ChangeReactionAtIndex(int idx, UnityEvent reaction) { }

	// RVA: 0x17E6520 Offset: 0x17E6621 VA: 0x17E6520
	public UnityEvent GetReactionAtIndex(int idx) { }

	// RVA: 0x17E65E0 Offset: 0x17E66E1 VA: 0x17E65E0
	public SignalAsset GetSignalAssetAtIndex(int idx) { }

	// RVA: 0x17E66A0 Offset: 0x17E67A1 VA: 0x17E66A0
	private void OnEnable() { }

	// RVA: 0x17E66B0 Offset: 0x17E67B1 VA: 0x17E66B0
	public void .ctor() { }
}

