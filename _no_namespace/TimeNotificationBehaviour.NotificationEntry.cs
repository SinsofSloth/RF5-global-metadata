private struct TimeNotificationBehaviour.NotificationEntry // TypeDefIndex: 4611
{
	// Fields
	public double time; // 0x0
	public INotification payload; // 0x8
	public bool notificationFired; // 0x10
	public NotificationFlags flags; // 0x12

	// Properties
	public bool triggerInEditor { get; }
	public bool prewarm { get; }
	public bool triggerOnce { get; }

	// Methods

	// RVA: 0xA980 Offset: 0xAA81 VA: 0xA980
	public bool get_triggerInEditor() { }

	// RVA: 0xA990 Offset: 0xAA91 VA: 0xA990
	public bool get_prewarm() { }

	// RVA: 0xA9A0 Offset: 0xAAA1 VA: 0xA9A0
	public bool get_triggerOnce() { }
}

