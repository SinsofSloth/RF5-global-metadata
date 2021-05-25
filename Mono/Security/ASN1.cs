[DefaultMemberAttribute] // RVA: 0xAB1F0 Offset: 0xAB2F1 VA: 0xAB1F0
internal class ASN1 // TypeDefIndex: 44
{
	// Fields
	private byte m_nTag; // 0x10
	private byte[] m_aValue; // 0x18
	private ArrayList elist; // 0x20

	// Properties
	public int Count { get; }
	public byte Tag { get; }
	public int Length { get; }
	public byte[] Value { get; set; }
	public ASN1 Item { get; }

	// Methods

	// RVA: 0x1940AE0 Offset: 0x1940BE1 VA: 0x1940AE0
	public void .ctor(byte tag) { }

	// RVA: 0x1940B20 Offset: 0x1940C21 VA: 0x1940B20
	public void .ctor(byte tag, byte[] data) { }

	// RVA: 0x1940B70 Offset: 0x1940C71 VA: 0x1940B70
	public void .ctor(byte[] data) { }

	// RVA: 0x1940ED0 Offset: 0x1940FD1 VA: 0x1940ED0
	public int get_Count() { }

	// RVA: 0x1940EF0 Offset: 0x1940FF1 VA: 0x1940EF0
	public byte get_Tag() { }

	// RVA: 0x1940F00 Offset: 0x1941001 VA: 0x1940F00
	public int get_Length() { }

	// RVA: 0x1940F20 Offset: 0x1941021 VA: 0x1940F20
	public byte[] get_Value() { }

	// RVA: 0x1940FC0 Offset: 0x19410C1 VA: 0x1940FC0
	public void set_Value(byte[] value) { }

	// RVA: 0x1941070 Offset: 0x1941171 VA: 0x1941070
	private bool CompareArray(byte[] array1, byte[] array2) { }

	// RVA: 0x1941100 Offset: 0x1941201 VA: 0x1941100
	public bool CompareValue(byte[] value) { }

	// RVA: 0x1941180 Offset: 0x1941281 VA: 0x1941180
	public ASN1 Add(ASN1 asn1) { }

	// RVA: 0x1941230 Offset: 0x1941331 VA: 0x1941230 Slot: 4
	public virtual byte[] GetBytes() { }

	// RVA: 0x1940D10 Offset: 0x1940E11 VA: 0x1940D10
	protected void Decode(byte[] asn1, ref int anPos, int anLength) { }

	// RVA: 0x19418E0 Offset: 0x19419E1 VA: 0x19418E0
	protected void DecodeTLV(byte[] asn1, ref int pos, out byte tag, out int length, out byte[] content) { }

	// RVA: 0x1941A30 Offset: 0x1941B31 VA: 0x1941A30
	public ASN1 get_Item(int index) { }

	// RVA: 0x1941BA0 Offset: 0x1941CA1 VA: 0x1941BA0
	public ASN1 Element(int index, byte anTag) { }

	// RVA: 0x1941D40 Offset: 0x1941E41 VA: 0x1941D40 Slot: 3
	public override string ToString() { }
}

[DefaultMemberAttribute] // RVA: 0xBABA0 Offset: 0xBACA1 VA: 0xBABA0
public class ASN1 // TypeDefIndex: 1548
{
	// Fields
	private byte m_nTag; // 0x10
	private byte[] m_aValue; // 0x18
	private ArrayList elist; // 0x20

	// Properties
	public int Count { get; }
	public byte Tag { get; }
	public int Length { get; }
	public byte[] Value { get; set; }
	public ASN1 Item { get; }

	// Methods

	// RVA: 0x1A64E40 Offset: 0x1A64F41 VA: 0x1A64E40
	public void .ctor(byte tag) { }

	// RVA: 0x1A64E80 Offset: 0x1A64F81 VA: 0x1A64E80
	public void .ctor(byte tag, byte[] data) { }

	// RVA: 0x1A64ED0 Offset: 0x1A64FD1 VA: 0x1A64ED0
	public void .ctor(byte[] data) { }

	// RVA: 0x1A65230 Offset: 0x1A65331 VA: 0x1A65230
	public int get_Count() { }

	// RVA: 0x1A65250 Offset: 0x1A65351 VA: 0x1A65250
	public byte get_Tag() { }

	// RVA: 0x1A65260 Offset: 0x1A65361 VA: 0x1A65260
	public int get_Length() { }

	// RVA: 0x1A65280 Offset: 0x1A65381 VA: 0x1A65280
	public byte[] get_Value() { }

	// RVA: 0x1A65320 Offset: 0x1A65421 VA: 0x1A65320
	public void set_Value(byte[] value) { }

	// RVA: 0x1A653D0 Offset: 0x1A654D1 VA: 0x1A653D0
	private bool CompareArray(byte[] array1, byte[] array2) { }

	// RVA: 0x1A65460 Offset: 0x1A65561 VA: 0x1A65460
	public bool CompareValue(byte[] value) { }

	// RVA: 0x1A654E0 Offset: 0x1A655E1 VA: 0x1A654E0
	public ASN1 Add(ASN1 asn1) { }

	// RVA: 0x1A65590 Offset: 0x1A65691 VA: 0x1A65590 Slot: 4
	public virtual byte[] GetBytes() { }

	// RVA: 0x1A65070 Offset: 0x1A65171 VA: 0x1A65070
	protected void Decode(byte[] asn1, ref int anPos, int anLength) { }

	// RVA: 0x1A65C40 Offset: 0x1A65D41 VA: 0x1A65C40
	protected void DecodeTLV(byte[] asn1, ref int pos, out byte tag, out int length, out byte[] content) { }

	// RVA: 0x1A65D90 Offset: 0x1A65E91 VA: 0x1A65D90
	public ASN1 get_Item(int index) { }

	// RVA: 0x1A65F00 Offset: 0x1A66001 VA: 0x1A65F00
	public ASN1 Element(int index, byte anTag) { }

	// RVA: 0x1A660A0 Offset: 0x1A661A1 VA: 0x1A660A0 Slot: 3
	public override string ToString() { }
}

