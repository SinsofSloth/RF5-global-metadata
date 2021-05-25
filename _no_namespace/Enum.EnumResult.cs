private struct Enum.EnumResult // TypeDefIndex: 223
{
	// Fields
	internal object parsedEnum; // 0x0
	internal bool canThrow; // 0x8
	internal Enum.ParseFailureKind m_failure; // 0xC
	internal string m_failureMessageID; // 0x10
	internal string m_failureParameter; // 0x18
	internal object m_failureMessageFormatArgument; // 0x20
	internal Exception m_innerException; // 0x28

	// Methods

	// RVA: 0x9CE0 Offset: 0x9DE1 VA: 0x9CE0
	internal void Init(bool canMethodThrow) { }

	// RVA: 0x9D70 Offset: 0x9E71 VA: 0x9D70
	internal void SetFailure(Exception unhandledException) { }

	// RVA: 0x9D80 Offset: 0x9E81 VA: 0x9D80
	internal void SetFailure(Enum.ParseFailureKind failure, string failureParameter) { }

	// RVA: 0x9E10 Offset: 0x9F11 VA: 0x9E10
	internal void SetFailure(Enum.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) { }

	// RVA: 0x9EC0 Offset: 0x9FC1 VA: 0x9EC0
	internal Exception GetEnumParseException() { }
}

