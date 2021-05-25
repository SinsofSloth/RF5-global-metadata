internal sealed class RuntimeResourceSet : ResourceSet, IEnumerable // TypeDefIndex: 509
{
	// Fields
	internal const int Version = 2;
	private Dictionary<string, ResourceLocator> _resCache; // 0x28
	private ResourceReader _defaultReader; // 0x30
	private Dictionary<string, ResourceLocator> _caseInsensitiveTable; // 0x38
	private bool _haveReadFromReader; // 0x40

	// Methods

	// RVA: 0x17F4DB0 Offset: 0x17F4EB1 VA: 0x17F4DB0
	internal void .ctor(string fileName) { }

	// RVA: 0x17F6F80 Offset: 0x17F7081 VA: 0x17F6F80
	internal void .ctor(Stream stream) { }

	// RVA: 0x17FFB20 Offset: 0x17FFC21 VA: 0x17FFB20 Slot: 6
	protected override void Dispose(bool disposing) { }

	// RVA: 0x17FFC80 Offset: 0x17FFD81 VA: 0x17FFC80 Slot: 7
	public override IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x17FFDA0 Offset: 0x17FFEA1 VA: 0x17FFDA0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x17FFC90 Offset: 0x17FFD91 VA: 0x17FFC90
	private IDictionaryEnumerator GetEnumeratorHelper() { }

	// RVA: 0x17FFDB0 Offset: 0x17FFEB1 VA: 0x17FFDB0 Slot: 8
	public override string GetString(string key) { }

	// RVA: 0x18009D0 Offset: 0x1800AD1 VA: 0x18009D0 Slot: 9
	public override string GetString(string key, bool ignoreCase) { }

	// RVA: 0x1800A60 Offset: 0x1800B61 VA: 0x1800A60 Slot: 10
	public override object GetObject(string key) { }

	// RVA: 0x1800A70 Offset: 0x1800B71 VA: 0x1800A70 Slot: 11
	public override object GetObject(string key, bool ignoreCase) { }

	// RVA: 0x17FFE30 Offset: 0x17FFF31 VA: 0x17FFE30
	private object GetObject(string key, bool ignoreCase, bool isString) { }

	// RVA: 0x1800A80 Offset: 0x1800B81 VA: 0x1800A80
	private object ResolveResourceLocator(ResourceLocator resLocation, string key, Dictionary<string, ResourceLocator> copyOfCache, bool keyInWrongCase) { }
}

