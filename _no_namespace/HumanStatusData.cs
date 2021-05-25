[MessagePackObjectAttribute] // RVA: 0x146C30 Offset: 0x146D31 VA: 0x146C30
public class HumanStatusData : StatusDataBase // TypeDefIndex: 8228
{
	// Fields
	[KeyAttribute] // RVA: 0x16CC20 Offset: 0x16CD21 VA: 0x16CC20
	public ActorID ActorID; // 0x10C
	[KeyAttribute] // RVA: 0x16CC40 Offset: 0x16CD41 VA: 0x16CC40
	public HumanEquip HumanEquip; // 0x110
	[KeyAttribute] // RVA: 0x16CC60 Offset: 0x16CD61 VA: 0x16CC60
	public PartnerMovementOrderType PartnerMovementOrderType; // 0x118
	[KeyAttribute] // RVA: 0x16CC80 Offset: 0x16CD81 VA: 0x16CC80
	public float DualSkillGauge; // 0x11C

	// Methods

	[SerializationConstructorAttribute] // RVA: 0x1A6620 Offset: 0x1A6721 VA: 0x1A6620
	// RVA: 0x20C4E60 Offset: 0x20C4F61 VA: 0x20C4E60
	public void .ctor() { }

	// RVA: 0x20C2A70 Offset: 0x20C2B71 VA: 0x20C2A70
	public void .ctor(ActorID id, HumanEquip humanEquip) { }
}

