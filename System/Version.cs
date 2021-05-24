[ComVisibleAttribute] // RVA: 0xACC50 Offset: 0xACD51 VA: 0xACC50
[Serializable]
public sealed class Version : ICloneable, IComparable, IComparable<Version>, IEquatable<Version> // TypeDefIndex: 344
{
	// Fields
	private int _Major; // 0x10
	private int _Minor; // 0x14
	private int _Build; // 0x18
	private int _Revision; // 0x1C
	private static readonly char[] SeparatorsArray; // 0x0
	private const int ZERO_CHAR_VALUE = 48;

	// Properties
	public int Major { get; }
	public int Minor { get; }
	public int Build { get; }
	public int Revision { get; }

	// Methods

	// RVA: 0x1AE68F0 Offset: 0x1AE69F1 VA: 0x1AE68F0
	public void .ctor(int major, int minor, int build, int revision) { }

	// RVA: 0x1AE6A70 Offset: 0x1AE6B71 VA: 0x1AE6A70
	public void .ctor(int major, int minor, int build) { }

	// RVA: 0x1AE6BC0 Offset: 0x1AE6CC1 VA: 0x1AE6BC0
	public void .ctor(int major, int minor) { }

	// RVA: 0x1AE6CC0 Offset: 0x1AE6DC1 VA: 0x1AE6CC0
	public void .ctor(string version) { }

	// RVA: 0x1AE6E80 Offset: 0x1AE6F81 VA: 0x1AE6E80
	public void .ctor() { }

	// RVA: 0x1AE6EB0 Offset: 0x1AE6FB1 VA: 0x1AE6EB0
	public int get_Major() { }

	// RVA: 0x1AE6EC0 Offset: 0x1AE6FC1 VA: 0x1AE6EC0
	public int get_Minor() { }

	// RVA: 0x1AE6ED0 Offset: 0x1AE6FD1 VA: 0x1AE6ED0
	public int get_Build() { }

	// RVA: 0x1AE6EE0 Offset: 0x1AE6FE1 VA: 0x1AE6EE0
	public int get_Revision() { }

	// RVA: 0x1AE6EF0 Offset: 0x1AE6FF1 VA: 0x1AE6EF0 Slot: 4
	public object Clone() { }

	// RVA: 0x1AE6F90 Offset: 0x1AE7091 VA: 0x1AE6F90 Slot: 5
	public int CompareTo(object version) { }

	// RVA: 0x1AE7140 Offset: 0x1AE7241 VA: 0x1AE7140 Slot: 6
	public int CompareTo(Version value) { }

	// RVA: 0x1AE7270 Offset: 0x1AE7371 VA: 0x1AE7270 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1AE73A0 Offset: 0x1AE74A1 VA: 0x1AE73A0 Slot: 7
	public bool Equals(Version obj) { }

	// RVA: 0x1AE74C0 Offset: 0x1AE75C1 VA: 0x1AE74C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1AE74E0 Offset: 0x1AE75E1 VA: 0x1AE74E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1AE7510 Offset: 0x1AE7611 VA: 0x1AE7510
	public string ToString(int fieldCount) { }

	// RVA: 0x1AE7B20 Offset: 0x1AE7C21 VA: 0x1AE7B20
	private static void AppendPositiveNumber(int num, StringBuilder sb) { }

	// RVA: 0x1AE6D70 Offset: 0x1AE6E71 VA: 0x1AE6D70
	public static Version Parse(string input) { }

	// RVA: 0x1AE7BC0 Offset: 0x1AE7CC1 VA: 0x1AE7BC0
	private static bool TryParseVersion(string version, ref Version.VersionResult result) { }

	// RVA: 0x1AE8260 Offset: 0x1AE8361 VA: 0x1AE8260
	private static bool TryParseComponent(string component, string componentName, ref Version.VersionResult result, out int parsedComponent) { }

	// RVA: 0x1AE7120 Offset: 0x1AE7221 VA: 0x1AE7120
	public static bool op_Equality(Version v1, Version v2) { }

	// RVA: 0x1AE8450 Offset: 0x1AE8551 VA: 0x1AE8450
	public static bool op_Inequality(Version v1, Version v2) { }

	// RVA: 0x1AE84F0 Offset: 0x1AE85F1 VA: 0x1AE84F0
	public static bool op_LessThan(Version v1, Version v2) { }

