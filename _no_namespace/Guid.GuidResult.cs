private struct Guid.GuidResult // TypeDefIndex: 255
{
	// Fields
	internal Guid parsedGuid; // 0x0
	internal Guid.GuidParseThrowStyle throwStyle; // 0x10
	internal Guid.ParseFailureKind m_failure; // 0x14
	internal string m_failureMessageID; // 0x18
	internal object m_failureMessageFormatArgument; // 0x20
	internal string m_failureArgumentName; // 0x28
	internal Exception m_innerException; // 0x30

	// Methods

	// RVA: 0x15650 Offset: 0x15751 VA: 0x15650
	internal void Init(Guid.GuidParseThrowStyle canThrow) { }

	// RVA: 0x156D0 Offset: 0x157D1 VA: 0x156D0
	internal void SetFailure(Exception nativeException) { }

	// RVA: 0x156E0 Offset: 0x157E1 VA: 0x156E0
	internal void SetFailure(Guid.ParseFailureKind failure, string failureMessageID) { }

	// RVA: 0x15700 Offset: 0x15801 VA: 0x15700
	internal void SetFailure(Guid.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) { }

	// RVA: 0x15710 Offset: 0x15811 VA: 0x15710
	internal void SetFailure(Guid.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument, string failureArgumentName, Exception innerException) { }

	// RVA: 0x15720 Offset: 0x15821 VA: 0x15720
	internal Exception GetGuidParseException() { }
}

