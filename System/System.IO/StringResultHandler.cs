internal class StringResultHandler : SearchResultHandler<string> // TypeDefIndex: 648
{
	// Fields
	private bool _includeFiles; // 0x10
	private bool _includeDirs; // 0x11

	// Methods

	// RVA: 0x18AA7F0 Offset: 0x18AA8F1 VA: 0x18AA7F0
	internal void .ctor(bool includeFiles, bool includeDirs) { }

	// RVA: 0x18B6050 Offset: 0x18B6151 VA: 0x18B6050 Slot: 4
	internal override bool IsResultIncluded(SearchResult result) { }

	// RVA: 0x18B60C0 Offset: 0x18B61C1 VA: 0x18B60C0 Slot: 5
	internal override string CreateObject(SearchResult result) { }
}