	// RVA: 0x1AE8590 Offset: 0x1AE8691 VA: 0x1AE8590
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xACC50 Offset: 0xACD51 VA: 0xACC50
[Serializable]
public sealed class Version : ICloneable, IComparable, IComparable<Version>, IEquatable<Version> // TypeDefIndex: 344
{
	// Fields
	private int _Major; // 0x10
	private int _Minor; // 0x14
	private int _Build; // 0x18
	private int _Revision; // 0x1C
	private static readonly char[] SeparatorsArray; // 0x0
	private const int ZERO_CHAR_VALUE = 48;

	// Properties
	public int Major { get; }
	public int Minor { get; }
	public int Build { get; }
	public int Revision { get; }

	// Methods

	// RVA: 0x1AE68F0 Offset: 0x1AE69F1 VA: 0x1AE68F0
	public void .ctor(int major, int minor, int build, int revision) { }

	// RVA: 0x1AE6A70 Offset: 0x1AE6B71 VA: 0x1AE6A70
	public void .ctor(int major, int minor, int build) { }

	// RVA: 0x1AE6BC0 Offset: 0x1AE6CC1 VA: 0x1AE6BC0
	public void .ctor(int major, int minor) { }

	// RVA: 0x1AE6CC0 Offset: 0x1AE6DC1 VA: 0x1AE6CC0
	public void .ctor(string version) { }

	// RVA: 0x1AE6E80 Offset: 0x1AE6F81 VA: 0x1AE6E80
	public void .ctor() { }

	// RVA: 0x1AE6EB0 Offset: 0x1AE6FB1 VA: 0x1AE6EB0
	public int get_Major() { }

	// RVA: 0x1AE6EC0 Offset: 0x1AE6FC1 VA: 0x1AE6EC0
	public int get_Minor() { }

	// RVA: 0x1AE6ED0 Offset: 0x1AE6FD1 VA: 0x1AE6ED0
	public int get_Build() { }

	// RVA: 0x1AE6EE0 Offset: 0x1AE6FE1 VA: 0x1AE6EE0
	public int get_Revision() { }

	// RVA: 0x1AE6EF0 Offset: 0x1AE6FF1 VA: 0x1AE6EF0 Slot: 4
	public object Clone() { }

	// RVA: 0x1AE6F90 Offset: 0x1AE7091 VA: 0x1AE6F90 Slot: 5
	public int CompareTo(object version) { }

	// RVA: 0x1AE7140 Offset: 0x1AE7241 VA: 0x1AE7140 Slot: 6
	public int CompareTo(Version value) { }

	// RVA: 0x1AE7270 Offset: 0x1AE7371 VA: 0x1AE7270 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1AE73A0 Offset: 0x1AE74A1 VA: 0x1AE73A0 Slot: 7
	public bool Equals(Version obj) { }

	// RVA: 0x1AE74C0 Offset: 0x1AE75C1 VA: 0x1AE74C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1AE74E0 Offset: 0x1AE75E1 VA: 0x1AE74E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1AE7510 Offset: 0x1AE7611 VA: 0x1AE7510
	public string ToString(int fieldCount) { }

	// RVA: 0x1AE7B20 Offset: 0x1AE7C21 VA: 0x1AE7B20
	private static void AppendPositiveNumber(int num, StringBuilder sb) { }

	// RVA: 0x1AE6D70 Offset: 0x1AE6E71 VA: 0x1AE6D70
	public static Version Parse(string input) { }

	// RVA: 0x1AE7BC0 Offset: 0x1AE7CC1 VA: 0x1AE7BC0
	private static bool TryParseVersion(string version, ref Version.VersionResult result) { }

	// RVA: 0x1AE8260 Offset: 0x1AE8361 VA: 0x1AE8260
	private static bool TryParseComponent(string component, string componentName, ref Version.VersionResult result, out int parsedComponent) { }

	// RVA: 0x1AE7120 Offset: 0x1AE7221 VA: 0x1AE7120
	public static bool op_Equality(Version v1, Version v2) { }

	// RVA: 0x1AE8450 Offset: 0x1AE8551 VA: 0x1AE8450
	public static bool op_Inequality(Version v1, Version v2) { }

	// RVA: 0x1AE84F0 Offset: 0x1AE85F1 VA: 0x1AE84F0
	public static bool op_LessThan(Version v1, Version v2) { }

