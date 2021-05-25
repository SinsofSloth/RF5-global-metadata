[TypeForwardedFromAttribute] // RVA: 0xAC950 Offset: 0xACA51 VA: 0xAC950
[Serializable]
public sealed class TimeZoneInfo.AdjustmentRule : IEquatable<TimeZoneInfo.AdjustmentRule>, ISerializable, IDeserializationCallback // TypeDefIndex: 324
{
	// Fields
	private DateTime m_dateStart; // 0x10
	private DateTime m_dateEnd; // 0x18
	private TimeSpan m_daylightDelta; // 0x20
	private TimeZoneInfo.TransitionTime m_daylightTransitionStart; // 0x28
	private TimeZoneInfo.TransitionTime m_daylightTransitionEnd; // 0x40
	private TimeSpan m_baseUtcOffsetDelta; // 0x58

	// Properties
	public DateTime DateStart { get; }
	public DateTime DateEnd { get; }
	public TimeSpan DaylightDelta { get; }
	public TimeZoneInfo.TransitionTime DaylightTransitionStart { get; }
	public TimeZoneInfo.TransitionTime DaylightTransitionEnd { get; }

	// Methods

	// RVA: 0x1AD7260 Offset: 0x1AD7361 VA: 0x1AD7260
	public DateTime get_DateStart() { }

	// RVA: 0x1AD7270 Offset: 0x1AD7371 VA: 0x1AD7270
	public DateTime get_DateEnd() { }

	// RVA: 0x1AD7280 Offset: 0x1AD7381 VA: 0x1AD7280
	public TimeSpan get_DaylightDelta() { }

	// RVA: 0x1AD7290 Offset: 0x1AD7391 VA: 0x1AD7290
	public TimeZoneInfo.TransitionTime get_DaylightTransitionStart() { }

	// RVA: 0x1AD72B0 Offset: 0x1AD73B1 VA: 0x1AD72B0
	public TimeZoneInfo.TransitionTime get_DaylightTransitionEnd() { }

	// RVA: 0x1AD72D0 Offset: 0x1AD73D1 VA: 0x1AD72D0 Slot: 4
	public bool Equals(TimeZoneInfo.AdjustmentRule other) { }

	// RVA: 0x1AD76F0 Offset: 0x1AD77F1 VA: 0x1AD76F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1AD7700 Offset: 0x1AD7801 VA: 0x1AD7700
	private void .ctor() { }

	// RVA: 0x1AD7710 Offset: 0x1AD7811 VA: 0x1AD7710
	public static TimeZoneInfo.AdjustmentRule CreateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd) { }

	// RVA: 0x1AD7C20 Offset: 0x1AD7D21 VA: 0x1AD7C20
	internal static TimeZoneInfo.AdjustmentRule CreateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd, TimeSpan baseUtcOffsetDelta) { }

	// RVA: 0x1AD7830 Offset: 0x1AD7931 VA: 0x1AD7830
	private static void ValidateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd) { }

	// RVA: 0x1AD7C80 Offset: 0x1AD7D81 VA: 0x1AD7C80 Slot: 6
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x1AD7DC0 Offset: 0x1AD7EC1 VA: 0x1AD7DC0 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1AD7F70 Offset: 0x1AD8071 VA: 0x1AD7F70
	private void .ctor(SerializationInfo info, StreamingContext context) { }
}

