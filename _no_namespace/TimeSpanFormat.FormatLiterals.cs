internal struct TimeSpanFormat.FormatLiterals // TypeDefIndex: 734
{
	// Fields
	internal string AppCompatLiteral; // 0x0
	internal int dd; // 0x8
	internal int hh; // 0xC
	internal int mm; // 0x10
	internal int ss; // 0x14
	internal int ff; // 0x18
	private string[] literals; // 0x20

	// Properties
	internal string Start { get; }
	internal string DayHourSep { get; }
	internal string HourMinuteSep { get; }
	internal string MinuteSecondSep { get; }
	internal string SecondFractionSep { get; }
	internal string End { get; }

	// Methods

	// RVA: 0x15210 Offset: 0x15311 VA: 0x15210
	internal string get_Start() { }

	// RVA: 0x15250 Offset: 0x15351 VA: 0x15250
	internal string get_DayHourSep() { }

	// RVA: 0x15290 Offset: 0x15391 VA: 0x15290
	internal string get_HourMinuteSep() { }

	// RVA: 0x152D0 Offset: 0x153D1 VA: 0x152D0
	internal string get_MinuteSecondSep() { }

	// RVA: 0x15310 Offset: 0x15411 VA: 0x15310
	internal string get_SecondFractionSep() { }

	// RVA: 0x15350 Offset: 0x15451 VA: 0x15350
	internal string get_End() { }

	// RVA: 0x19CD1F0 Offset: 0x19CD2F1 VA: 0x19CD1F0
	internal static TimeSpanFormat.FormatLiterals InitInvariant(bool isNegative) { }

	// RVA: 0x15390 Offset: 0x15491 VA: 0x15390
	internal void Init(string format, bool useInvariantFieldLengths) { }
}

