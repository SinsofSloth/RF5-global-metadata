public struct TMP_LinkInfo // TypeDefIndex: 5891
{
	// Fields
	public TMP_Text textComponent; // 0x0
	public int hashCode; // 0x8
	public int linkIdFirstCharacterIndex; // 0xC
	public int linkIdLength; // 0x10
	public int linkTextfirstCharacterIndex; // 0x14
	public int linkTextLength; // 0x18
	internal char[] linkID; // 0x20

	// Methods

	// RVA: 0x31F0 Offset: 0x32F1 VA: 0x31F0
	internal void SetLinkID(char[] text, int startIndex, int length) { }

	// RVA: 0x3200 Offset: 0x3301 VA: 0x3200
	public string GetLinkText() { }

	// RVA: 0x3210 Offset: 0x3311 VA: 0x3210
	public string GetLinkID() { }
}