	// RVA: 0x1AE8590 Offset: 0x1AE8691 VA: 0x1AE8590
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xACC50 Offset: 0xACD51 VA: 0xACC50
[Serializable]
public sealed class Version : ICloneable, IComparable, IComparable<Version>, IEquatable<Version> // TypeDefIndex: 344
{
	// Fields
	private int _Major; // 0x10
	private int _Minor; // 0x14
	private int _Build; // 0x18
	private int _Revision; // 0x1C
	private static readonly char[] SeparatorsArray; // 0x0
	private const int ZERO_CHAR_VALUE = 48;

	// Properties
	public int Major { get; }
	public int Minor { get; }
	public int Build { get; }
	public int Revision { get; }

	// Methods

	// RVA: 0x1AE68F0 Offset: 0x1AE69F1 VA: 0x1AE68F0
	public void .ctor(int major, int minor, int build, int revision) { }

	// RVA: 0x1AE6A70 Offset: 0x1AE6B71 VA: 0x1AE6A70
	public void .ctor(int major, int minor, int build) { }

	// RVA: 0x1AE6BC0 Offset: 0x1AE6CC1 VA: 0x1AE6BC0
	public void .ctor(int major, int minor) { }

	// RVA: 0x1AE6CC0 Offset: 0x1AE6DC1 VA: 0x1AE6CC0
	public void .ctor(string version) { }

	// RVA: 0x1AE6E80 Offset: 0x1AE6F81 VA: 0x1AE6E80
	public void .ctor() { }

	// RVA: 0x1AE6EB0 Offset: 0x1AE6FB1 VA: 0x1AE6EB0
	public int get_Major() { }

	// RVA: 0x1AE6EC0 Offset: 0x1AE6FC1 VA: 0x1AE6EC0
	public int get_Minor() { }

	// RVA: 0x1AE6ED0 Offset: 0x1AE6FD1 VA: 0x1AE6ED0
	public int get_Build() { }

	// RVA: 0x1AE6EE0 Offset: 0x1AE6FE1 VA: 0x1AE6EE0
	public int get_Revision() { }

	// RVA: 0x1AE6EF0 Offset: 0x1AE6FF1 VA: 0x1AE6EF0 Slot: 4
	public object Clone() { }

	// RVA: 0x1AE6F90 Offset: 0x1AE7091 VA: 0x1AE6F90 Slot: 5
	public int CompareTo(object version) { }

	// RVA: 0x1AE7140 Offset: 0x1AE7241 VA: 0x1AE7140 Slot: 6
	public int CompareTo(Version value) { }

	// RVA: 0x1AE7270 Offset: 0x1AE7371 VA: 0x1AE7270 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1AE73A0 Offset: 0x1AE74A1 VA: 0x1AE73A0 Slot: 7
	public bool Equals(Version obj) { }

	// RVA: 0x1AE74C0 Offset: 0x1AE75C1 VA: 0x1AE74C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1AE74E0 Offset: 0x1AE75E1 VA: 0x1AE74E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1AE7510 Offset: 0x1AE7611 VA: 0x1AE7510
	public string ToString(int fieldCount) { }

	// RVA: 0x1AE7B20 Offset: 0x1AE7C21 VA: 0x1AE7B20
	private static void AppendPositiveNumber(int num, StringBuilder sb) { }

	// RVA: 0x1AE6D70 Offset: 0x1AE6E71 VA: 0x1AE6D70
	public static Version Parse(string input) { }

	// RVA: 0x1AE7BC0 Offset: 0x1AE7CC1 VA: 0x1AE7BC0
	private static bool TryParseVersion(string version, ref Version.VersionResult result) { }

	// RVA: 0x1AE8260 Offset: 0x1AE8361 VA: 0x1AE8260
	private static bool TryParseComponent(string component, string componentName, ref Version.VersionResult result, out int parsedComponent) { }

	// RVA: 0x1AE7120 Offset: 0x1AE7221 VA: 0x1AE7120
	public static bool op_Equality(Version v1, Version v2) { }

	// RVA: 0x1AE8450 Offset: 0x1AE8551 VA: 0x1AE8450
	public static bool op_Inequality(Version v1, Version v2) { }

	// RVA: 0x1AE84F0 Offset: 0x1AE85F1 VA: 0x1AE84F0
	public static bool op_LessThan(Version v1, Version v2) { }

