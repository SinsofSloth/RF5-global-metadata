[Serializable]
public class PartyMonster : PartyBase // TypeDefIndex: 6322
{
	// Properties
	public override PartyType PartyType { get; }
	public override CharacterStatusBase Status { get; }
	public FriendMonsterStatus FriendMonsterStatus { get; }

	// Methods

	// RVA: 0x1FE0A20 Offset: 0x1FE0B21 VA: 0x1FE0A20 Slot: 4
	public override PartyType get_PartyType() { }

	// RVA: 0x1FE0A40 Offset: 0x1FE0B41 VA: 0x1FE0A40 Slot: 5
	public override CharacterStatusBase get_Status() { }

	// RVA: 0x1FE0AB0 Offset: 0x1FE0BB1 VA: 0x1FE0AB0
	public FriendMonsterStatus get_FriendMonsterStatus() { }

	// RVA: 0x1FE0B50 Offset: 0x1FE0C51 VA: 0x1FE0B50
	public void .ctor(PartyData data) { }

	// RVA: 0x1FE0BA0 Offset: 0x1FE0CA1 VA: 0x1FE0BA0 Slot: 6
	public override void PartyIn() { }

	// RVA: 0x1FE0C60 Offset: 0x1FE0D61 VA: 0x1FE0C60 Slot: 7
	public override void PartyOut() { }
}

