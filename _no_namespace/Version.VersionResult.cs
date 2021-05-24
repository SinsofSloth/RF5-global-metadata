internal struct Version.VersionResult // TypeDefIndex: 346
{
	// Fields
	internal Version m_parsedVersion; // 0x0
	internal Version.ParseFailureKind m_failure; // 0x8
	internal string m_exceptionArgument; // 0x10
	internal string m_argumentName; // 0x18
	internal bool m_canThrow; // 0x20

	// Methods

	// RVA: 0x1B6B0 Offset: 0x1B7B1 VA: 0x1B6B0
	internal void Init(string argumentName, bool canThrow) { }

	// RVA: 0x1B6C0 Offset: 0x1B7C1 VA: 0x1B6C0
	internal void SetFailure(Version.ParseFailureKind failure) { }

	// RVA: 0x1B780 Offset: 0x1B881 VA: 0x1B780
	internal void SetFailure(Version.ParseFailureKind failure, string argument) { }

	// RVA: 0x1B810 Offset: 0x1B911 VA: 0x1B810
	internal Exception GetVersionParseException() { }
}