	// RVA: 0x1AE8590 Offset: 0x1AE8691 VA: 0x1AE8590
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xACC50 Offset: 0xACD51 VA: 0xACC50
[Serializable]
public sealed class Version : ICloneable, IComparable, IComparable<Version>, IEquatable<Version> // TypeDefIndex: 344
{
	// Fields
	private int _Major; // 0x10
	private int _Minor; // 0x14
	private int _Build; // 0x18
	private int _Revision; // 0x1C
	private static readonly char[] SeparatorsArray; // 0x0
	private const int ZERO_CHAR_VALUE = 48;

	// Properties
	public int Major { get; }
	public int Minor { get; }
	public int Build { get; }
	public int Revision { get; }

	// Methods

	// RVA: 0x1AE68F0 Offset: 0x1AE69F1 VA: 0x1AE68F0
	public void .ctor(int major, int minor, int build, int revision) { }

	// RVA: 0x1AE6A70 Offset: 0x1AE6B71 VA: 0x1AE6A70
	public void .ctor(int major, int minor, int build) { }

	// RVA: 0x1AE6BC0 Offset: 0x1AE6CC1 VA: 0x1AE6BC0
	public void .ctor(int major, int minor) { }

	// RVA: 0x1AE6CC0 Offset: 0x1AE6DC1 VA: 0x1AE6CC0
	public void .ctor(string version) { }

	// RVA: 0x1AE6E80 Offset: 0x1AE6F81 VA: 0x1AE6E80
	public void .ctor() { }

	// RVA: 0x1AE6EB0 Offset: 0x1AE6FB1 VA: 0x1AE6EB0
	public int get_Major() { }

	// RVA: 0x1AE6EC0 Offset: 0x1AE6FC1 VA: 0x1AE6EC0
	public int get_Minor() { }

	// RVA: 0x1AE6ED0 Offset: 0x1AE6FD1 VA: 0x1AE6ED0
	public int get_Build() { }

	// RVA: 0x1AE6EE0 Offset: 0x1AE6FE1 VA: 0x1AE6EE0
	public int get_Revision() { }

	// RVA: 0x1AE6EF0 Offset: 0x1AE6FF1 VA: 0x1AE6EF0 Slot: 4
	public object Clone() { }

	// RVA: 0x1AE6F90 Offset: 0x1AE7091 VA: 0x1AE6F90 Slot: 5
	public int CompareTo(object version) { }

	// RVA: 0x1AE7140 Offset: 0x1AE7241 VA: 0x1AE7140 Slot: 6
	public int CompareTo(Version value) { }

	// RVA: 0x1AE7270 Offset: 0x1AE7371 VA: 0x1AE7270 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1AE73A0 Offset: 0x1AE74A1 VA: 0x1AE73A0 Slot: 7
	public bool Equals(Version obj) { }

	// RVA: 0x1AE74C0 Offset: 0x1AE75C1 VA: 0x1AE74C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1AE74E0 Offset: 0x1AE75E1 VA: 0x1AE74E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1AE7510 Offset: 0x1AE7611 VA: 0x1AE7510
	public string ToString(int fieldCount) { }

	// RVA: 0x1AE7B20 Offset: 0x1AE7C21 VA: 0x1AE7B20
	private static void AppendPositiveNumber(int num, StringBuilder sb) { }

	// RVA: 0x1AE6D70 Offset: 0x1AE6E71 VA: 0x1AE6D70
	public static Version Parse(string input) { }

	// RVA: 0x1AE7BC0 Offset: 0x1AE7CC1 VA: 0x1AE7BC0
	private static bool TryParseVersion(string version, ref Version.VersionResult result) { }

	// RVA: 0x1AE8260 Offset: 0x1AE8361 VA: 0x1AE8260
	private static bool TryParseComponent(string component, string componentName, ref Version.VersionResult result, out int parsedComponent) { }

	// RVA: 0x1AE7120 Offset: 0x1AE7221 VA: 0x1AE7120
	public static bool op_Equality(Version v1, Version v2) { }

	// RVA: 0x1AE8450 Offset: 0x1AE8551 VA: 0x1AE8450
	public static bool op_Inequality(Version v1, Version v2) { }

	// RVA: 0x1AE84F0 Offset: 0x1AE85F1 VA: 0x1AE84F0
	public static bool op_LessThan(Version v1, Version v2) { }

