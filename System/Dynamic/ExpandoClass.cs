internal class ExpandoClass // TypeDefIndex: 2723
{
	// Fields
	private readonly string[] _keys; // 0x10
	private readonly int _hashCode; // 0x18
	private Dictionary<int, List<WeakReference>> _transitions; // 0x20
	internal static readonly ExpandoClass Empty; // 0x0

	// Properties
	internal string[] Keys { get; }

	// Methods

	// RVA: 0x169BEC0 Offset: 0x169BFC1 VA: 0x169BEC0
	internal void .ctor() { }

	// RVA: 0x169BFD0 Offset: 0x169C0D1 VA: 0x169BFD0
	internal void .ctor(string[] keys, int hashCode) { }

	// RVA: 0x169C020 Offset: 0x169C121 VA: 0x169C020
	internal ExpandoClass FindNewClass(string newKey) { }

	// RVA: 0x169C400 Offset: 0x169C501 VA: 0x169C400
	private List<WeakReference> GetTransitionList(int hashCode) { }

	// RVA: 0x169C510 Offset: 0x169C611 VA: 0x169C510
	internal int GetValueIndex(string name, bool caseInsensitive, ExpandoObject obj) { }

	// RVA: 0x169C7A0 Offset: 0x169C8A1 VA: 0x169C7A0
	internal int GetValueIndexCaseSensitive(string name) { }

	// RVA: 0x169C5C0 Offset: 0x169C6C1 VA: 0x169C5C0
	private int GetValueIndexCaseInsensitive(string name, ExpandoObject obj) { }

	// RVA: 0x169C900 Offset: 0x169CA01 VA: 0x169C900
	internal string[] get_Keys() { }

	// RVA: 0x169C910 Offset: 0x169CA11 VA: 0x169C910
	private static void .cctor() { }
}

