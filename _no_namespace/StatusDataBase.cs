[UnionAttribute] // RVA: 0x146C70 Offset: 0x146D71 VA: 0x146C70
[UnionAttribute] // RVA: 0x146C70 Offset: 0x146D71 VA: 0x146C70
[UnionAttribute] // RVA: 0x146C70 Offset: 0x146D71 VA: 0x146C70
[MessagePackObjectAttribute] // RVA: 0x146C70 Offset: 0x146D71 VA: 0x146C70
public abstract class StatusDataBase // TypeDefIndex: 8230
{
	// Fields
	[KeyAttribute] // RVA: 0x16D860 Offset: 0x16D961 VA: 0x16D860
	public int Level; // 0x10
	[KeyAttribute] // RVA: 0x16D880 Offset: 0x16D981 VA: 0x16D880
	public int Exp; // 0x14
	[KeyAttribute] // RVA: 0x16D8A0 Offset: 0x16D9A1 VA: 0x16D8A0
	public int Hp; // 0x18
	[KeyAttribute] // RVA: 0x16D8C0 Offset: 0x16D9C1 VA: 0x16D8C0
	public int Rp; // 0x1C
	[KeyAttribute] // RVA: 0x16D8E0 Offset: 0x16D9E1 VA: 0x16D8E0
	public Parameter SaveParameter; // 0x20
	[KeyAttribute] // RVA: 0x16D900 Offset: 0x16DA01 VA: 0x16D900
	public BadStatus BadStatus; // 0xDC
	[KeyAttribute] // RVA: 0x16D920 Offset: 0x16DA21 VA: 0x16D920
	public ItemData TemporaryStatus_UseItem; // 0xE0
	[KeyAttribute] // RVA: 0x16D940 Offset: 0x16DA41 VA: 0x16D940
	public int TemporaryStatus_UseItem_Time; // 0xE8
	[KeyAttribute] // RVA: 0x16D960 Offset: 0x16DA61 VA: 0x16D960
	public HotSpringID TemporaryStatus_HotSpring; // 0xEC
	[KeyAttribute] // RVA: 0x16D980 Offset: 0x16DA81 VA: 0x16D980
	public int TemporaryStatus_HotSpring_Time; // 0xF0
	[KeyAttribute] // RVA: 0x16D9A0 Offset: 0x16DAA1 VA: 0x16D9A0
	public VaccinationID TemporaryStatus_Vaccination; // 0xF4
	[KeyAttribute] // RVA: 0x16D9C0 Offset: 0x16DAC1 VA: 0x16D9C0
	public int TemporaryStatus_Vaccination_Time; // 0xF8
	[KeyAttribute] // RVA: 0x16D9E0 Offset: 0x16DAE1 VA: 0x16D9E0
	public int Score_ATKUp_Level; // 0xFC
	[KeyAttribute] // RVA: 0x16DA00 Offset: 0x16DB01 VA: 0x16DA00
	public int Score_ATKUp_Time; // 0x100
	[KeyAttribute] // RVA: 0x16DA20 Offset: 0x16DB21 VA: 0x16DA20
	public int Score_DEFUp_Level; // 0x104
	[KeyAttribute] // RVA: 0x16DA40 Offset: 0x16DB41 VA: 0x16DA40
	public int Score_DEFUp_Time; // 0x108

	// Methods

	// RVA: 0x224CC40 Offset: 0x224CD41 VA: 0x224CC40
	protected void .ctor() { }
}

