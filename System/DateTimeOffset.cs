[Serializable]
public struct DateTimeOffset : IComparable, IFormattable, ISerializable, IDeserializationCallback, IComparable<DateTimeOffset>, IEquatable<DateTimeOffset> // TypeDefIndex: 209
{
	// Fields
	public static readonly DateTimeOffset MinValue; // 0x0
	public static readonly DateTimeOffset MaxValue; // 0x10
	private DateTime m_dateTime; // 0x0
	private short m_offsetMinutes; // 0x8

	// Properties
	public DateTime UtcDateTime { get; }
	private DateTime ClockDateTime { get; }
	public TimeSpan Offset { get; }
	public long Ticks { get; }
	public long UtcTicks { get; }

	// Methods

	// RVA: 0x373C80 Offset: 0x373D81 VA: 0x373C80
	public void .ctor(long ticks, TimeSpan offset) { }

	// RVA: 0x373C90 Offset: 0x373D91 VA: 0x373C90
	public DateTime get_UtcDateTime() { }

	// RVA: 0x373CA0 Offset: 0x373DA1 VA: 0x373CA0
	private DateTime get_ClockDateTime() { }

	// RVA: 0x373CB0 Offset: 0x373DB1 VA: 0x373CB0
	public TimeSpan get_Offset() { }

	// RVA: 0x373CF0 Offset: 0x373DF1 VA: 0x373CF0
	public long get_Ticks() { }

	// RVA: 0x373D10 Offset: 0x373E11 VA: 0x373D10
	public long get_UtcTicks() { }

	// RVA: 0x373D30 Offset: 0x373E31 VA: 0x373D30 Slot: 4
	private int System.IComparable.CompareTo(object obj) { }

	// RVA: 0x373D40 Offset: 0x373E41 VA: 0x373D40 Slot: 8
	public int CompareTo(DateTimeOffset other) { }

	// RVA: 0x373D50 Offset: 0x373E51 VA: 0x373D50 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x373D60 Offset: 0x373E61 VA: 0x373D60 Slot: 9
	public bool Equals(DateTimeOffset other) { }

	// RVA: 0x373DB0 Offset: 0x373EB1 VA: 0x373DB0 Slot: 7
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x373DC0 Offset: 0x373EC1 VA: 0x373DC0 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x373DD0 Offset: 0x373ED1 VA: 0x373DD0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x373DE0 Offset: 0x373EE1 VA: 0x373DE0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x373E00 Offset: 0x373F01 VA: 0x373E00 Slot: 3
	public override string ToString() { }

	// RVA: 0x373E10 Offset: 0x373F11 VA: 0x373E10 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x298B270 Offset: 0x298B371 VA: 0x298B270
	private static short ValidateOffset(TimeSpan offset) { }

	// RVA: 0x298B3A0 Offset: 0x298B4A1 VA: 0x298B3A0
	private static DateTime ValidateDate(DateTime dateTime, TimeSpan offset) { }

	// RVA: 0x298C150 Offset: 0x298C251 VA: 0x298C150
	private static void .cctor() { }
}

