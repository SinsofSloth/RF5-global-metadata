[ComVisibleAttribute] // RVA: 0xAEF20 Offset: 0xAF021 VA: 0xAEF20
[Serializable]
public class SortKey // TypeDefIndex: 736
{
	// Fields
	private readonly string source; // 0x10
	private readonly byte[] key; // 0x18
	private readonly CompareOptions options; // 0x20
	private readonly int lcid; // 0x24

	// Properties
	public virtual string OriginalString { get; }
	public virtual byte[] KeyData { get; }

	// Methods

	// RVA: 0x19C8740 Offset: 0x19C8841 VA: 0x19C8740
	public static int Compare(SortKey sortkey1, SortKey sortkey2) { }

	// RVA: 0x19C8910 Offset: 0x19C8A11 VA: 0x19C8910
	internal void .ctor(int lcid, string source, CompareOptions opt) { }

	// RVA: 0x19C8960 Offset: 0x19C8A61 VA: 0x19C8960
	internal void .ctor(int lcid, string source, byte[] buffer, CompareOptions opt, int lv1Length, int lv2Length, int lv3Length, int kanaSmallLength, int markTypeLength, int katakanaLength, int kanaWidthLength, int identLength) { }

	// RVA: 0x19C89D0 Offset: 0x19C8AD1 VA: 0x19C89D0 Slot: 4
	public virtual string get_OriginalString() { }

	// RVA: 0x19C89E0 Offset: 0x19C8AE1 VA: 0x19C89E0 Slot: 5
	public virtual byte[] get_KeyData() { }

	// RVA: 0x19C89F0 Offset: 0x19C8AF1 VA: 0x19C89F0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x19C8AC0 Offset: 0x19C8BC1 VA: 0x19C8AC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x19C8B90 Offset: 0x19C8C91 VA: 0x19C8B90 Slot: 3
	public override string ToString() { }

	// RVA: 0x19C8DF0 Offset: 0x19C8EF1 VA: 0x19C8DF0
	internal void .ctor() { }
}

