[CustomStyleAttribute] // RVA: 0x12A9E0 Offset: 0x12AAE1 VA: 0x12A9E0
[ExcludeFromPresetAttribute] // RVA: 0x12A9E0 Offset: 0x12AAE1 VA: 0x12A9E0
[Serializable]
public class SignalEmitter : Marker, INotification, INotificationOptionProvider // TypeDefIndex: 4594
{
	// Fields
	[SerializeField] // RVA: 0x12BC60 Offset: 0x12BD61 VA: 0x12BC60
	private bool m_Retroactive; // 0x28
	[SerializeField] // RVA: 0x12BC70 Offset: 0x12BD71 VA: 0x12BC70
	private bool m_EmitOnce; // 0x29
	[SerializeField] // RVA: 0x12BC80 Offset: 0x12BD81 VA: 0x12BC80
	private SignalAsset m_Asset; // 0x30

	// Properties
	public bool retroactive { get; set; }
	public bool emitOnce { get; set; }
	public SignalAsset asset { get; set; }
	private PropertyName UnityEngine.Playables.INotification.id { get; }
	private NotificationFlags UnityEngine.Timeline.INotificationOptionProvider.flags { get; }

	// Methods

	// RVA: 0x17E57D0 Offset: 0x17E58D1 VA: 0x17E57D0
	public bool get_retroactive() { }

	// RVA: 0x17E57E0 Offset: 0x17E58E1 VA: 0x17E57E0
	public void set_retroactive(bool value) { }

	// RVA: 0x17E57F0 Offset: 0x17E58F1 VA: 0x17E57F0
	public bool get_emitOnce() { }

	// RVA: 0x17E5800 Offset: 0x17E5901 VA: 0x17E5800
	public void set_emitOnce(bool value) { }

	// RVA: 0x17E5810 Offset: 0x17E5911 VA: 0x17E5810
	public SignalAsset get_asset() { }

	// RVA: 0x17E5820 Offset: 0x17E5921 VA: 0x17E5820
	public void set_asset(SignalAsset value) { }

	// RVA: 0x17E5830 Offset: 0x17E5931 VA: 0x17E5830 Slot: 9
	private PropertyName UnityEngine.Playables.INotification.get_id() { }

	// RVA: 0x17E5900 Offset: 0x17E5A01 VA: 0x17E5900 Slot: 10
	private NotificationFlags UnityEngine.Timeline.INotificationOptionProvider.get_flags() { }

	// RVA: 0x17E5920 Offset: 0x17E5A21 VA: 0x17E5920
	public void .ctor() { }
}