	// RVA: 0x1AE8590 Offset: 0x1AE8691 VA: 0x1AE8590
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xACC50 Offset: 0xACD51 VA: 0xACC50
[Serializable]
public sealed class Version : ICloneable, IComparable, IComparable<Version>, IEquatable<Version> // TypeDefIndex: 344
{
	// Fields
	private int _Major; // 0x10
	private int _Minor; // 0x14
	private int _Build; // 0x18
	private int _Revision; // 0x1C
	private static readonly char[] SeparatorsArray; // 0x0
	private const int ZERO_CHAR_VALUE = 48;

	// Properties
	public int Major { get; }
	public int Minor { get; }
	public int Build { get; }
	public int Revision { get; }

	// Methods

	// RVA: 0x1AE68F0 Offset: 0x1AE69F1 VA: 0x1AE68F0
	public void .ctor(int major, int minor, int build, int revision) { }

	// RVA: 0x1AE6A70 Offset: 0x1AE6B71 VA: 0x1AE6A70
	public void .ctor(int major, int minor, int build) { }

	// RVA: 0x1AE6BC0 Offset: 0x1AE6CC1 VA: 0x1AE6BC0
	public void .ctor(int major, int minor) { }

	// RVA: 0x1AE6CC0 Offset: 0x1AE6DC1 VA: 0x1AE6CC0
	public void .ctor(string version) { }

	// RVA: 0x1AE6E80 Offset: 0x1AE6F81 VA: 0x1AE6E80
	public void .ctor() { }

	// RVA: 0x1AE6EB0 Offset: 0x1AE6FB1 VA: 0x1AE6EB0
	public int get_Major() { }

	// RVA: 0x1AE6EC0 Offset: 0x1AE6FC1 VA: 0x1AE6EC0
	public int get_Minor() { }

	// RVA: 0x1AE6ED0 Offset: 0x1AE6FD1 VA: 0x1AE6ED0
	public int get_Build() { }

	// RVA: 0x1AE6EE0 Offset: 0x1AE6FE1 VA: 0x1AE6EE0
	public int get_Revision() { }

	// RVA: 0x1AE6EF0 Offset: 0x1AE6FF1 VA: 0x1AE6EF0 Slot: 4
	public object Clone() { }

	// RVA: 0x1AE6F90 Offset: 0x1AE7091 VA: 0x1AE6F90 Slot: 5
	public int CompareTo(object version) { }

	// RVA: 0x1AE7140 Offset: 0x1AE7241 VA: 0x1AE7140 Slot: 6
	public int CompareTo(Version value) { }

	// RVA: 0x1AE7270 Offset: 0x1AE7371 VA: 0x1AE7270 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1AE73A0 Offset: 0x1AE74A1 VA: 0x1AE73A0 Slot: 7
	public bool Equals(Version obj) { }

	// RVA: 0x1AE74C0 Offset: 0x1AE75C1 VA: 0x1AE74C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1AE74E0 Offset: 0x1AE75E1 VA: 0x1AE74E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1AE7510 Offset: 0x1AE7611 VA: 0x1AE7510
	public string ToString(int fieldCount) { }

	// RVA: 0x1AE7B20 Offset: 0x1AE7C21 VA: 0x1AE7B20
	private static void AppendPositiveNumber(int num, StringBuilder sb) { }

	// RVA: 0x1AE6D70 Offset: 0x1AE6E71 VA: 0x1AE6D70
	public static Version Parse(string input) { }

	// RVA: 0x1AE7BC0 Offset: 0x1AE7CC1 VA: 0x1AE7BC0
	private static bool TryParseVersion(string version, ref Version.VersionResult result) { }

	// RVA: 0x1AE8260 Offset: 0x1AE8361 VA: 0x1AE8260
	private static bool TryParseComponent(string component, string componentName, ref Version.VersionResult result, out int parsedComponent) { }

	// RVA: 0x1AE7120 Offset: 0x1AE7221 VA: 0x1AE7120
	public static bool op_Equality(Version v1, Version v2) { }

	// RVA: 0x1AE8450 Offset: 0x1AE8551 VA: 0x1AE8450
	public static bool op_Inequality(Version v1, Version v2) { }

	// RVA: 0x1AE84F0 Offset: 0x1AE85F1 VA: 0x1AE84F0
	public static bool op_LessThan(Version v1, Version v2) { }

