[TypeForwardedFromAttribute] // RVA: 0xAC990 Offset: 0xACA91 VA: 0xAC990
[Serializable]
public struct TimeZoneInfo.TransitionTime : IEquatable<TimeZoneInfo.TransitionTime>, ISerializable, IDeserializationCallback // TypeDefIndex: 325
{
	// Fields
	private DateTime m_timeOfDay; // 0x0
	private byte m_month; // 0x8
	private byte m_week; // 0x9
	private byte m_day; // 0xA
	private DayOfWeek m_dayOfWeek; // 0xC
	private bool m_isFixedDateRule; // 0x10

	// Properties
	public DateTime TimeOfDay { get; }
	public int Month { get; }
	public int Week { get; }
	public int Day { get; }
	public DayOfWeek DayOfWeek { get; }
	public bool IsFixedDateRule { get; }

	// Methods

	// RVA: 0x19690 Offset: 0x19791 VA: 0x19690
	public DateTime get_TimeOfDay() { }

	// RVA: 0x196A0 Offset: 0x197A1 VA: 0x196A0
	public int get_Month() { }

	// RVA: 0x196B0 Offset: 0x197B1 VA: 0x196B0
	public int get_Week() { }

	// RVA: 0x196C0 Offset: 0x197C1 VA: 0x196C0
	public int get_Day() { }

	// RVA: 0x196D0 Offset: 0x197D1 VA: 0x196D0
	public DayOfWeek get_DayOfWeek() { }

	// RVA: 0x196E0 Offset: 0x197E1 VA: 0x196E0
	public bool get_IsFixedDateRule() { }

	// RVA: 0x196F0 Offset: 0x197F1 VA: 0x196F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1AD86A0 Offset: 0x1AD87A1 VA: 0x1AD86A0
	public static bool op_Inequality(TimeZoneInfo.TransitionTime t1, TimeZoneInfo.TransitionTime t2) { }

	// RVA: 0x19700 Offset: 0x19801 VA: 0x19700 Slot: 4
	public bool Equals(TimeZoneInfo.TransitionTime other) { }

	// RVA: 0x19800 Offset: 0x19901 VA: 0x19800 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1AD87D0 Offset: 0x1AD88D1 VA: 0x1AD87D0
	public static TimeZoneInfo.TransitionTime CreateFixedDateRule(DateTime timeOfDay, int month, int day) { }

	// RVA: 0x1AD88C0 Offset: 0x1AD89C1 VA: 0x1AD88C0
	public static TimeZoneInfo.TransitionTime CreateFloatingDateRule(DateTime timeOfDay, int month, int week, DayOfWeek dayOfWeek) { }

	// RVA: 0x1AD8840 Offset: 0x1AD8941 VA: 0x1AD8840
	private static TimeZoneInfo.TransitionTime CreateTransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek, bool isFixedDateRule) { }

	// RVA: 0x1AD8930 Offset: 0x1AD8A31 VA: 0x1AD8930
	private static void ValidateTransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek) { }

	// RVA: 0x19820 Offset: 0x19921 VA: 0x19820 Slot: 6
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x19830 Offset: 0x19931 VA: 0x19830 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x19840 Offset: 0x19941 VA: 0x19840
	private void .ctor(SerializationInfo info, StreamingContext context) { }
}

