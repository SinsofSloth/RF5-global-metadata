public class TimeNotificationBehaviour : PlayableBehaviour // TypeDefIndex: 4610
{
	// Fields
	private readonly List<TimeNotificationBehaviour.NotificationEntry> m_Notifications; // 0x10
	private double m_PreviousTime; // 0x18
	private bool m_NeedSortNotifications; // 0x20
	private Playable m_TimeSource; // 0x28

	// Properties
	public Playable timeSource { set; }

	// Methods

	// RVA: 0x17E6BA0 Offset: 0x17E6CA1 VA: 0x17E6BA0
	public void set_timeSource(Playable value) { }

	// RVA: 0x17E3780 Offset: 0x17E3881 VA: 0x17E3780
	public static ScriptPlayable<TimeNotificationBehaviour> Create(PlayableGraph graph, double duration, DirectorWrapMode loopMode) { }

	// RVA: 0x17E3880 Offset: 0x17E3981 VA: 0x17E3880
	public void AddNotification(double time, INotification payload, NotificationFlags flags = 2) { }

	// RVA: 0x17E6BB0 Offset: 0x17E6CB1 VA: 0x17E6BB0 Slot: 13
	public override void OnGraphStart(Playable playable) { }

	// RVA: 0x17E6EB0 Offset: 0x17E6FB1 VA: 0x17E6EB0 Slot: 18
	public override void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0x17E7140 Offset: 0x17E7241 VA: 0x17E7140 Slot: 19
	public override void PrepareFrame(Playable playable, FrameData info) { }

	// RVA: 0x17E6D70 Offset: 0x17E6E71 VA: 0x17E6D70
	private void SortNotifications() { }

	// RVA: 0x17E77E0 Offset: 0x17E78E1 VA: 0x17E77E0
	private static bool CanRestoreNotification(TimeNotificationBehaviour.NotificationEntry e, FrameData info, double currentTime, double previousTime) { }

	// RVA: 0x17E75A0 Offset: 0x17E76A1 VA: 0x17E75A0
	private void TriggerNotificationsInRange(double start, double end, FrameData info, Playable playable, bool checkState) { }

	// RVA: 0x17E74D0 Offset: 0x17E75D1 VA: 0x17E74D0
	private void SyncDurationWithExternalSource(Playable playable) { }

	// RVA: 0x17E70B0 Offset: 0x17E71B1 VA: 0x17E70B0
	private static void Trigger_internal(Playable playable, PlayableOutput output, ref TimeNotificationBehaviour.NotificationEntry e) { }

	// RVA: 0x17E7880 Offset: 0x17E7981 VA: 0x17E7880
	private static void Restore_internal(ref TimeNotificationBehaviour.NotificationEntry e) { }

	// RVA: 0x17E78B0 Offset: 0x17E79B1 VA: 0x17E78B0
	public void .ctor() { }
}

