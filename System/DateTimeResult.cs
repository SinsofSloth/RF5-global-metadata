internal struct DateTimeResult // TypeDefIndex: 248
{
	// Fields
	internal int Year; // 0x0
	internal int Month; // 0x4
	internal int Day; // 0x8
	internal int Hour; // 0xC
	internal int Minute; // 0x10
	internal int Second; // 0x14
	internal double fraction; // 0x18
	internal int era; // 0x20
	internal ParseFlags flags; // 0x24
	internal TimeSpan timeZoneOffset; // 0x28
	internal Calendar calendar; // 0x30
	internal DateTime parsedDate; // 0x38
	internal ParseFailureKind failure; // 0x40
	internal string failureMessageID; // 0x48
	internal object failureMessageFormatArgument; // 0x50
	internal string failureArgumentName; // 0x58

	// Methods

	// RVA: 0x13660 Offset: 0x13761 VA: 0x13660
	internal void Init() { }

	// RVA: 0x13680 Offset: 0x13781 VA: 0x13680
	internal void SetDate(int year, int month, int day) { }

	// RVA: 0x13690 Offset: 0x13791 VA: 0x13690
	internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) { }

	// RVA: 0x136D0 Offset: 0x137D1 VA: 0x136D0
	internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument, string failureArgumentName) { }
}