	// RVA: 0x1AE8590 Offset: 0x1AE8691 VA: 0x1AE8590
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xACC50 Offset: 0xACD51 VA: 0xACC50
[Serializable]
public sealed class Version : ICloneable, IComparable, IComparable<Version>, IEquatable<Version> // TypeDefIndex: 344
{
	// Fields
	private int _Major; // 0x10
	private int _Minor; // 0x14
	private int _Build; // 0x18
	private int _Revision; // 0x1C
	private static readonly char[] SeparatorsArray; // 0x0
	private const int ZERO_CHAR_VALUE = 48;

	// Properties
	public int Major { get; }
	public int Minor { get; }
	public int Build { get; }
	public int Revision { get; }

	// Methods

	// RVA: 0x1AE68F0 Offset: 0x1AE69F1 VA: 0x1AE68F0
	public void .ctor(int major, int minor, int build, int revision) { }

	// RVA: 0x1AE6A70 Offset: 0x1AE6B71 VA: 0x1AE6A70
	public void .ctor(int major, int minor, int build) { }

	// RVA: 0x1AE6BC0 Offset: 0x1AE6CC1 VA: 0x1AE6BC0
	public void .ctor(int major, int minor) { }

	// RVA: 0x1AE6CC0 Offset: 0x1AE6DC1 VA: 0x1AE6CC0
	public void .ctor(string version) { }

	// RVA: 0x1AE6E80 Offset: 0x1AE6F81 VA: 0x1AE6E80
	public void .ctor() { }

	// RVA: 0x1AE6EB0 Offset: 0x1AE6FB1 VA: 0x1AE6EB0
	public int get_Major() { }

	// RVA: 0x1AE6EC0 Offset: 0x1AE6FC1 VA: 0x1AE6EC0
	public int get_Minor() { }

	// RVA: 0x1AE6ED0 Offset: 0x1AE6FD1 VA: 0x1AE6ED0
	public int get_Build() { }

	// RVA: 0x1AE6EE0 Offset: 0x1AE6FE1 VA: 0x1AE6EE0
	public int get_Revision() { }

	// RVA: 0x1AE6EF0 Offset: 0x1AE6FF1 VA: 0x1AE6EF0 Slot: 4
	public object Clone() { }

	// RVA: 0x1AE6F90 Offset: 0x1AE7091 VA: 0x1AE6F90 Slot: 5
	public int CompareTo(object version) { }

	// RVA: 0x1AE7140 Offset: 0x1AE7241 VA: 0x1AE7140 Slot: 6
	public int CompareTo(Version value) { }

	// RVA: 0x1AE7270 Offset: 0x1AE7371 VA: 0x1AE7270 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1AE73A0 Offset: 0x1AE74A1 VA: 0x1AE73A0 Slot: 7
	public bool Equals(Version obj) { }

	// RVA: 0x1AE74C0 Offset: 0x1AE75C1 VA: 0x1AE74C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1AE74E0 Offset: 0x1AE75E1 VA: 0x1AE74E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1AE7510 Offset: 0x1AE7611 VA: 0x1AE7510
	public string ToString(int fieldCount) { }

	// RVA: 0x1AE7B20 Offset: 0x1AE7C21 VA: 0x1AE7B20
	private static void AppendPositiveNumber(int num, StringBuilder sb) { }

	// RVA: 0x1AE6D70 Offset: 0x1AE6E71 VA: 0x1AE6D70
	public static Version Parse(string input) { }

	// RVA: 0x1AE7BC0 Offset: 0x1AE7CC1 VA: 0x1AE7BC0
	private static bool TryParseVersion(string version, ref Version.VersionResult result) { }

	// RVA: 0x1AE8260 Offset: 0x1AE8361 VA: 0x1AE8260
	private static bool TryParseComponent(string component, string componentName, ref Version.VersionResult result, out int parsedComponent) { }

	// RVA: 0x1AE7120 Offset: 0x1AE7221 VA: 0x1AE7120
	public static bool op_Equality(Version v1, Version v2) { }

	// RVA: 0x1AE8450 Offset: 0x1AE8551 VA: 0x1AE8450
	public static bool op_Inequality(Version v1, Version v2) { }

	// RVA: 0x1AE84F0 Offset: 0x1AE85F1 VA: 0x1AE84F0
	public static bool op_LessThan(Version v1, Version v2) { }

