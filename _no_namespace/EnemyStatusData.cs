[MessagePackObjectAttribute] // RVA: 0x146B80 Offset: 0x146C81 VA: 0x146B80
public class EnemyStatusData : StatusDataBase // TypeDefIndex: 8224
{
	// Fields
	[KeyAttribute] // RVA: 0x16BD10 Offset: 0x16BE11 VA: 0x16BD10
	public MonsterDataID MonsterDataID; // 0x10C
	[KeyAttribute] // RVA: 0x16BD30 Offset: 0x16BE31 VA: 0x16BD30
	public PartnerMovementOrderType PartnerMovementOrderType; // 0x110

	// Methods

	[SerializationConstructorAttribute] // RVA: 0x1A65F0 Offset: 0x1A66F1 VA: 0x1A65F0
	// RVA: 0x201ED10 Offset: 0x201EE11 VA: 0x201ED10
	public void .ctor() { }

	// RVA: 0x201E8C0 Offset: 0x201E9C1 VA: 0x201E8C0
	public void .ctor(MonsterDataID id, CharaParamDataTable charaParam) { }
}