	// RVA: 0x1AE8590 Offset: 0x1AE8691 VA: 0x1AE8590
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xACC50 Offset: 0xACD51 VA: 0xACC50
[Serializable]
public sealed class Version : ICloneable, IComparable, IComparable<Version>, IEquatable<Version> // TypeDefIndex: 344
{
	// Fields
	private int _Major; // 0x10
	private int _Minor; // 0x14
	private int _Build; // 0x18
	private int _Revision; // 0x1C
	private static readonly char[] SeparatorsArray; // 0x0
	private const int ZERO_CHAR_VALUE = 48;

	// Properties
	public int Major { get; }
	public int Minor { get; }
	public int Build { get; }
	public int Revision { get; }

	// Methods

	// RVA: 0x1AE68F0 Offset: 0x1AE69F1 VA: 0x1AE68F0
	public void .ctor(int major, int minor, int build, int revision) { }

	// RVA: 0x1AE6A70 Offset: 0x1AE6B71 VA: 0x1AE6A70
	public void .ctor(int major, int minor, int build) { }

	// RVA: 0x1AE6BC0 Offset: 0x1AE6CC1 VA: 0x1AE6BC0
	public void .ctor(int major, int minor) { }

	// RVA: 0x1AE6CC0 Offset: 0x1AE6DC1 VA: 0x1AE6CC0
	public void .ctor(string version) { }

	// RVA: 0x1AE6E80 Offset: 0x1AE6F81 VA: 0x1AE6E80
	public void .ctor() { }

	// RVA: 0x1AE6EB0 Offset: 0x1AE6FB1 VA: 0x1AE6EB0
	public int get_Major() { }

	// RVA: 0x1AE6EC0 Offset: 0x1AE6FC1 VA: 0x1AE6EC0
	public int get_Minor() { }

	// RVA: 0x1AE6ED0 Offset: 0x1AE6FD1 VA: 0x1AE6ED0
	public int get_Build() { }

	// RVA: 0x1AE6EE0 Offset: 0x1AE6FE1 VA: 0x1AE6EE0
	public int get_Revision() { }

	// RVA: 0x1AE6EF0 Offset: 0x1AE6FF1 VA: 0x1AE6EF0 Slot: 4
	public object Clone() { }

	// RVA: 0x1AE6F90 Offset: 0x1AE7091 VA: 0x1AE6F90 Slot: 5
	public int CompareTo(object version) { }

	// RVA: 0x1AE7140 Offset: 0x1AE7241 VA: 0x1AE7140 Slot: 6
	public int CompareTo(Version value) { }

	// RVA: 0x1AE7270 Offset: 0x1AE7371 VA: 0x1AE7270 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1AE73A0 Offset: 0x1AE74A1 VA: 0x1AE73A0 Slot: 7
	public bool Equals(Version obj) { }

	// RVA: 0x1AE74C0 Offset: 0x1AE75C1 VA: 0x1AE74C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1AE74E0 Offset: 0x1AE75E1 VA: 0x1AE74E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1AE7510 Offset: 0x1AE7611 VA: 0x1AE7510
	public string ToString(int fieldCount) { }

	// RVA: 0x1AE7B20 Offset: 0x1AE7C21 VA: 0x1AE7B20
	private static void AppendPositiveNumber(int num, StringBuilder sb) { }

	// RVA: 0x1AE6D70 Offset: 0x1AE6E71 VA: 0x1AE6D70
	public static Version Parse(string input) { }

	// RVA: 0x1AE7BC0 Offset: 0x1AE7CC1 VA: 0x1AE7BC0
	private static bool TryParseVersion(string version, ref Version.VersionResult result) { }

	// RVA: 0x1AE8260 Offset: 0x1AE8361 VA: 0x1AE8260
	private static bool TryParseComponent(string component, string componentName, ref Version.VersionResult result, out int parsedComponent) { }

	// RVA: 0x1AE7120 Offset: 0x1AE7221 VA: 0x1AE7120
	public static bool op_Equality(Version v1, Version v2) { }

	// RVA: 0x1AE8450 Offset: 0x1AE8551 VA: 0x1AE8450
	public static bool op_Inequality(Version v1, Version v2) { }

	// RVA: 0x1AE84F0 Offset: 0x1AE85F1 VA: 0x1AE84F0
	public static bool op_LessThan(Version v1, Version v2) { }

	// RVA: 0x1AE8590 Offset: 0x1AE8691 VA: 0x1AE8590
	private static void .cctor() { }
}

